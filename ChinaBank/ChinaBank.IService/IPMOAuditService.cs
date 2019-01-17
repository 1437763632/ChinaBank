using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChinaBank.IService
{
    using ChinaBank.Model;
    public interface IPMOAuditService
    {
        /// <summary>
        /// PMO审核信息列表
        /// </summary>
        /// <returns></returns>
        List<Hangup> GetHangupPMO();
        //int UpdateHangupPMO(int Id, int Schedule, string Pmoopinion, string Processingstep, string Handler);
        int UpdateHangupPMO(Hangup hangup);
        /// <summary>
        /// 开发部主管审批
        /// </summary>
        /// <returns></returns>
        List<Hangup> GetHangupDepartment();
        //int UpdateHangupDepartment(int Id, int Schedule, string Departmentopinion, string Processingstep, string Handler);
        int UpdateHangupDepartment(Hangup hangup);
        /// <summary>
        /// 工程管理部审批
        /// </summary>
        /// <returns></returns>
        List<Hangup> GetHangupProject();
        int UpdateHangupProject(Hangup hangup);
        /// <summary>
        /// 项目管理部审批
        /// </summary>
        /// <returns></returns>
        List<Hangup> GetHangupItem();
        int UpdateHangupItem(Hangup hangup);
        /// <summary>
        /// 总经理审批
        /// </summary>
        /// <returns></returns>
        List<Hangup> GetHangupGm();
        int UpdateHangupGm(Hangup hangup);
        /// <summary>
        /// 驳回
        /// </summary>
        /// <param name="hangup"></param>
        /// <returns></returns>
        int UpdateState(Hangup hangup);


    }
}
