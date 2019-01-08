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
        public List<Model.Projproblem> GetProjproblems()
        {
            var result = this.Projproblem.GetProjproblems();
            return result;
        }
        /// <summary>
        /// 根据ID查询
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [Route("Getproj")]
        [HttpGet]
        public List<Model.Projproblem> Getproj(int id)
        {
            var result = this.Projproblem.Getproj(id);
            return result;
        }
    }
}
