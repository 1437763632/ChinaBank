using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChinaBank.IService
{
    using ChinaBank.Model;
    public interface IPMOSolutionServices
    {
        /// <summary>
        /// PMO
        /// </summary>
        /// <returns></returns>
        List<Solutiontohang> GetSolutionpmo();
        /// <summary>
        /// 所属部门
        /// </summary>
        /// <returns></returns>
        List<Solutiontohang> GetSolutiondepart();
        /// <summary>
        /// 工程管理部
        /// </summary>
        /// <returns></returns>
        List<Solutiontohang> GetSolutionproject();
        /// <summary>
        /// 项目管理部
        /// </summary>
        /// <returns></returns>
        List<Solutiontohang> GetSolutionitem();
        /// <summary>
        /// 总经理
        /// </summary>
        /// <returns></returns>
        List<Solutiontohang> GetSolutiongmo();

        int UpdateSolutionpmo(Solutiontohang solution);

        int UpdateSolutionpart(Solutiontohang solution);

        int UpdateSolutionproc(Solutiontohang solution);

        int UpdateSolutionitem(Solutiontohang solution);

        int UpdateSolutiongmo(Solutiontohang solution);
        int UpdateStates(Solutiontohang solution);
    }
}
