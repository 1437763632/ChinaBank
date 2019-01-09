using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ChinaBank.WebApi.Controllers
{
    using Unity.Attributes;
    using ChinaBank.IService;
    using ChinaBank.Model;

    [RoutePrefix("Stackeholder")]
    public class StackeholderController : ApiController
    {
        [Dependency]
        public IStackeholderServices Stackeholder { get; set; }
        /// <summary>
        /// 添加干系人变更
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        [Route("Add")]
        [HttpPost]
        public int Add(Model.Stackeholder p)
        {
            var result = this.Stackeholder.Add(p);
            return result;
        }
        /// <summary>
        /// 查看干系人变更
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        [Route("GetStackeholder")]
        [HttpGet]
        public PageBox GetStackeholder(string currentpage, string name)
        {
            var userlist = this.Stackeholder.GetStackeholder();
            if (currentpage == null)
            {
                currentpage = "1";
            }
            if (!String.IsNullOrEmpty(name))
            {

                userlist = userlist.Where(r => r.Name.Contains(name)).ToList();
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
