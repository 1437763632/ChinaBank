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
    public class HongupController : ApiController
    {
        IHangupService hangupService = null;
        /// <summary>
        /// 构造函数注入点
        /// </summary>
        /// <param name="powerservice"></param>
        public HongupController(IHangupService ihangupService)
        {
            hangupService = ihangupService;
        }
        
        [HttpGet]
        [Route("GetHangup")]
        public Page GetInitiationByPname(string currentpage, string Pname)
        {
            var userlist = this.hangupService.GetHangup();
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
        [Route("AddHangup")]
        public int AddHangup(Hangup h)
        {
            return hangupService.AddHangup(h);
        }
        [HttpGet]
        [Route("GetHangupById")]
        public List<Hangup> GetInitiationById(int Id)
        {
            return hangupService.GetHangupById(Id);
        }
        [HttpGet]
        [Route("GetNodeList")]
        public List<Nodes> GetNode()
        {
            return hangupService.GetNode();
        }
        [HttpGet]
        [Route("GetManageList")]
        public List<Manage> GetManage(int DepartmentId)
        {
            return hangupService.GetManage(DepartmentId);
        }
    }
}
