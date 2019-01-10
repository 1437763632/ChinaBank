using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ChinaBank.MVC.Controllers
{
    public class ManagemessageController : Controller
    {
        // GET: Managemessage
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult AddManage()
        {
            return View();
        }
    }
}