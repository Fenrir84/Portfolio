using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TylerWebsite.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View("TylerHome");
        }

        public ActionResult TylerHome()
        {
            return View();
        }    
    }
}