using System;
using System.Collections.Generic;

namespace WebApp_DataBaseHandling.Models
{
    public partial class ProductTbl
    {
        public int ProId { get; set; }
        public string? ProName { get; set; }
        public string? ProDes { get; set; }
        public int? ProPrice { get; set; }
        public string? ProImage { get; set; }
        public int? CatIdFk { get; set; }

        public virtual CategoryTbl? CatIdFkNavigation { get; set; }
    }
}
