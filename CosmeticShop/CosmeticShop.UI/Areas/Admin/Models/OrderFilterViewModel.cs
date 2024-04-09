using Microsoft.AspNetCore.Mvc.Rendering;
using CosmeticShop.Shared.ViewModels;

namespace CosmeticShop.UI.Areas.Admin.Models
{
    public class OrderFilterViewModel
    {
        public List<AdminOrderViewModel> Orders { get; set; }
        public List<SelectListItem> ProductListItems { get; set; }
    }
}
