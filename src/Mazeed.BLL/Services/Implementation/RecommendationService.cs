using System;
using System.Collections.Generic;
using System.Linq;
using Mazeed.BLL.Services.Abstraction;
using Mazeed.BLL.ViewModels;
using Mazeed.DAL.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;

namespace Mazeed.BLL.Services.Implementation
{
    public class RecommendationService : IRecommendationService
    {
        private readonly AppDbContext _context;
        private readonly IMemoryCache _cache;

        private const int ModelCacheMinutes = 15;
        private const double CategoryBonus = 0.20;

        public RecommendationService(AppDbContext context, IMemoryCache cache)
        {
            _context = context;
            _cache = cache;
        }

        // ==================== 1. توصيات صفحة الهوم / الكاتيجوري ====================
        public List<ItemVM> GetHomeRecommendations(long? userId, List<ItemVM> allItems, int count = int.MaxValue)
        {
            if (allItems == null || !allItems.Any()) return new List<ItemVM>();

            List<long> orderItemIds = new();
            List<long> cartItemIds = new();
            List<long> favItemIds = new();

            if (userId.HasValue && userId.Value > 0)
            {
                // 1. منتجات الأوردرات
                orderItemIds = _context.OrderDetails
                    .Where(od => od.Order.UserId == userId.Value)
                    .Select(od => od.ItemVariant.ItemId)
                    .Distinct()
                    .ToList();

                // 2. منتجات الكارت
                cartItemIds = _context.ShopperCarts
                    .Where(c => c.UserId == userId.Value)
                    .Select(c => c.ItemVariant.ItemId)
                    .Distinct()
                    .ToList();

                // 3. منتجات المفضلة
                favItemIds = _context.ShopperFavorites
                    .Where(f => f.UserId == userId.Value)
                    .Select(f => f.ItemId)
                    .Distinct()
                    .ToList();
            }

            // Cold start: المستخدم ملوش أي تفاعلات -> المنتجات الأكثر مبيعاً ثم باقي الكاتالوج
            if (!orderItemIds.Any() && !cartItemIds.Any() && !favItemIds.Any())
            {
                var topSellingIdsOrdered = _context.OrderDetails
                    .GroupBy(od => od.ItemVariant.ItemId)
                    .OrderByDescending(g => g.Sum(x => x.Quantity))
                    .Select(g => g.Key)
                    .ToList();

                if (topSellingIdsOrdered.Any())
                {
                    var itemsById = allItems.ToDictionary(i => i.Id);
                    var topItems = topSellingIdsOrdered
                        .Where(id => itemsById.ContainsKey(id))
                        .Select(id => itemsById[id])
                        .ToList();

                    var chosenIds = topItems.Select(i => i.Id).ToHashSet();
                    var remaining = allItems.Where(i => !chosenIds.Contains(i.Id)).ToList();
                    topItems.AddRange(remaining);

                    return topItems.Take(count).ToList();
                }

                return allItems.OrderByDescending(i => i.Id).Take(count).ToList();
            }

            // ==================== الترتيب بالأولوية التراكمية ====================
            var finalOrderedList = new List<ItemVM>();
            var excludedIds = new HashSet<long>();

            // أسباب استبعاد منتجات المستخدم المباشرة (اختياري حسب الرغبة)
            // إذا كنتِ تريدين إظهار المنتجات المشابهة فقط بدون المنتج نفسه:
            // foreach (var id in orderItemIds.Concat(cartItemIds).Concat(favItemIds)) excludedIds.Add(id);

            // المرحلة الأولى: ما يشبه منتجات الأوردر
            if (orderItemIds.Any())
            {
                var orderSimilar = CalculateTFIDFRecommendations(allItems, orderItemIds, int.MaxValue, excludedIds.ToList());
                foreach (var item in orderSimilar)
                {
                    finalOrderedList.Add(item);
                    excludedIds.Add(item.Id);
                }
            }

            // المرحلة الثانية: ما يشبه منتجات الكارت (بعد إستبعاد ما تم اختياره من الأوردر)
            if (cartItemIds.Any())
            {
                var cartSimilar = CalculateTFIDFRecommendations(allItems, cartItemIds, int.MaxValue, excludedIds.ToList());
                foreach (var item in cartSimilar)
                {
                    finalOrderedList.Add(item);
                    excludedIds.Add(item.Id);
                }
            }

            // المرحلة الثالثة: ما يشبه منتجات المفضلة (بعد إستبعاد ما تم اختياره سابقاً)
            if (favItemIds.Any())
            {
                var favSimilar = CalculateTFIDFRecommendations(allItems, favItemIds, int.MaxValue, excludedIds.ToList());
                foreach (var item in favSimilar)
                {
                    finalOrderedList.Add(item);
                    excludedIds.Add(item.Id);
                }
            }

            // المرحلة الرابعة: باقي الكاتالوج للمنتجات التي لم تدخل في أي تشابه
            var remainingItems = allItems.Where(i => !excludedIds.Contains(i.Id)).ToList();
            finalOrderedList.AddRange(remainingItems);

            return finalOrderedList.Take(count).ToList();
        }

