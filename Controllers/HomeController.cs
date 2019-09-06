using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace luce_MIS4200_940.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "First MIS4200 Web Site.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Contact Luce";

            return View();
        }
    }
}