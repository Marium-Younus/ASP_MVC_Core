using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Online_Shpping_Cart.Models
{
    public class ok
    {
        public static List<Cart> c = new List<Cart>();
    }

    public partial class Cart
    {
        public int Id { get; set; }
        public Nullable<int> Quantity { get; set; }
    }
}