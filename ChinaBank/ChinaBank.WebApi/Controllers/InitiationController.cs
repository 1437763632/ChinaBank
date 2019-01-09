using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ChinaBank.Model;
namespace ChinaBank.WebApi.Controllers
{
    using ChinaBank.IService;
    using ChinaBank.Service;
    using ChinaBank.Model;
   
    public class InitiationController : ApiController
    {
        IInitiationService initiationService = null;
        /// <summary>
        /// 构造函数注入点
        /// </summary>
        /// <param name="powerservice"></param>
        public InitiationController(IInitiationService iinitiationService)
        {
            initiationService = iinitiationService;
        }
        [HttpGet]
        [Route("GetInitiation")]
        public List<Initiation> GetInitiation()
        {
            return initiationService.GetInitiation();
        }
        [HttpPost]
        [Route("AddInitiation")]
        public int AddInitiation(Initiation initiation)
        {
            
            return initiationService.AddInitiation(initiation);
        }

        //public Page GetInitiationByPname(string Pname, int Page = 1)
        //{
        //    var result = initiationService.GetInitiationByPname();
        //    Page p = new Page();
        //    if (!string.IsNullOrWhiteSpace(Pname))
        //    {
        //        result = result.Where(r => r.Pname.Contains(Pname)).ToList();
        //    }
        //    p.Currentpage = Page;
        //    p.Totalpage = (result.Count / PageCount) + (result.Count % PageCount == 0 ? 0 : 1);
        //    p.Data = result.Skip((Page - 1) * PageCount).Take(PageCount);
        //    return p;
        //}
        [HttpGet]
        [Route("GetInitiationByPname")]
        public Page GetInitiationByPname(string currentpage, string Pname)
        {
            var userlist = this.initiationService.GetInitiationByPname();
            if (currentpage == null)
            {
                currentpage = "1";
            }
            if (!String.IsNullOrEmpty(Pname))    
            {
                
                userlist = userlist.Where(r=>r.Pname.Contains(Pname)).ToList();
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
        //public int AddInitiation(Initiation initiation)
        //{
        //    return initiationService.AddInitiation(initiation);
        //}
        [HttpGet]
        [Route("GetInitiationById")]
        public List<Initiation> GetInitiationById(int Id)
        {
            return initiationService.GetInitiationById(Id);
        }
    }
}
