﻿using CosmeticShop.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosmeticShop.Entity.Concrete
{
    public class Product : GeneralEntity, IMainEntity
    {
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public decimal Price { get; set; }
        public string Properties { get; set; }
        public string ImageUrl { get; set; }
        public bool IsHome { get; set; }
        public List<ProductCategory> ProductCategories { get; set; }//Navigation Property
    }
}
