using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ChinaBank.WebApi.Controllers
{

    using ChinaBank.IService;
    using ChinaBank.Service;
    using ChinaBank.Model;
    [RoutePrefix("pdsp")]
    public class PdspController : ApiController
    {
        /// <summary>
        /// 属性注入
        /// </summary>
       [Unity.Attributes.Dependency]
       public  IPDSPService pDSPService { get; set;}

        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="pdsp"></param>
        /// <returns></returns>
        [Route("Addpdsp")]
        [HttpPost]
        public int Addpdsp(PDSP pdsp)
        {
            //pdsp.Createtime = DateTime.Now;
            var i = pDSPService.Addpdsp(pdsp);
            
            return i;
        }

        /// <summary>
        /// 显示
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("GetPDSPs")]
        public Page GetPDSPs(string currentpage, string Pname)
        {
            var userlist = this.pDSPService.GetPDSPs();
            if (currentpage == null)
            {
                currentpage = "1";
            }
            if (!String.IsNullOrEmpty(Pname))
            {

                userlist = userlist.Where(r => r.Pname.Contains(Pname)).ToList();
            }
            //一页显示3条
            int totlepage = userlist.Count / 3 + (userlist.Count % 3 == 0 ? 0 : 1);
            userlist = userlist.Skip((int.Parse(currentpage) - 1) * 3).Take(3).ToList();
            Page pagebox = new Page();
            pagebox.CurrentPage = int.Parse(currentpage);
            pagebox.TotlePage = totlepage;
            pagebox.PageData = userlist;
            return pagebox;
        }

        [Route("projmessages")]
        [HttpGet]
        /// <summary>
        /// 项目信息表显示
        /// </summary>
        /// <returns></returns>
        public Page projmessages(string currentpage, string Pname)
        {
            var userlist = this.pDSPService.projmessages();
            if (currentpage == null)
            {
                currentpage = "1";
            }
            if (!String.IsNullOrEmpty(Pname))
            {
                userlist = userlist.Where(r => r.Projname.Contains(Pname)).ToList();
            }
            //一页显示3条
            int totlepage = userlist.Count / 3 + (userlist.Count % 3 == 0 ? 0 : 1);
            userlist = userlist.Skip((int.Parse(currentpage) - 1) * 3).Take(3).ToList();
            Page pagebox = new Page();
            pagebox.CurrentPage = int.Parse(currentpage);
            pagebox.TotlePage = totlepage;
            pagebox.PageData = userlist;


            return pagebox;
        }
        
        /// <summary>
        /// 反填
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        [Route("GetPs")]
        [HttpGet]
        public List<PDSP> GetPs(int Id)
        {
            var i = pDSPService.GetPs(Id);
            return i;
        }

        /// <summary>
        /// PMO审批
        /// </summary>
        /// <param name="currentpage"></param>
        /// <returns></returns>
        [Route("GetPdspPmo")]
        [HttpGet]
        public Page GetPdspPmo(string currentpage,int Projstateid)
        {
            var userlist = this.pDSPService.GetPDSPs();
            if (currentpage == null)
            {
                currentpage = "1";
            }
            userlist = userlist.Where(r => r.Projstateid.Equals(Projstateid)).ToList();
            //一页显示3条
            int totlepage = userlist.Count / 3 + (userlist.Count % 3 == 0 ? 0 : 1);
            userlist = userlist.Skip((int.Parse(currentpage) - 1) * 3).Take(3).ToList();
            Page pagebox = new Page();
            pagebox.CurrentPage = int.Parse(currentpage);
            pagebox.TotlePage = totlepage;
            pagebox.PageData = userlist;
            return pagebox;
        }

        /// <summary>
        /// 驳回修改
        /// </summary>
        /// <param name="pdsp"></param>
        /// <returns></returns>
        [Route("updatePdsp")]
        [HttpPost]
        public int updatePdsp(PDSP pdsp)
        {
            var i = pDSPService.updatePdsp(pdsp);
            return i;
        }
        /// <summary>
        /// PMO修改
        /// </summary>
        /// <param name="pdsp"></param>
        /// <returns></returns>

        [Route("PmoUpdatePdsp")]
        [HttpPost]
        public int PmoUpdatePdsp(PDSP pdsp)
        {
            var i = pDSPService.PmoUpdatePdsp(pdsp);
            return i;
        }
        /// <summary>
        /// 牵头部门修改
        /// </summary>
        /// <param name="pdsp"></param>
        /// <returns></returns> 
        [Route("ImpUpdatePdsp")]
        [HttpPost]
        public int ImpUpdatePdsp(PDSP pdsp)
        {
            var i = pDSPService.ImpUpdatePdsp(pdsp);
            return i;
        }

        /// <summary>
        /// 项目管理修改
        /// </summary>
        /// <param name="pdsp"></param>
        /// <returns></returns>
        [Route("ItemUpdatePdsp")]
        [HttpPost]
        public int ItemUpdatePdsp(PDSP pdsp)
        {
            var i = pDSPService.ItemUpdatePdsp(pdsp);
            return i;
        }

        /// <summary>
        /// 资源管理修改
        /// </summary>
        /// <param name="pdsp"></param>
        /// <returns></returns>
        [Route("ResourceUpdatePdsp")]
        [HttpPost]
        public int ResourceUpdatePdsp(PDSP pdsp)
        {
            var i = pDSPService.ResourceUpdatePdsp(pdsp);
            return i;
        }

        /// <summary>
        /// 财务管理修改
        /// </summary>
        /// <param name="pdsp"></param>
        /// <returns></returns>
        [Route("FinancialUpdatePdsp")]
        [HttpPost]
        public int FinancialUpdatePdsp(PDSP pdsp)
        {
            var i = pDSPService.FinancialUpdatePdsp(pdsp);
            return i;
        }

        /// <summary>
        /// 总经理管理修改
        /// </summary>
        /// <param name="pdsp"></param>
        /// <returns></returns>
        [Route("GeneralUpdatePdsp")]
        [HttpPost]
        public int GeneralUpdatePdsp(PDSP pdsp)
        {
            var i = pDSPService.GeneralUpdatePdsp(pdsp);
            return i;
        }
    }
}
