using CosmeticShop.Data.Abstract;
using CosmeticShop.Data.Concrete.Context;
using CosmeticShop.Data.Concrete.Repositories;
using Microsoft.EntityFrameworkCore;

namespace CosmeticShop.UI.Extensions
{
    public static class ServiceCollectionsExtensions
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
        public static IServiceCollection LoadMyRepository(this IServiceCollection services)
        {
            services.AddScoped<ICategoryRepository, CategoryRepository>();
            services.AddScoped<IProductRepository, ProductRepository>();

            return services;
        }

    }
}
