using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ChinaBank.Model;
using Models;

namespace ChinaBank.MVC.Controllers
{
    public class mainController : Controller
    {
        // GET: main
        [LoginFatier]
        public ActionResult Index()
        {
            ViewBag.Name = Session["Name"];
            ViewBag.Pass = Session["Pass"];
            ViewBag.Id = Session["Id"];
            return View();
        }
    }
}