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

    [RoutePrefix("rbac")]
    public class RBACController : ApiController
    {
        [Unity.Attributes.Dependency]
        public IPermissionServices permissionServices { get; set; }
        [Unity.Attributes.Dependency]

        public IRoleServices roleServices { get; set; }

        [Unity.Attributes.Dependency]
        public IManageServices manageServices { get; set; }
        #region 权限
        /// <summary>
        /// 权限添加
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        [Route("PermissionAdd")]
        [HttpPost]
        public int PermissionAdd(Permission permission)
        {
            var i = permissionServices.PermissionAdd(permission);
            return i;
        }
        /// <summary>
        /// 权限显示
        /// </summary>
        /// <returns></returns>
        [Route("permissions")]
        [HttpGet]
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
        [Route("permissionsID")]
        [HttpGet]
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
        [Route("UpdatePermission")]
        [HttpPost]

        public int UpdatePermission(Permission permission)
        {
            var i = permissionServices.UpdatePermission(permission);
            return i;
        }
        #endregion

        #region 角色
        /// <summary>
        /// 角色添加
        /// </summary>
        /// <param name="role"></param>
        /// <returns></returns>
        [Route("RoleAdd")]
        [HttpPost]

        public int RoleAdd(Role role)
        {
            //Role role = new Role();
            //role.RoleName = RoleName;
            //role.RightID = RightID;
            var i = roleServices.RoleAdd(role);
            return i;
        }
        /// <summary>
        /// 角色修改
        /// </summary>~
        /// <param name="role"></param>
        /// <returns></returns>
        [Route("RoleUpdate")]
        [HttpPost]
        public int RoleUpdate(Role role)
        {
            var i = roleServices.RoleUpdate(role);
            return i;
        }
        /// <summary>
        /// 角色显示
        /// </summary>
        /// <returns></returns>
        [Route("showRoles")]
        [HttpGet]
        public IEnumerable<ShowRole>showRoles()
        {
            var i = roleServices.showRoles();
            return i;
        }
        /// <summary>
        /// 反填
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [Route("showRolesID")]
        [HttpGet]
        public IEnumerable<ShowRole> showRolesID(int id)
        {
            var i = roleServices.showRolesID(id);
            return i;
        }

        #endregion

        #region 用户以及用户登录

        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="manage"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("AddManage")]
        public int AddManage(Manage manage)
        {
            var i = manageServices.AddManage(manage);
            return i;
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
        [HttpGet]
        [Route("GetManagers")]
        public List<Manage> GetManagers()
        {
            var i = manageServices.GetManagers();
            return i;
        }
        /// <summary>
        /// 登录
        /// </summary>
        /// <param name="ManageName"></param>
        /// <param name="ManagePwd"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("Login")]
        public Manage Login(string ManageName, string ManagePwd)
        {
            var i = manageServices.Login(ManageName, ManagePwd);
            return i;
        }
        /// <summary>
        /// 反填
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("manages")]
        public List<Manage> manages(int Id)
        {
            var i = manageServices.manages(Id);
            return i;
        }
        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="manage"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("UpdateManage")]
        public int UpdateManage(Manage manage)
        {

            var i = manageServices.UpdateManage(manage);
            return i;
            
        }
        #endregion
    }
}

