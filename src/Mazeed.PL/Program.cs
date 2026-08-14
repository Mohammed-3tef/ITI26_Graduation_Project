using Mazeed.BLL.Extensions;
using Mazeed.DAL.Database;
using Mazeed.DAL.Repos.Abstraction;
using Mazeed.DAL.Repos.Implementation;

namespace Mazeed.PL;

public class Program
{
    public static async Task Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // ==========================================
        // 1. Dependency Injection / Services Area
        // ==========================================

        // أ) إضافة الـ Controllers والـ Views
        builder.Services.AddControllersWithViews();

        // ب) تسجيل باقي الخدمات عبر الـ Extension Methods
        // (ملف AddInfrastructureServices جواه الـ DbContext والـ Identity والـ Cookies)
        builder.Services.AddApplicationServices();
        builder.Services.AddInfrastructureServices(builder.Configuration);

        // ج) تسجيل الـ Repositories والـ Unit of Work
        builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();


        // ==========================================
        // 2. Build Application
        // ==========================================
        var app = builder.Build();


        // ==========================================
        // 3. Database Seeding Execution (Runtime)
        // ==========================================
        using (var scope = app.Services.CreateScope())
        {
            var services = scope.ServiceProvider;
            try
            {
                await DbInitializer.SeedAsync(services);
            }
            catch (Exception ex)
            {
                var logger = services.GetRequiredService<ILogger<Program>>();
                logger.LogError(ex, "An error occurred while seeding the database.");
            }
        }


        // ==========================================
        // 4. HTTP Request Pipeline (Middlewares)
        // ==========================================
        if (!app.Environment.IsDevelopment())
        {
            app.UseExceptionHandler("/Error/500");
            app.UseHsts();
        }

        app.UseHttpsRedirection();
        app.UseStaticFiles();

        app.UseRouting();

        // الترتيب: Authentication ثم Authorization
        app.UseAuthentication();
        app.UseAuthorization();

        app.UseStatusCodePagesWithReExecute("/Error/{0}");

        app.MapControllerRoute(
            name: "default",
            pattern: "{controller=Home}/{action=Index}/{id?}");

        // تشغيل التطبيق
        app.Run();
    }
}