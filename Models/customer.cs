﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace luce_MIS4200_940.Models
{
    public class customer
    {
        public int customerID { get; set; }
        public string lastName { get; set; }
        public string firstName { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public ICollection<customerOrder> orders { get; set; }

    }
}