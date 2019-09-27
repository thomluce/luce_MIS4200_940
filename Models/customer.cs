using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace luce_MIS4200_940.Models
{
    public class customer
    {
        [Display(Name ="Customer ID")]
        public int customerID { get; set; }

        [Display(Name ="Customer Last Name")]
        public string lastName { get; set; }

        [Display(Name = "Customer First Name")]
        public string firstName { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        [Display(Name ="Customer Name")]
        public string fullName { get
            {
                return lastName + ", " + firstName;
            }
        }
        public ICollection<customerOrder> orders { get; set; }

    }
}