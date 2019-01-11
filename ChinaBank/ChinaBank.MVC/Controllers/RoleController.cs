using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ChinaBank.MVC.Controllers
{
    public class RoleController : Controller
    {
        // GET: Role
        [LoginFatier]
        public ActionResult Index()
        {
            return View();
        }
        [LoginFatier]
        public ActionResult Add()
        {
            return View();
        }
        [LoginFatier]
        public ActionResult Update()
        {
            return View();
        }
    }
}