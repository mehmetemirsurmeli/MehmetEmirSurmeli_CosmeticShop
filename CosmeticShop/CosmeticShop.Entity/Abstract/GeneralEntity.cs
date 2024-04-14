using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosmeticShop.Entity.Abstract
{
    public abstract class GeneralEntity
    {
        public string Name { get; set; }
        public DateTime ModifiedDate { get; set; } = DateTime.Now;
        public bool IsDeleted { get; set; }
        public bool IsActive { get; set; } = true;
        public string Url { get; set; }
    }
}
