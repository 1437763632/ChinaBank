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

    [RoutePrefix("Projmessage")]
    public class ProjmessageController : ApiController
    {
        [Dependency]
        public IProjmessageServices Projmessage { get; set; }

        /// <summary>
        /// 添加项目信息
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        [Route("Add")]
        [HttpPost]
        public int Add(Model.Projmessage message)
        {
            var result = this.Projmessage.Add(message);
            return result;
        }
        /// <summary>
        /// 反填
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [Route("fan")]
        [HttpGet]
        public Projmessage projmessages (int id)
        {
            var user = this.Projmessage.GetProjmessage();
            var userlist = user.FirstOrDefault<Projmessage>(r => r.Id.Equals(id));
            return userlist;
        } 
        /// <summary>
        /// 项目信息
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        [Route("GetProjmessage")]
        [HttpGet]
        public PageBox GetProjmessage(string currentpage, string name)
        {
            var userlist = this.Projmessage.GetProjmessage();
            if (currentpage == null)
            {
                currentpage = "1";
            }
            if (!String.IsNullOrEmpty(name))
            {
                userlist = userlist.Where(r => r.Projname.Contains(name)).ToList();
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
        /// <summary>
        /// 删除项目信息
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        [Route("Delete")]
        [HttpGet]
        public int Delete(int id)
        {
            var result = this.Projmessage.Delete(id);
            return result;
        }
    }
}