        // ==================== 2. توصيات صفحة التفاصيل ====================
        public List<ItemVM> GetRelatedOrBoughtTogether(long itemId, List<ItemVM> allItems, int count = 4)
        {
            if (allItems == null || !allItems.Any()) return new List<ItemVM>();

            var boughtTogetherIdsOrdered = _context.OrderDetails
                .Where(od => _context.OrderDetails
                    .Where(sub => sub.ItemVariant.ItemId == itemId)
                    .Select(sub => sub.OrderId)
                    .Contains(od.OrderId) && od.ItemVariant.ItemId != itemId)
                .GroupBy(od => od.ItemVariant.ItemId)
                .OrderByDescending(g => g.Count())
                .Select(g => g.Key)
                .Take(count)
                .ToList();

            var itemsById = allItems.ToDictionary(i => i.Id);
            var result = boughtTogetherIdsOrdered
                .Where(id => itemsById.ContainsKey(id))
                .Select(id => itemsById[id])
                .ToList();

            if (result.Count >= count) return result;

            var remainingCount = count - result.Count;
            var excludeIds = result.Select(r => r.Id).Append(itemId).ToHashSet();

            var targetItem = itemsById.TryGetValue(itemId, out var t) ? t : null;
            var targetCategoryIds = targetItem?.CategoryIds ?? new List<long>();

            var sameCategoryPool = targetCategoryIds.Any()
                ? allItems.Where(i => !excludeIds.Contains(i.Id)
                                       && i.CategoryIds != null
                                       && i.CategoryIds.Any(c => targetCategoryIds.Contains(c)))
                          .ToList()
                : new List<ItemVM>();

            var similarFromCategory = CalculateTFIDFRecommendations(
                sameCategoryPool.Any() ? sameCategoryPool : allItems,
                new List<long> { itemId },
                remainingCount,
                excludeIds.ToList());

            result.AddRange(similarFromCategory);

            if (result.Count < count)
            {
                var stillNeeded = count - result.Count;
                var newExcludeIds = result.Select(r => r.Id).Append(itemId).ToList();
                var broaderSimilar = CalculateTFIDFRecommendations(allItems, new List<long> { itemId }, stillNeeded, newExcludeIds);
                result.AddRange(broaderSimilar);
            }

            return result;
        }

