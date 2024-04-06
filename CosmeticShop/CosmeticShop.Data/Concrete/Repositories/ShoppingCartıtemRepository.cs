using CosmeticShop.Data.Abstract;
using CosmeticShop.Data.Concrete.Contexts;
using CosmeticShop.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosmeticShop.Data.Concrete.Repositories
{
    public class ShoppingCartıtemRepository:GenericRepository<ShoppingCartItem>,IShoppingCartItemRepository
    {
        public ShoppingCartıtemRepository(CosmeticShopDbContext context) : base(context) 
        {

        }
        CosmeticShopDbContext CosmeticShopDbContext
        {
            get { return _dbContext as CosmeticShopDbContext; }
        }

        public async Task ChangeQuantityAsync(ShoppingCartItem shoppingCartItem, int quantity)
        {
            shoppingCartItem.Quantity = quantity;
            CosmeticShopDbContext.Update(shoppingCartItem);
            await CosmeticShopDbContext.SaveChangesAsync();
        }
    }
}
