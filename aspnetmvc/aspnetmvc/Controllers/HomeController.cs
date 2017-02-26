using aspnetmvc.ActionFilters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace aspnetmvc.Controllers
{
    [MyLogActionFilter]
    public class HomeController : Controller
    {
        // GET: Home
        public string Index()
        {
            return "Hello ASP.NET MVC"; //View();
        }

        [OutputCache(Duration=10)]
        public ActionResult GetDateTime()
        {
            return Content(DateTime.Now.ToString("T"));
        }

        public ActionResult MyView()
        {
            return View();
        }
    }
}