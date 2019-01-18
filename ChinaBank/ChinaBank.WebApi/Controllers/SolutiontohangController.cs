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
    public class SolutiontohangController : ApiController
    {
        ISolutiontohangService solutiontohangService = null;
        /// <summary>
        /// 构造函数注入点
        /// </summary>
        /// <param name="powerservice"></param>*-
        public SolutiontohangController(ISolutiontohangService isolutiontohangService)
        {
            solutiontohangService = isolutiontohangService;
        }
        [HttpPost]
        [Route("AddSolutiontohang")]
        public int AddSolutiontohang(Solutiontohang s)
        {
            return solutiontohangService.AddSolutiontohang(s);
        }

        [HttpGet]
        [Route("GetSolutiontohang")]
        public Page GetSolutiontohang(string currentpage, string Pname)
        {
            var userlist = this.solutiontohangService.GetSolutiontohang();
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
        [HttpGet]
        [Route("GetSolutiontohangId")]
        public List<Solutiontohang> GetSolutiontohangById(int Id)
        {
            return solutiontohangService.GetSolutiontohangById(Id);
        }
        [HttpGet]
        [Route("GetNode")]
        public List<Nodes> GetNode()
        {
            return solutiontohangService.GetNode();
        }
        [HttpGet]
        [Route("GetManage")]
        public List<Manage> GetManage(int DepartmentId)
        {
            return solutiontohangService.GetManage(DepartmentId);
        }
    }
}
