using Mazeed.DAL.Database;
using Mazeed.DAL.Repos.Abstraction;
using Mazeed.DAL.Repos.Implementation;
using Mazeed.PL.Extensions;
using Mazeed.BLL.Extensions;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Mazeed.PL;

public class Program
{
    public static async Task Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // 1. Controllers
        builder.Services.AddControllersWithViews();

        // 2. Extensions
        builder.Services.AddApplicationServices();
        builder.Services.AddInfrastructureServices(builder.Configuration);

        // 3. DbContext
        var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
        builder.Services.AddDbContext<AppDbContext>(options =>
            options.UseSqlServer(connectionString));

        // 4. Identity (الحل هنا - يجب أن يتطابق مع IdentityUser<int>)
        builder.Services.AddIdentity<IdentityUser<int>, IdentityRole<int>>()
            .AddEntityFrameworkStores<AppDbContext>()
            .AddDefaultTokenProviders();

        // 5. Repositories
        builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();


        var app = builder.Build();


        // --- Database Seeding Execution ---
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

        if (!app.Environment.IsDevelopment())
        {
            app.UseExceptionHandler("/Error/500");
            // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
            app.UseHsts();
        }

        app.UseHttpsRedirection();
        app.UseStaticFiles();
        app.UseRouting();

        app.UseAuthentication();
        app.UseAuthorization();

        app.UseStatusCodePagesWithReExecute("/Error/{0}");
        app.MapControllerRoute(
            name: "default",
            pattern: "{controller=Home}/{action=Index}/{id?}");

        app.Run();
    }
}