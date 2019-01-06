using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChinaBank.Service
{
    using Model;
    using IService;
    public class ManageServices : IManageServices
    {
        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="manage"></param>
        /// <returns></returns>
        public int AddManage(Manage manage)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>

        public int DeleteManage(int Id)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 显示
        /// </summary>
        /// <returns></returns>
        public List<Manage> GetManagers()
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// 登录
        /// </summary>
        /// <param name="ManageName"></param>
        /// <param name="ManagePwd"></param>
        /// <returns></returns>
        public Manage Login(string ManageName, string ManagePwd)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// 反填
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public List<Manage> manages(int Id)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="manage"></param>
        /// <returns></returns>
        public int UpdateManage(Manage manage)
        {
            throw new NotImplementedException();
        }
    }
}
