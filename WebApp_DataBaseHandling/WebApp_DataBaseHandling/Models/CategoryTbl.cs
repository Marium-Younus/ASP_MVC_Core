using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebApp_DataBaseHandling.Models
{
    public partial class CategoryTbl
    {
        public CategoryTbl()
        {
            ProductTbls = new HashSet<ProductTbl>();
        }

        public int CatId { get; set; }
        [Required(ErrorMessage = "Please Enter Category Name ")]
        public string? CatName { get; set; }

        public virtual ICollection<ProductTbl> ProductTbls { get; set; }
    }
}
