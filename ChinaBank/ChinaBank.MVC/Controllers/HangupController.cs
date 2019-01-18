using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ChinaBank.MVC.Controllers
{
    public class HangupController : Controller
    {
        // GET: Hangup
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult AddHangup()
        {
            return View();
        }
        public ActionResult GetHangupById()
        {
            return View();
        }
        /// <summary>
        /// PMO审批
        /// </summary>
        /// <returns></returns>
        public ActionResult PMOAuditIndex()
        {
            return View();
        }
        public ActionResult PMOAudit()
        {
            return View();
        }
        /// <summary>
        /// 开发部主管审批
        /// </summary>
        /// <returns></returns>
        public ActionResult DepartmentAuditIndex()
        {
            return View();
        }
        public ActionResult DepartmentAudit()
        {
            return View();
        }
        /// <summary>
        /// 工程管理部审批
        /// </summary>
        /// <returns></returns>
        public ActionResult ProjectAuditIndex()
        {
            return View();
        }
        public ActionResult ProjectAudit()
        {
            return View();
        }
        /// <summary>
        /// 项目管理部审批
        /// </summary>
        /// <returns></returns>
        public ActionResult ItemAuditIndex()
        {
            return View();
        }
        public ActionResult ItemAudit()
        {
            return View();
        }
        /// <summary>
        /// 总经理室审批
        /// </summary>
        /// <returns></returns>
        public ActionResult GmAuditIndex()
        {
            return View();
        }
        public ActionResult GmAudit()
        {
            return View();
        }
    }
}