using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ChinaBank.MVC.Controllers
{
    public class StackeholderController : Controller
    {
        // GET: Stackeholder  Addstackeholder
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Addstackeholder()
        {
            return View();
        }
    }
}