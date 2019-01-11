using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ChinaBank.WebApi.Controllers
{
    using ChinaBank.Model;
    using Newtonsoft.Json;
    using Unity.Attributes;
    using ChinaBank.IService;
    [RoutePrefix("projproblem")]
    public class ProjproblemController : ApiController
    {
        [Dependency]
        public IProjproblemServices Projproblem { get; set; }
        /// <summary>
        /// 添加项目问题
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        [Route("Add")]
        [HttpPost]
        public int Add(Model.Projproblem p)
        {
            var result = this.Projproblem.Add(p);
            return result;
        }
        /// <summary>
        /// 查询项目问题
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        [Route("GetProjproblems")]
        [HttpGet]
        public PageBox GetProjproblems(string currentpage, string name)
        {
            var userlist = this.Projproblem.GetProjproblems();
            if (currentpage == null)
            {
                currentpage = "1";
            }
            if (!String.IsNullOrEmpty(name))    
            {
                
                userlist = userlist.Where(r=>r.Probname.Contains(name)).ToList();
            }

            //一页显示3条
            int totlepage = userlist.Count / 3 + (userlist.Count % 3 == 0 ? 0 : 1);
            userlist = userlist.Skip((int.Parse(currentpage) - 1) * 3).Take(3).ToList();

            PageBox pagebox = new PageBox();
            pagebox.CurrentPage = int.Parse(currentpage);
            pagebox.TotlePage = totlepage;
            pagebox.PageData = userlist;

            return pagebox;
        }
    }
}
