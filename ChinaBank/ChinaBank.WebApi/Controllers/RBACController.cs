using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ChinaBank.WebApi.Controllers
{
    using Model;
    using IService;
    using Service;
    using Oracle;
    public class RBACController : ApiController
    {
        IPermissionServices permissionServices;
        public RBACController (IPermissionServices _permissionServices)
        {
             permissionServices = _permissionServices;
        }
        #region 权限
        /// <summary>
        /// 权限添加
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public int PermissionAdd(Permission p)
        {
            var i = permissionServices.PermissionAdd(p);
            return i;
        }
        /// <summary>
        /// 权限显示
        /// </summary>
        /// <returns></returns>

        public List<Permission> permissions()
        {
            var i = permissionServices.permissions();
            return i;
        }

        /// <summary>
        /// 反填
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public List<Permission> permissionsID(int Id)
        {
            var i = permissionServices.permissionsID(Id);
            return i;
        }
        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>

        public int UpdatePermission(Permission Permission)
        {
            var i = permissionServices.UpdatePermission(Permission);
            return i;
        }
        #endregion

    }
}
