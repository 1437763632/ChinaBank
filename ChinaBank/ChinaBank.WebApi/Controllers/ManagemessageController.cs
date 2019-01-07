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
        [HttpPost]
        public List<Model.Managemessage> GetManagemessage()
        {
            var result = this.Managemessage.GetManagemessage();
            return result;
        }
    }
}
