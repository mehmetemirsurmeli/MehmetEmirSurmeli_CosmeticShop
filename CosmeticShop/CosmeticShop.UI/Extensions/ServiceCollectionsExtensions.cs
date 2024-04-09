using CosmeticShop.Business.Abstract;
using CosmeticShop.Business.Concrete;
using CosmeticShop.Data.Abstract;
using CosmeticShop.Data.Concrete.Contexts;
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
            services.AddScoped<ICategoryService, CategoryManager>();
            services.AddScoped<IProductService, ProductManager>();


            services.AddScoped<ICategoryRepository, CategoryRepository>();
            services.AddScoped<IProductRepository, ProductRepository>();

            return services;
        }

        public static IServiceCollection LoadMyOtherService(this IServiceCollection services)
        {
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
            return services;
        }

    }
}
