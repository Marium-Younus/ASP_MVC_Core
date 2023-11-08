using System;
using System.Collections.Generic;

namespace ShopApplication.Models
{
    public partial class ViewPc
    {
        public int PId { get; set; }
        public string? PName { get; set; }
        public string? PPrice { get; set; }
        public string? PDes { get; set; }
        public string? PImage { get; set; }
        public string? CName { get; set; }
    }
}
