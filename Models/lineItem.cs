using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace luce_MIS4200_940.Models
{
    public class lineItem
    {
        public int ID { get; set; }
        public string description { get; set; }
        public int qty { get; set; }
        public decimal unitPrice { get; set; }
        public virtual customerOrder customerOrder { get; set; }  // link to the order
        public virtual product product  { get; set; } // link to the product
    }
}