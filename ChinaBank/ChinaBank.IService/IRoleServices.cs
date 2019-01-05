using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 角色接口
/// </summary>
namespace ChinaBank.IService
{
    using Model;
    public interface IRoleServices
    {
        /// <summary>
        /// 添加角色
        /// </summary>
        /// <param name="role"></param>
        /// <returns></returns>
        int RoleAdd(Role role);
        /// <summary>
        /// 角色显示
        /// </summary>
        /// <returns></returns>
        IEnumerable<ShowRole> showRoles();
        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="role"></param>
        /// <returns></returns>
        int RoleUpdate(Role role);
        /// <summary>
        /// 反填
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        IEnumerable<ShowRole> showRolesID(int id);

    }
}
