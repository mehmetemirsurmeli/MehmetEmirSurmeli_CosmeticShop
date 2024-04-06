using CosmeticShop.Business.Abstract;
using CosmeticShop.Entity.Concrete;
using CosmeticShop.Shared.ComplexTypes;
using CosmeticShop.Shared.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosmeticShop.Business.Concrete
{
    public class OrderManager : IOrderService
    {
        
        public Task CancelOrder(int orderId)
        {
            throw new NotImplementedException();
        }

        public Task<OrderState> ChangeStatus(int id, OrderState orderState)
        {
            throw new NotImplementedException();
        }

        public Task CreateAsync(Order order)
        {
            throw new NotImplementedException();
        }

        public Task<AdminOrderViewModel> GetOrderAsync(int orderId)
        {
            throw new NotImplementedException();
        }

        public Task<List<AdminOrderViewModel>> GetOrdersAsync()
        {
            throw new NotImplementedException();
        }

        public Task<List<AdminOrderViewModel>> GetOrdersAsync(string userId)
        {
            throw new NotImplementedException();
        }

        public Task<List<AdminOrderViewModel>> GetOrdersAsync(int productId)
        {
            throw new NotImplementedException();
        }
    }
}
