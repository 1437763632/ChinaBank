using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// 管理员接口
/// </summary>

namespace ChinaBank.IService
{
    using Model;
    public interface IManageServices
    {
        /// <summary>
        /// 后台用户显示
        /// </summary>
        /// <returns></returns>
        List<Manage> GetManagers();
        /// <summary>
        /// 后台用户登录
        /// </summary>
        /// <param name="ManagersName"></param>
        /// <param name="ManagersPsw"></param>
        /// <returns></returns>
        Manage Login(string ManageName, string ManagePwd);
        /// <summary>
        /// 用户添加
        /// </summary>
        /// <param name="manage"></param>
        /// <returns></returns>
        int AddManage(Manage manage);
        /// <summary>
        /// 用户删除
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        int DeleteManage(int Id);
        /// <summary>
        /// 反填
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        List<Manage> manages(int Id);
        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="manage"></param>
        /// <returns></returns>
        int UpdateManage(Manage manage);
    }
}
