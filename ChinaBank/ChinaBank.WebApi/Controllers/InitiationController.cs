using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ChinaBank.Model;
namespace ChinaBank.WebApi.Controllers
{
    using ChinaBank.IService;
    using ChinaBank.Service;
    public class InitiationController : ApiController
    {
        IInitiationService initiationService = null;
        /// <summary>
        /// 构造函数注入点
        /// </summary>
        /// <param name="powerservice"></param>
        public InitiationController(IInitiationService iinitiationService)
        {
            initiationService = iinitiationService;
        }
        [HttpGet]
        [Route("GetInitiation")]
        public List<Initiation> GetInitiation()
        {
            return initiationService.GetInitiation();
        }
        [HttpGet]
        [Route("GetInitiationType")]
        public List<InitiationType> GetInitiationType()
        {
            return initiationService.GetInitiationType();
        }
        [HttpPost]
        [Route("AddInitiation")]
        public int AddInitiation(Initiation initiation)
        {
            return initiationService.AddInitiation(initiation);
        }
    }
}
