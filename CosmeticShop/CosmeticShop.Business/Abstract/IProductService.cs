﻿using CosmeticShop.Shared.ResponseViewModels;
using CosmeticShop.Shared.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosmeticShop.Business.Abstract
{
    public interface IProductService
    {
        Task<Response<ProductViewModel>> GetByIdAsync(int id);
        Task<Response<List<ProductViewModel>>> GetAllAsync();
        Task<Response<NoContent>> HardDeleteAsync(int id);
        Task<Response<NoContent>> SoftDeleteAsync(int id);
        Task<Response<List<ProductViewModel>>> GetAllNonDeletedAsync(bool isDeleted = false);
        Task<Response<List<ProductViewModel>>> GetAllProductsWithCategoriesAsync();
        Task<Response<ProductViewModel>> GetProductWithCategoriesAsync(int id);
        Task<Response<NoContent>> UpdateIsHomeAsync(int id);
        Task<Response<NoContent>> UpdateIsActiveAsync(int id);
        Task<Response<int>> GetActiveProductCount();
        Task<Response<int>> GetProductCount();
        #region Product
        Task<Response<List<ProductViewModel>>> GetProductsByCategoryIdAsync(int categoryId);
        Task<Response<List<ProductViewModel>>> GetProductsByCategoryUrlAsync(string categoryUrl);

        #endregion
    }
}
