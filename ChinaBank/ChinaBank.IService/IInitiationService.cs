using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 项目立项接口
/// </summary>
namespace ChinaBank.IService
{
    using ChinaBank.Model;
    public interface  IInitiationService
    {
        List<Initiation> GetInitiation();
        List<Initiation> GetInitiationByPname();
        int AddInitiation(Initiation initiation);
        List<Initiation> GetInitiationById(int Id);
        /// <summary>
        /// 审批流程调用
        /// </summary>
        /// <param name="initiation"></param>
        /// <returns></returns>
        int InitiationApprovals(Initiation initiation);
        /// <summary>
        /// 驳回调用方法
        /// </summary>
        /// <param name="initiation"></param>
        /// <returns></returns>
        int ReInitiationApprovals(Initiation initiation);
    }
}
