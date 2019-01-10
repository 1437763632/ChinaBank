using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ChinaBank.MVC.Controllers
{
    public class ProjmessageController : Controller
    {
        // GET: Projmessage
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult AddProjmessage()
        {
            return View();
        }
    }
}