﻿using CosmeticShop.Shared.ViewModels.IdentityModels;

namespace CosmeticShop.Shared.ViewModels.IdentityModels
{
    public class UserProfileViewModel
    {
        public UserViewModel User { get; set; }
        public List<AdminOrderViewModel> Orders { get; set; }
    }
}
