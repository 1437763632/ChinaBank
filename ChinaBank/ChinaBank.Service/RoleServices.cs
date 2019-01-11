using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChinaBank.Service
{
    using Model;
    using IService;
    using Common;
    using Oracle.DataAccess.Client;
    using Dapper;
    public class RoleServices : IRoleServices
    {
        /// <summary>
        /// 角色添加
        /// </summary>
        /// <param name="role"></param>
        /// <returns></returns>

        public int RoleAdd(Role role)
        {
            using (System.Data.IDbConnection conn = DapperHelper.GetConnString())
            {
                ////获取到角色id
                //string sql3 = string.Format("select Id from Role where RoleName='{0}'",role.RoleName);
                ////var ss = conn.Query<int>(sql3, null);
                //var ro = conn.Query<Role>(sql3, null).FirstOrDefault();
                //var ro1 = conn.Query<Role>(sql3, new { RoleName = role.RoleName });
                //var roll1 = conn.Query<Dictionary<string, string>>(sql3, role);
                //var rol = conn.Query(sql3, new { RoleName = role.RoleName });
                //var rol1 = conn.Query(sql3, role);

                string sql2 = string.Format("select * from Role where RoleName=:RoleName");
                var Roles = conn.Query<Role>(sql2, role);
                //定义角色存在
                int resault = -1;
                //当角色为空
                if (Roles.Count() == 0)
                {
                    //添加角色                  
                    string sql = string.Format("insert into role(rolename) values (:RoleName)");
                    conn.Execute(sql, role);

                    //获取到角色id
                    string sql3 = string.Format("select Id from Role where RoleName='{0}'", role.RoleName);
                    //var ss = conn.Query<int>(sql3, null);
                    var ro = conn.Query<Role>(sql3, null).FirstOrDefault();

                    var roles = role.RightID.Split(',');//权限ID分隔字符串

                    for (int j = 0; j < roles.Length; j++)//循环添加进入关系表
                    {
                        PermissionAndRole role_Right = new PermissionAndRole();//实例化关系表
                        role_Right.RoleId =ro.Id;   //角色id
                        role_Right.PermissionId = Convert.ToInt32(roles[j]);//权限id
                        string sql1 = string.Format("insert into PermissionAndRole (RoleId,PermissionId) values (:RoleId,:PermissionId)");//关系表添加语句
                        resault = conn.Execute(sql1, role_Right);
                    }
                }

                return resault;
            }
        }
        /// <summary>
        /// 角色修改
        /// </summary>~
        /// <param name="role"></param>
        /// <returns></returns>
        public int RoleUpdate(Role role)
        {
            using (OracleConnection conn = DapperHelper.GetConnString())
            {
                string executeSql = string.Format(@" Update Role set RoleName=:RoleName where Id=:Id");
                int result = conn.Execute(executeSql, role);
                if (result > 0)
                {
                    string sql3 = string.Format("select Id from Role where RoleName='{0}'", role.RoleName);
                    var id = conn.Query<Role>(sql3, null).FirstOrDefault();

                    string executeSqls = @"delete from PermissionAndRole where RoleId=:Id";
                    int results = conn.Execute(executeSqls, new { Id = role.Id });
                    var roles = role.RightID.Split(',');//权限ID分隔字符串
                    for (int i = 0; i < roles.Length; i++)
                    {
                        PermissionAndRole role_Right = new PermissionAndRole();//实例化关系表
                        role_Right.RoleId = id.Id;   //角色id
                        role_Right.PermissionId = Convert.ToInt32(roles[i]);//权限id
                        string sql1 = string.Format("insert into PermissionAndRole (RoleId,PermissionId) values(:RoleId,:PermissionId)");//关系表添加语句
                        conn.Execute(sql1, role_Right);
                    }
                }
                return result;
            }
        }
        /// <summary>
        /// 角色显示
        /// </summary>
        /// <returns></returns>
        public IEnumerable<ShowRole> showRoles()
        {
            using (System.Data.IDbConnection conn = DapperHelper.GetConnString())
            {

                string sql = string.Format(@" select role.Id,role.RoleName ,listagg(permission.permissionname,',')  within GROUP (order by permission.permissionname) permissionname
 from PermissionAndRole,role,permission
 where PermissionAndRole.roleid=role.id 
 and 
 PermissionAndRole.permissionid =permission.id 
 group by role.Id,role.RoleName  ");
                var i = conn.Query<ShowRole>(sql, null).ToList();
                return i;
            }
        }
        /// <summary>
        /// 反填
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public IEnumerable<ShowRole> showRolesID(int id)
        {
            using (System.Data.IDbConnection conn = DapperHelper.GetConnString())
            {
                string sql = string.Format(@" select role.Id,role.RoleName,PermissionAndRole.permissionid
 from role ,PermissionAndRole where role.Id = PermissionAndRole.RoleID and role.Id = :Id");
                var i = conn.Query<ShowRole>(sql, new { Id = id }).ToList();
                return i;
            }
        }
    }
}
