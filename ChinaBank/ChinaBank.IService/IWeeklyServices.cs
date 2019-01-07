using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChinaBank.IService
{
    using ChinaBank.Model;

    /// <summary>
    /// 项目周报表
    /// </summary>
    public interface IWeeklyServices
    {
        int Add(Weekly week);

        List<Weekly> GetWeekly();
       
    }
}
