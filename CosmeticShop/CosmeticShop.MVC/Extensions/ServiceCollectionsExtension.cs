using CosmeticShop.Data.Concrete.Contexts;
using Microsoft.EntityFrameworkCore;

namespace CosmeticShop.MVC.Extensions
{
    public static class ServiceCollectionsExtension
    {
        public static IServiceCollection LoadMyDbContextServices(this IServiceCollection services)
        {
            services.AddDbContext<CosmeticShopDbContext>(options => 
            options
            .UseSqlite(services
                        .BuildServiceProvider()
                        .GetRequiredService<IConfiguration>()
                        .GetConnectionString("SqliteConnection")));
            return services;
        }
    }
}
