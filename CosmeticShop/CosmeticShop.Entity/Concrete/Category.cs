using CosmeticShop.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace CosmeticShop.Entity.Concrete
{
    public class Category:GeneralEntity,IMainEntity
    {
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }= DateTime.Now;
        public string CategoryDescription { get; set; }
        public List<ProductCategory> ProductCategories { get; set; }


    }
}
