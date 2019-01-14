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

    [RoutePrefix("Managemessage")]
    public class ManagemessageController : ApiController
    {
        [Dependency]
        public IManagessageServices Managemessage { get; set; }

        /// <summary>
        /// 添加项目经理信息
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        [Route("Add")]
        [HttpPost]
        public int Add(Model.Managemessage message)
        {
            var result = this.Managemessage.Add(message);
            return result;
        }
        /// <summary>
        /// 查看项目经理信息
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        [Route("GetManagemessage")]
        [HttpGet]
        public PageBox GetManagemessage(string currentpage,string name)
        {
            var userlist = this.Managemessage.GetManagemessage();
            if (currentpage == null)
            {
                currentpage = "1";
            }
            if (!String.IsNullOrEmpty(name))
            {

                userlist = userlist.Where(r => r.Projectmanager.Contains(name)).ToList();
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
        /// 删除项目经理信息
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        [Route("Delete")]
        [HttpGet]
        public int Delete(int id)
        {
            var result = this.Managemessage.Delete(id);
            return result;
        }
        /// <summary>
        /// 修改项目经理信息
        /// </summary>
        /// <returns></returns>
        [Route("Update")]
        [HttpPost]
        public int Update(Model.Managemessage managemessage)
        {
            var result = this.Managemessage.Update(managemessage);
            return result;
        }

        /// <summary>
        /// 根据ID查询
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        [Route("GetManagemessageId")]
        [HttpGet]
        public List<Managemessage> GetManagemessageId(int Id)
        {
            var result = this.Managemessage.GetManagemessageId(Id);
            return result;
        }
    }
}
