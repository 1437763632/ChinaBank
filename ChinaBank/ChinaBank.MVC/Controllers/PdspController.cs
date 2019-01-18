using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ChinaBank.MVC.Controllers
{
    public class PdspController : Controller
    {
        // GET: Pdsp
        /// <summary>
        /// 结项信息表
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            return View();
        }
        /// <summary>
        /// 项目信息表
        /// </summary>
        /// <returns></returns>
        public ActionResult Index2()
        {
            return View();
        }
        // 结项申请
        public ActionResult Add()
        {
            ViewBag.Name = Session["Name"];
            return View();
        }
        /// <summary>
        /// PMO审批显示
        /// </summary>
        /// <returns></returns>
        public ActionResult Index_PMO()
        {
            return View();
        }
        //PMO审批
        public ActionResult Add_PMO()
        {
            return View();
        }

        /// <summary>
        /// 牵头部门显示
        /// </summary>
        /// <returns></returns>
        public ActionResult Index_Imp()
        {
            return View();
        }
        //牵头部门审批
        public ActionResult Add_Imp()
        {
            return View();
        }

        /// <summary>
        /// 项目部门显示
        /// </summary>
        /// <returns></returns>
        public ActionResult Index_Item()
        {
            return View();
        }
        //项目部门审批
        public ActionResult Add_Item()
        {
            return View();
        }

        /// <summary>
        /// 资源部门显示
        /// </summary>
        /// <returns></returns>
        public ActionResult Index_Resource()
        {
            return View();
        }
        //项目资源部门审批
        public ActionResult Add_Resource()
        {
            return View();
        }

        /// <summary>
        /// 
        /// 财务部门显示
        /// </summary>
        /// <returns></returns>
        public ActionResult Index_Financial()
        {
            return View();
        }
        //财务部门审批
        public ActionResult Add_Financial()
        {
            return View();
        }

        /// <summary>
        /// 
        /// 总经理显示
        /// </summary>
        /// <returns></returns>
        public ActionResult Index_Office()
        {
            return View();
        }
        //总经理审批
        public ActionResult Add_Office()
        {
            return View();
        }
    }
}