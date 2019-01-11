using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ChinaBank.Model;
namespace ChinaBank.MVC.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public int Login(Manage manage)
        {
            Session["Pass"] = manage.ManagePwd;
            Session["Name"] = manage.ManageName;
            Session["Id"] = manage.Id;
            return 1;
        }
    }
}