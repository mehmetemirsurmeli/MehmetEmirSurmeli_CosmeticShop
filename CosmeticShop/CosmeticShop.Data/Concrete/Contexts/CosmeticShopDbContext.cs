using CosmeticShop.Data.Concrete.Configs;
using CosmeticShop.Data.Extensions;
using CosmeticShop.Entity.Concrete;
using CosmeticShop.Entity.Concrete.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosmeticShop.Data.Concrete.Contexts
{
    public class CosmeticShopDbContext :IdentityDbContext<User,Role,string>
    {
        public CosmeticShopDbContext(DbContextOptions options):base(options)
        {

        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }
        public DbSet<ShoppingCart> ShoppingCarts { get; set;}
        public DbSet<ShoppingCartItem> ShoppingCartItems { get; set;}
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Message> Messages { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.SeedData();
            builder.ApplyConfigurationsFromAssembly(typeof(CategoryConfig).Assembly);
            base.OnModelCreating(builder);
        }
    }
}
