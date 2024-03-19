using CosmeticShop.Data.Concrete.Configs;
using CosmeticShop.Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CosmeticShop.Entity.Concrete.Identity;
using CosmeticShop.Data.Extensions;


namespace CosmeticShop.Data.Concrete.Contexts
{
    public class CosmeticShopDbContext : IdentityDbContext<User,Role,string>
    {
        public CosmeticShopDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.SeedData();
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(CategoryConfig).Assembly);
            base.OnModelCreating(modelBuilder);
        }
    }
}
