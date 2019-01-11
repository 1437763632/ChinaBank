using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ChinaBank.MVC.Controllers
{
    public class ManageController : Controller
    {
        // GET: Manage
        //[LoginFatier]
        public ActionResult Index()
        {
            return View();
        }
        [LoginFatier]
        public ActionResult Index2()
        {
            return View();
        }
        [LoginFatier]
        public ActionResult ManageAdd()
        {
            return View();
        }
        [LoginFatier]
        public ActionResult ManageUpdate()
        {
            return View();
        }
    }
}