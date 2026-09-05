using System.Linq;
using Mazeed.DAL.Database;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

public class DashboardController : Controller
{
    private readonly AppDbContext _context;

    public DashboardController(AppDbContext context)
    {
        _context = context;
    }

    public async Task<IActionResult> Index()
    {
        ViewBag.Categories = await _context.Categories.Where(c => !c.IsDeleted).ToListAsync();
        ViewBag.Brands = await _context.Brands.Where(b => !b.IsDeleted).ToListAsync();
        return View();
    }

    [HttpGet]
    public async Task<IActionResult> GetDashboardData(DateTime? startDate, DateTime? endDate, List<int> categoryIds, List<int> brandIds)
    {
        var query = _context.Orders.Where(o => !o.IsDeleted).AsQueryable();

        // 1. تطبيق فلاتر التاريخ، الفئات، والبراندات
        if (startDate.HasValue) query = query.Where(o => o.OrderingDate >= startDate.Value);
        if (endDate.HasValue) query = query.Where(o => o.OrderingDate < endDate.Value.Date.AddDays(1));

        if (categoryIds != null && categoryIds.Any())
        {
            query = query.Where(o => _context.OrderDetails
                .Any(od => od.OrderId == o.Id && _context.ItemCategories
                    .Any(ic => ic.ItemId == od.ItemVariant.ItemId && categoryIds.Contains((int)ic.CategoryId))));
        }

        if (brandIds != null && brandIds.Any())
        {
            query = query.Where(o => _context.OrderDetails
                .Any(od => od.OrderId == o.Id && brandIds.Contains((int)od.ItemVariant.Item.BrandId)));
        }

        var ordersList = await query.ToListAsync();

        // 2. حساب الـ 4 KPI Cards
        var orderIds = ordersList.Select(o => o.Id).ToList();
        var paidOrderIds = await _context.Payments
            .Where(payment => orderIds.Contains(payment.OrderId) &&
                payment.Status.Trim().Equals("Paid"))
            .Select(payment => payment.OrderId)
            .ToListAsync();

        var completedOrders = ordersList.Where(o =>
            paidOrderIds.Contains(o.Id) ||
            o.Status.Trim().Equals("Paid", StringComparison.OrdinalIgnoreCase) ||
            o.Status.Trim().Equals("Delivered", StringComparison.OrdinalIgnoreCase)).ToList();
        decimal totalSales = completedOrders.Sum(o => o.TotalPrice);
        int totalOrders = ordersList.Count;
        decimal avgOrderValue = completedOrders.Count > 0 ? totalSales / completedOrders.Count : 0;
        int activeShoppers = completedOrders.Select(o => o.UserId).Distinct().Count();

        // 3. حساب الشارتات (Charts Data)
        // Chart 1: Sales Trend over time
        var salesTrend = completedOrders
            .GroupBy(o => o.OrderingDate.ToString("yyyy-MM"))
            .OrderBy(g => g.Key)
            .Select(g => new { Label = g.Key, Total = g.Sum(o => o.TotalPrice) });

        // Chart 2: Sales % by Category
        var salesByCategory = await _context.OrderDetails
            .Where(od => completedOrders.Select(o => o.Id).Contains(od.OrderId))
            .SelectMany(od => _context.ItemCategories.Where(ic => ic.ItemId == od.ItemVariant.ItemId),
                (od, ic) => new { CategoryName = ic.Category.Name, Total = od.Quantity * od.PricePerItem })
            .GroupBy(x => x.CategoryName)
            .Select(g => new { Label = g.Key, Total = g.Sum(x => x.Total) }).ToListAsync();

        // Chart 3: Payment Methods
        var paymentMethods = await _context.Payments
            .Where(p => completedOrders.Select(o => o.Id).Contains(p.OrderId))
            .GroupBy(p => p.Method)
            .Select(g => new { Label = g.Key, Count = g.Count() }).ToListAsync();

        // Chart 4: Top 8 Selling Items
        var topItems = await _context.OrderDetails
            .Where(od => completedOrders.Select(o => o.Id).Contains(od.OrderId))
            .GroupBy(od => od.ItemVariant.Item.Name)
            .Select(g => new { Label = g.Key, TotalQuantity = g.Sum(od => od.Quantity) })
            .OrderByDescending(x => x.TotalQuantity)
            .Take(8).ToListAsync();

        // Chart 5: Sales % by Order Status
        var salesByStatus = ordersList
            .GroupBy(o => o.Status.Trim())
            .Select(g => new { Label = g.Key, Count = g.Count() });

        return Json(new
        {
            kpis = new { totalSales, totalOrders, avgOrderValue, activeShoppers },
            salesTrend,
            salesByCategory,
            paymentMethods,
            topItems,
            salesByStatus
        });
    }
}