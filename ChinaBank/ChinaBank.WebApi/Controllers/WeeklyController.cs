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
        /// 查看项目周报
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        [Route("GetWeekly")]
        [HttpPost]
        public List<Model.Weekly> GetWeekly()
        {
            var result = this.Weekly.GetWeekly();
            return result;
        }
    }
}
