using System;
using System.Collections.Generic;

namespace WebApp_Add_Cart.Models
{
    public partial class Category
    {
        public Category()
        {
            Products = new HashSet<Product>();
        }

        public int Catid { get; set; }
        public string? Catname { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
