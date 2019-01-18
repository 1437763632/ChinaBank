using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ChinaBank.MVC.Controllers
{
    public class SolutiontohangController : Controller
    {
        // GET: Solutiontohang
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult AddSolutiontohang()
        {
            return View();
        }
        public ActionResult GetSolutiontohangById()
        {
            return View();
        }
        /// <summary>
        /// PMO审批
        /// </summary>
        /// <returns></returns>
        public ActionResult PMOSolutionIndex()
        {
            return View();
        }
        public ActionResult PMOSolution()
        {
            return View();
        }
        /// <summary>
        /// 开发部主管审批
        /// </summary>
        /// <returns></returns>
        public ActionResult DepartmentSolutionIndex()
        {
            return View();
        }
        public ActionResult DepartmentSolution()
        {
            return View();
        }
        /// <summary>
        /// 工程管理部审批
        /// </summary>
        /// <returns></returns>
        public ActionResult ProjectSolutionIndex()
        {
            return View();
        }
        public ActionResult ProjectSolution()
        {
            return View();
        }
        /// <summary>
        /// 项目管理部审批
        /// </summary>
        /// <returns></returns>
        public ActionResult ItemSolutionIndex()
        {
            return View();
        }
        public ActionResult ItemSolution()
        {
            return View();
        }
        /// <summary>
        /// 总经理室审批
        /// </summary>
        /// <returns></returns>
        public ActionResult GmoSolutionIndex()
        {
            return View();
        }
        public ActionResult GmoSolution()
        {
            return View();
        }
    }
}