using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using luce_MIS4200_940.Models;

namespace luce_MIS4200_940.DAL
{
    public class MIS4200Context : DbContext
    {
        public MIS4200Context() : base("name=DefaultConnection")
        {

        }
        public DbSet<customer> Customer {get; set; }
        public DbSet<customerOrder> CustomerOrder { get; set; }
        public DbSet<lineItem> LineItem { get; set; }
        public DbSet<product> Product  { get; set; }

    }
}