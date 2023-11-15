using System;
using System.Collections.Generic;

namespace WebApp_Add_Cart.Models
{
    public partial class Product
    {
        public int Proid { get; set; }
        public string? Proname { get; set; }
        public double? Proprice { get; set; }
        public string? Prodes { get; set; }
        public string? Proimage { get; set; }
        public int? CatIdFk { get; set; }

        public virtual Category? CatIdFkNavigation { get; set; }
    }
}
