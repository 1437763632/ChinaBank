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
    public class PMOSolutionController : ApiController
    {
        IPMOSolutionServices pmosolution = null;
        /// <summary>
        /// 构造函数注入点
        /// </summary>
        /// <param name="powerservice"></param>
        public PMOSolutionController(IPMOSolutionServices ipmosolution)
        {
            pmosolution = ipmosolution;
        }
        [HttpGet]
        [Route("GetSolutionPMO")]
        public Page GetSolutionPMO(string currentpage, string Pname)
        {
            var userlist = this.pmosolution.GetSolutionpmo();
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
        [Route("UpdateSolutionPMO")]
        public int UpdateSolutionPMO(Solutiontohang solution)
        {
            return pmosolution.UpdateSolutionpmo(solution);
        }
        [HttpGet]
        [Route("GetSolutionDepartment")]
        public Page GetSolutionDepartment(string currentpage, string Pname)
        {
            var userlist = this.pmosolution.GetSolutiondepart();
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
        [Route("UpdateSolutionDepartment")]
        public int UpdateSolutionDepartment(Solutiontohang solution)
        {
            return pmosolution.UpdateSolutionpart(solution);
        }
        //[HttpGet]
        //[Route("UpdateHangupDepartment")]
        //public int UpdateHangupDepartment(int Id, int Schedule, string Departmentopinion, string Processingstep, string Handler)
        //{
        //    return pmosolution.UpdateHangupDepartment(Id, Schedule, Departmentopinion, Processingstep, Handler);
        //}
        /// <summary>
        /// 工程管理部
        /// </summary>
        /// <param name="currentpage"></param>
        /// <param name="Pname"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("GetSolutionProject")]
        public Page GetSolutionProject(string currentpage, string Pname)
        {
            var userlist = this.pmosolution.GetSolutionproject();
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
        [Route("UpdateSolutionProject")]
        public int UpdateSolutionProject(Solutiontohang solution)
        {
            return pmosolution.UpdateSolutionproc(solution);
        }
        /// <summary>
        /// 项目管理部
        /// </summary>
        /// <param name="currentpage"></param>
        /// <param name="Pname"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("GetSolutionItem")]
        public Page GetSolutionItem(string currentpage, string Pname)
        {
            var userlist = this.pmosolution.GetSolutionitem();
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
        [Route("UpdateSolutionItem")]
        public int UpdateSolutionItem(Solutiontohang solution)
        {
            return pmosolution.UpdateSolutionitem(solution);
        }
        /// <summary>
        /// 总经理
        /// </summary>
        /// <param name="currentpage"></param>
        /// <param name="Pname"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("GetSolutionGmo")]
        public Page GetSolutionGmo(string currentpage, string Pname)
        {
            var userlist = this.pmosolution.GetSolutiongmo();
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
        [Route("UpdateSolutionGmo")]
        public int UpdateSolutionGmo(Solutiontohang solution)
        {
            return pmosolution.UpdateSolutiongmo(solution);
        }
        /// <summary>
        /// 驳回
        /// </summary>
        /// <param name="hangup"></param>
        /// <returns></returns>
        /// 
        [HttpPost]
        [Route("UpdateState")]
        public int UpdateState(Solutiontohang solution)
        {
            return pmosolution.UpdateState(solution);
        }
    }
}
