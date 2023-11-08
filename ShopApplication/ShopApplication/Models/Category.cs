﻿using System;
using System.Collections.Generic;

namespace ShopApplication.Models
{
    public partial class Category
    {
        public Category()
        {
            Products = new HashSet<Product>();
        }

        public int CId { get; set; }
        public string? CName { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
