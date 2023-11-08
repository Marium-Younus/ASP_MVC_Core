using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ShopApplication.Models
{
    public partial class Product
    {
        public int PId { get; set; }
        [Required(ErrorMessage = "Product Name is Required")]
        public string? PName { get; set; }

        [Required(ErrorMessage = "Product Price is Required")]
        public string? PPrice { get; set; }

        [Required(ErrorMessage = "Product Description is Required")]
        public string? PDes { get; set; }
        public string? PImage { get; set; }
        public int? CIdFk { get; set; }

        public virtual Category? CIdFkNavigation { get; set; }
    }
}
