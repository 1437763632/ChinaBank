using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChinaBank.IService
{
    using ChinaBank.Model;
    /// <summary>
    /// 解挂表接口
    /// </summary>
    public interface ISolutiontohangService
    {
        List<Solutiontohang> GetSolutiontohang();
        int AddSolutiontohang(Solutiontohang s);
        List<Solutiontohang> GetSolutiontohangById(int Id);
    }
}
