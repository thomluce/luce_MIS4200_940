using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace luce_MIS4200_940.Models
{
    public class product
    {
        public int productID { get; set; }
        public string description { get; set; }
        public decimal listPrice { get; set; }
        public int supplierID { get; set; }
        public ICollection<lineItem> lineItem { get; set; }
    }
}