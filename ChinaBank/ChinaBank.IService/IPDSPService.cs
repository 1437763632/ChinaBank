using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChinaBank.IService
{
    using ChinaBank.Model;

    /// <summary>
    /// 项目结项接口
    /// </summary>
    public interface IPDSPService
    {
        /// <summary>
        /// 显示
        /// </summary>
        /// <returns></returns>
        List<PDSP> GetPDSPs();
        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="pdsp"></param>
        /// <returns></returns>
        int Addpdsp(PDSP pdsp);
        /// <summary>
        /// 反填
        /// </summary>
        List<PDSP> GetPs(int Id);
        /// <summary>
        /// 项目信息表显示
        /// </summary>
        /// <returns></returns>
        List<Projmessage> projmessages();
        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="pdsp"></param>
        /// <returns></returns>
        int updatePdsp(PDSP pdsp);
        /// <summary>
        /// PMO修改
        /// </summary>
        /// <param name="pdsp"></param>
        /// <returns></returns>
        int PmoUpdatePdsp(PDSP pdsp);
        /// <summary>
        /// 牵头部门修改
        /// </summary>
        /// <param name="pdsp"></param>
        /// <returns></returns>
        int ImpUpdatePdsp(PDSP pdsp);
        /// <summary>
        /// 项目管理修改
        /// </summary>
        /// <param name="pdsp"></param>
        /// <returns></returns>
        int ItemUpdatePdsp(PDSP pdsp);
        /// <summary>
        /// 资源管理修改
        /// </summary>
        /// <param name="pdsp"></param>
        /// <returns></returns>
        int ResourceUpdatePdsp(PDSP pdsp);
        /// <summary>
        /// 财务管理修改
        /// </summary>
        /// <param name="pdsp"></param>
        /// <returns></returns>
        int FinancialUpdatePdsp(PDSP pdsp);
        /// <summary>
        /// 总经理管理修改
        /// </summary>
        /// <param name="pdsp"></param>
        /// <returns></returns>
        int GeneralUpdatePdsp(PDSP pdsp);

    }
}
