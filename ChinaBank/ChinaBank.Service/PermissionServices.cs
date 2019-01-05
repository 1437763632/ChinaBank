using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// 权限
/// </summary>
namespace ChinaBank.Service
{
    using Model;
    using IService;
    public class PermissionServices : IPermissionServices
    {
        /// <summary>
        /// 权限添加
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public int PermissionAdd(Permission p)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// 权限显示
        /// </summary>
        /// <returns></returns>

        public List<Permission> permissions()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 反填
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public List<Permission> permissionsID(int Id)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>

        public int UpdatePermission(Permission p)
        {
            throw new NotImplementedException();
        }
    }
}
