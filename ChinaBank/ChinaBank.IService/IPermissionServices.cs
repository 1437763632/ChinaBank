using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
///权限管理 
/// </summary>

namespace ChinaBank.IService
{
    using Model;
    public interface IPermissionServices
    {
        /// <summary>
        /// 权限显示
        /// </summary>
        /// <returns></returns>
        List<Permission> permissions();
        /// <summary>
        /// 权限添加
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        int PermissionAdd(Permission p);
        /// <summary>
        /// 反填
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        List<Permission> permissionsID(int Id);
        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        int UpdatePermission(Permission p);
    }
}
