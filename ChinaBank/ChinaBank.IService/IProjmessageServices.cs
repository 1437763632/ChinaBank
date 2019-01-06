using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChinaBank.IService
{
    using ChinaBank.Model;
    /// <summary>
    /// 项目信息表接口
    /// </summary>
    public interface IProjmessageServices
    {
         int Add(Projmessage message);



        List<Projmessage> GetProjmessage();
      }
}
