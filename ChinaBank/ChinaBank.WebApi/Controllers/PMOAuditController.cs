using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ChinaBank.WebApi.Controllers
{
    using ChinaBank.IService;
    using ChinaBank.Service;
    using ChinaBank.Model;
    public class PMOAuditController : ApiController
    {
        IPMOAuditService pmoAuditService = null;
        /// <summary>
        /// 构造函数注入点
        /// </summary>
        /// <param name="powerservice"></param>
        public PMOAuditController(IPMOAuditService ipmoAuditService)
        {
            pmoAuditService = ipmoAuditService;
        }
        [HttpGet]
        [Route("GetHangupPMO")]
        public Page GetHangupPMO(string currentpage, string Pname)
        {
            var userlist = this.pmoAuditService.GetHangupPMO();
            if (currentpage == null)
            {
                currentpage = "1";
            }
            if (!String.IsNullOrEmpty(Pname))
            {

                userlist = userlist.Where(r => r.Pname.Contains(Pname)).ToList();
            }


            //一页显示3条
            int totlepage = userlist.Count / 3 + (userlist.Count % 3 == 0 ? 0 : 1);
            userlist = userlist.Skip((int.Parse(currentpage) - 1) * 3).Take(3).ToList();


            Page pagebox = new Page();
            pagebox.CurrentPage = int.Parse(currentpage);
            pagebox.TotlePage = totlepage;
            pagebox.PageData = userlist;
            return pagebox;
        }
        [HttpPost]
        [Route("UpdateHangupPMO")]
        public int UpdateHangupPMO(Hangup hangup)
        {
            return pmoAuditService.UpdateHangupPMO(hangup);
        }
        [HttpGet]
        [Route("GetHangupDepartment")]
        public Page GetHangupDepartment(string currentpage, string Pname)
        {
            var userlist = this.pmoAuditService.GetHangupDepartment();
            if (currentpage == null)
            {
                currentpage = "1";
            }
            if (!String.IsNullOrEmpty(Pname))
            {

                userlist = userlist.Where(r => r.Pname.Contains(Pname)).ToList();
            }


            //一页显示3条
            int totlepage = userlist.Count / 3 + (userlist.Count % 3 == 0 ? 0 : 1);
            userlist = userlist.Skip((int.Parse(currentpage) - 1) * 3).Take(3).ToList();


            Page pagebox = new Page();
            pagebox.CurrentPage = int.Parse(currentpage);
            pagebox.TotlePage = totlepage;
            pagebox.PageData = userlist;
            return pagebox;
        }
        [HttpPost]
        [Route("UpdateHangupDepartment")]
        public int UpdateHangupDepartment(Hangup hangup)
        {
            return pmoAuditService.UpdateHangupDepartment(hangup);
        }
        //[HttpGet]
        //[Route("UpdateHangupDepartment")]
        //public int UpdateHangupDepartment(int Id, int Schedule, string Departmentopinion, string Processingstep, string Handler)
        //{
        //    return pmoAuditService.UpdateHangupDepartment(Id, Schedule, Departmentopinion, Processingstep, Handler);
        //}
        /// <summary>
        /// 工程管理部
        /// </summary>
        /// <param name="currentpage"></param>
        /// <param name="Pname"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("GetHangupProject")]
        public Page GetHangupProject(string currentpage, string Pname)
        {
            var userlist = this.pmoAuditService.GetHangupProject();
            if (currentpage == null)
            {
                currentpage = "1";
            }
            if (!String.IsNullOrEmpty(Pname))
            {

                userlist = userlist.Where(r => r.Pname.Contains(Pname)).ToList();
            }


            //一页显示3条
            int totlepage = userlist.Count / 3 + (userlist.Count % 3 == 0 ? 0 : 1);
            userlist = userlist.Skip((int.Parse(currentpage) - 1) * 3).Take(3).ToList();


            Page pagebox = new Page();
            pagebox.CurrentPage = int.Parse(currentpage);
            pagebox.TotlePage = totlepage;
            pagebox.PageData = userlist;
            return pagebox;
        }
        [HttpPost]
        [Route("UpdateHangupProject")]
        public int UpdateHangupProject(Hangup hangup)
        {
            return pmoAuditService.UpdateHangupProject(hangup);
        }
        /// <summary>
        /// 项目管理部
        /// </summary>
        /// <param name="currentpage"></param>
        /// <param name="Pname"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("GetHangupItem")]
        public Page GetHangupItem(string currentpage, string Pname)
        {
            var userlist = this.pmoAuditService.GetHangupItem();
            if (currentpage == null)
            {
                currentpage = "1";
            }
            if (!String.IsNullOrEmpty(Pname))
            {

                userlist = userlist.Where(r => r.Pname.Contains(Pname)).ToList();
            }


            //一页显示3条
            int totlepage = userlist.Count / 3 + (userlist.Count % 3 == 0 ? 0 : 1);
            userlist = userlist.Skip((int.Parse(currentpage) - 1) * 3).Take(3).ToList();


            Page pagebox = new Page();
            pagebox.CurrentPage = int.Parse(currentpage);
            pagebox.TotlePage = totlepage;
            pagebox.PageData = userlist;
            return pagebox;
        }
        [HttpPost]
        [Route("UpdateHangupItem")]
        public int UpdateHangupItem(Hangup hangup)
        {
            return pmoAuditService.UpdateHangupItem(hangup);
        }
        /// <summary>
        /// 总经理
        /// </summary>
        /// <param name="currentpage"></param>
        /// <param name="Pname"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("GetHangupGm")]
        public Page GetHangupGm(string currentpage, string Pname)
        {
            var userlist = this.pmoAuditService.GetHangupGm();
            if (currentpage == null)
            {
                currentpage = "1";
            }
            if (!String.IsNullOrEmpty(Pname))
            {

                userlist = userlist.Where(r => r.Pname.Contains(Pname)).ToList();
            }


            //一页显示3条
            int totlepage = userlist.Count / 3 + (userlist.Count % 3 == 0 ? 0 : 1);
            userlist = userlist.Skip((int.Parse(currentpage) - 1) * 3).Take(3).ToList();


            Page pagebox = new Page();
            pagebox.CurrentPage = int.Parse(currentpage);
            pagebox.TotlePage = totlepage;
            pagebox.PageData = userlist;
            return pagebox;
        }
        [HttpPost]
        [Route("UpdateHangupGm")]
        public int UpdateHangupGm(Hangup hangup)
        {
            return pmoAuditService.UpdateHangupGm(hangup);
        }
        /// <summary>
        /// 驳回
        /// </summary>
        /// <param name="hangup"></param>
        /// <returns></returns>
        /// 
        [HttpPost]
        [Route("UpdateState")]
        public int UpdateState(Hangup hangup)
        {
            return pmoAuditService.UpdateState(hangup);
        }
    }
}
