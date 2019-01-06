using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChinaBank.IService
{
    using ChinaBank.Model;
    /// <summary>
    /// 项目干系人变更接口
    /// </summary>
    public interface IStackeholderServices
    {
         int Add(Stackeholder stack);
     

         List<Stackeholder> GetStackeholder()
     
    }
}
