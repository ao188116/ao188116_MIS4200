using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ao188116_MIS4200.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Dayton, OH";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Contact Information Below:";

            return View();
        }
    }
}