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
        /// 添加项目信息
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        [Route("GetProjmessage")]
        [HttpPost]
        public List<Model.Projmessage> GetProjmessage()
        {
            var result = this.Projmessage.GetProjmessage();
            return result;
        }
    }
}
