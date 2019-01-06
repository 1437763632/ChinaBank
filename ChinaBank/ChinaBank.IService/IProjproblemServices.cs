using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChinaBank.IService
{
    using ChinaBank.Model;
    /// <summary>
    /// 项目问题表接口
    /// </summary>
    public interface IProjproblemServices
    {
        List<Projproblem> GetProjproblems();
        int Add(Projproblem p);
    }
}
