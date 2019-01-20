using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ChinaBank.MVC.Controllers
{
    public class InitiationController : Controller
    {
        // GET: Initiation
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult AddInitiation()
        {
            return View();
        }
        public ActionResult UpdateInitiation()
        {
            return View();
        }

        public  ActionResult Add()
        {
            return View();
        }
        /// <summary>
        /// 项目管理部主管审批
        /// </summary>
        /// <returns></returns>
        public ActionResult ApproveOne()
        {
            return View();
        }

        /// <summary>
        /// 财务部主管审批
        /// </summary>
        /// <returns></returns>
        public ActionResult ApproveTwo()
        {
            return View();
        }
    }
}