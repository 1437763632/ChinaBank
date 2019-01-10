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
    }
}
