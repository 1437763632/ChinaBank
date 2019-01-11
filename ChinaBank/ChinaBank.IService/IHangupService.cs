using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 挂起接口
/// </summary>
namespace ChinaBank.IService
{
    using ChinaBank.Model;
    public interface  IHangupService
    {
        List<Hangup> GetHangup();
        int AddHangup(Hangup h);
        List<Hangup> GetHangupById(int Id);
    }
}
