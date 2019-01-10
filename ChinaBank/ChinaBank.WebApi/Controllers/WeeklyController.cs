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

    [RoutePrefix("Weekly")]
    public class WeeklyController : ApiController
    {
        [Dependency]
        public IWeeklyServices Weekly { get; set; }
        /// <summary>
        /// 添加项目周报
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        [Route("Add")]
        [HttpPost]
        public int Add(Model.Weekly p)
        {
            var result = this.Weekly.Add(p);
            return result;
        }
        /// <summary>
        /// 删除项目周报
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        [Route("Delete")]
        [HttpGet]
        public int Delete(int id)
        {
            var result = this.Weekly.Delete(id);
            return result;
        }
        /// <summary>
        /// 详细
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("GetWeeklybyid")]
        public List<Model.Weekly> GetWeeklybyid(int Id)
        {
            var result = this.Weekly.GetWeeklybyid(Id);
            return result;
        }
        /// <summary>
        /// 查看项目周报
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        [Route("GetWeekly")]
        [HttpGet]
        public PageBox GetWeekly(string currentpage, string name)
        {
            var userlist = this.Weekly.GetWeekly();
            if (currentpage == null)
            {
                currentpage = "1";
            }
            if (!String.IsNullOrEmpty(name))
            {

                userlist = userlist.Where(r => r.Projectname.Contains(name)).ToList();
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
