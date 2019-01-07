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
        [HttpPost]
        public List<Model.Stackeholder> GetStackeholder()
        {
            var result = this.Stackeholder.GetStackeholder();
            return result;
        }
    }
}
