using System;
using System.Collections.Generic;

namespace WebApp_Add_Cart.Models
{
    public partial class Customer
    {
        public int CustId { get; set; }
        public string? CustName { get; set; }
        public string? CustEmail { get; set; }
        public string? CustPassword { get; set; }
        public string? CustPhone { get; set; }
    }
}
