using System;
using System.Collections.Generic;

namespace WebApp_Add_Cart.Models
{
    public partial class OrderTable
    {
        public int OrderId { get; set; }
        public string? Fullname { get; set; }
        public string? Phone { get; set; }
        public string? Address { get; set; }
        public int? Quantity { get; set; }
        public string? TotalAmount { get; set; }
        public string? OrderDate { get; set; }
        public int? PIdFk { get; set; }

        public virtual Product? PIdFkNavigation { get; set; }
    }
}
