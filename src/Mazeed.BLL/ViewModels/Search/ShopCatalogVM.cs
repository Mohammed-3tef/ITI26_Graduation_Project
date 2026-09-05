using Mazeed.BLL.ViewModels;

namespace Mazeed.BLL.ViewModels
{
    public class ShopCatalogVM
    {
        // Search & Filter Parameters
        public string? SearchQuery { get; set; }
        public string? SortBy { get; set; }
        public long? BrandId { get; set; }
        public long? CategoryId { get; set; }
        public decimal? MinPrice { get; set; }
        public decimal? MaxPrice { get; set; }

        // Real Database Bounds (Added for Range Slider Initialization)
        public decimal DbMinPrice { get; set; }
        public decimal DbMaxPrice { get; set; }

        // Data Lists
        public IEnumerable<ItemVM> Items { get; set; } = new List<ItemVM>();
        public IEnumerable<BrandVM> Brands { get; set; } = new List<BrandVM>();
        public IEnumerable<CategoryVM> Categories { get; set; } = new List<CategoryVM>();

        // خريطة: CategoryId -> قايمة BrandIds اللي ليها منتجات فعلية في الكاتيجوري دي
        // بتتحسب من الـ Controller وبتتبعت للـ View كـ JSON عشان الـ Brand dropdown يتفلتر ديناميك (JS) لما اليوزر يختار كاتيجوري
        public Dictionary<long, List<long>> CategoryBrandMap { get; set; } = new();

        // بيانات مصغّرة عن كل منتجات الصفحة (قبل فلترة الفورم الحالية) عشان الـ JS يقدر
        // يحسب عدد الـ "Apply (count)" لحظيًا مع أي تغيير في الفلتر من غير Reload للسيرفر
        public List<ItemFilterMetaVM> ItemsFilterMeta { get; set; } = new();

        public int TotalCount => Items?.Count() ?? 0;
    }

    // نسخة خفيفة جدًا من ItemVM تحمل بس الحقول اللي محتاجينها لحساب الفلترة على الـ Client-side
    public class ItemFilterMetaVM
    {
        public long Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public long BrandId { get; set; }
        public decimal Price { get; set; }
        public List<long> CategoryIds { get; set; } = new();
    }
}