        // ==================== Private Helpers ====================
        private (List<string> Vocabulary, Dictionary<string, double> Idf, Dictionary<long, double[]> Vectors) GetOrBuildModel(List<ItemVM> items)
        {
            var cacheKey = $"tfidf_model_{items.Count}_{(items.Any() ? items.Max(i => i.Id) : 0)}";

            if (_cache.TryGetValue(cacheKey, out (List<string>, Dictionary<string, double>, Dictionary<long, double[]>) cached))
            {
                return cached;
            }

            var docs = items.ToDictionary(
                i => i.Id,
                i => Tokenize($"{i.Name} {i.BrandName}"));

            var vocabulary = docs.Values.SelectMany(x => x).Distinct().ToList();
            var docCount = Math.Max(docs.Count, 1);
            var idf = vocabulary.ToDictionary(
                term => term,
                term => Math.Log((double)docCount / (1 + docs.Values.Count(d => d.Contains(term)))));

            var vectors = new Dictionary<long, double[]>();
            foreach (var doc in docs)
            {
                var vec = new double[vocabulary.Count];
                var termFreqs = doc.Value.GroupBy(x => x).ToDictionary(g => g.Key, g => g.Count());
                for (int i = 0; i < vocabulary.Count; i++)
                {
                    var term = vocabulary[i];
                    if (termFreqs.TryGetValue(term, out int tf))
                    {
                        vec[i] = tf * idf[term];
                    }
                }
                vectors[doc.Key] = vec;
            }

            var model = (vocabulary, idf, vectors);
            _cache.Set(cacheKey, model, TimeSpan.FromMinutes(ModelCacheMinutes));
            return model;
        }

        private List<ItemVM> CalculateTFIDFRecommendations(List<ItemVM> allItems, List<long> targetIds, int count, List<long>? excludeIds = null)
        {
            excludeIds ??= new List<long>();
            if (allItems == null || !allItems.Any() || count <= 0) return new List<ItemVM>();

            var (vocabulary, _, vectors) = GetOrBuildModel(allItems);
            var itemsById = allItems.ToDictionary(i => i.Id);

            if (!vocabulary.Any())
                return allItems.Where(i => !excludeIds.Contains(i.Id)).Take(count).ToList();

            var validTargetItems = targetIds.Where(id => vectors.ContainsKey(id)).ToList();
            if (!validTargetItems.Any())
                return allItems.Where(i => !excludeIds.Contains(i.Id)).Take(count).ToList();

            var userVector = new double[vocabulary.Count];
            foreach (var id in validTargetItems)
            {
                var vec = vectors[id];
                for (int i = 0; i < vocabulary.Count; i++) userVector[i] += vec[i];
            }
            for (int i = 0; i < vocabulary.Count; i++) userVector[i] /= validTargetItems.Count;

            var targetCategoryIds = validTargetItems
                .Select(id => itemsById.TryGetValue(id, out var it) ? it.CategoryIds : null)
                .Where(c => c != null)
                .SelectMany(c => c!)
                .Distinct()
                .ToHashSet();

            var scores = new Dictionary<long, double>();
            foreach (var item in allItems)
            {
                if (targetIds.Contains(item.Id) || excludeIds.Contains(item.Id)) continue;
                if (!vectors.ContainsKey(item.Id)) continue;

                var score = CosineSimilarity(userVector, vectors[item.Id]);

                if (targetCategoryIds.Any() && item.CategoryIds != null && item.CategoryIds.Any(c => targetCategoryIds.Contains(c)))
                {
                    score += CategoryBonus;
                }

                scores[item.Id] = score;
            }

            return scores
                .Where(kv => kv.Value > 0) // أخذ المنتجات التي بينها تشابه فقط
                .OrderByDescending(kv => kv.Value)
                .Take(count)
                .Select(kv => itemsById[kv.Key])
                .ToList();
        }

        private List<string> Tokenize(string text)
        {
            if (string.IsNullOrWhiteSpace(text)) return new List<string>();
            return text.ToLower()
                       .Split(new[] { ' ', ',', '.', '-', '/', '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries)
                       .Where(w => w.Length > 2)
                       .ToList();
        }

        private double CosineSimilarity(double[] vecA, double[] vecB)
        {
            double dotProduct = 0, normA = 0, normB = 0;
            for (int i = 0; i < vecA.Length; i++)
            {
                dotProduct += vecA[i] * vecB[i];
                normA += vecA[i] * vecA[i];
                normB += vecB[i] * vecB[i];
            }
            if (normA == 0 || normB == 0) return 0;
            return dotProduct / (Math.Sqrt(normA) * Math.Sqrt(normB));
        }
    }
}