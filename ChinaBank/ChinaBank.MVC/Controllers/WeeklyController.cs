using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ChinaBank.MVC.Controllers
{
    public class WeeklyController : Controller
    {
        // GET: Weekly
        public ActionResult Index()
        {
            return View();
        }
        
        public ActionResult AddWeekly()
        {
            return View();
        }
        public ActionResult UpdateWeekly()
        {
            return View();
        }
    }
}