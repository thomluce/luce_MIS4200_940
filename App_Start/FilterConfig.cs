﻿using System.Web;
using System.Web.Mvc;

namespace luce_MIS4200_940
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
