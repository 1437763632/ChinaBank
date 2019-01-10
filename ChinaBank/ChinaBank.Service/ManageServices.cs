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
    public class ManageServices : IManageServices
    {
        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="manage"></param>
        /// <returns></returns>
        public int AddManage(Manage manage)
        {
            using (System.Data.IDbConnection conn = DapperHelper.GetConnString())
            {
                string sql2 = string.Format("select * from manage where ManageName=:ManageName");
                var Roles = conn.Query<Manage>(sql2, manage);
                //定义角色存在
                int resault = -1;
                //当角色为空
                if (Roles.Count() == 0)
                {
                    //添加用户         
                    string sql = string.Format("insert into Manage(ManageName,ManagePwd) values (:ManageName,:ManagePwd)");
                    conn.Execute(sql, manage);

                    //获取到用户id
                    string sql3 = string.Format("select Id from manage where ManageName='{0}'", manage.ManageName);
                    var ro = conn.Query<Manage>(sql3, null).FirstOrDefault();

                    var roles = manage.RoleID.Split(',');//权限ID分隔字符串

                    for (int j = 0; j < roles.Length; j++)//循环添加进入关系表
                    {
                        ManageAndRole role_Right = new ManageAndRole();//实例化关系表
                        role_Right.ManageId = ro.Id;   //用户id
                        role_Right.RoleId = Convert.ToInt32(roles[j]);//角色id
                        string sql1 = string.Format("insert into ManageAndRole (RoleId,ManageId) values (:RoleId,:ManageId)");//关系表添加语句
                        resault = conn.Execute(sql1, role_Right);
                    }
                }

                return resault;
            }
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
            using (System.Data.IDbConnection conn = DapperHelper.GetConnString())
            {

                string sql = string.Format(@"select p.Id,p.managename,p.managepwd ,listagg(r.rolename,',')  within GROUP (order by r.rolename) rolename
 from manageandrole pr,role r,manage p
 where pr.manageid=p.id 
 and 
 pr.roleid =r.id 
 group by p.Id,p.managename,p.managepwd  ");
                var i = conn.Query<Manage>(sql, null).ToList();
                return i;
            }
        }   
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
            using (System.Data.IDbConnection conn = DapperHelper.GetConnString())
            {
                string sql = string.Format(@"  select manage.Id,manage.managename,manage.managepwd,manageandrole.roleid
 from manage ,manageandrole where manage.Id = manageandrole.manageid and manage.Id =:Id");
                var i = conn.Query<Manage>(sql, new { Id = Id }).ToList();
                return i;
            }
        }
        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="manage"></param>
        /// <returns></returns>
        public int UpdateManage(Manage manage)
        {
            using (OracleConnection conn = DapperHelper.GetConnString())
            {
                string executeSql = string.Format(@" Update manage set ManageName=:ManageName,managepwd=:managepwd where Id=:Id");
                int result = conn.Execute(executeSql, manage);
                if (result > 0)
                {
                    //string sql3 = string.Format("select Id from manage where managename='{0}'", manage.ManageName);
                    //var id = conn.Query<Role>(sql3, null).FirstOrDefault();

                    string executeSqls = string.Format("delete from manageandrole where manageid={0}",manage.Id);
                     conn.Execute(executeSqls, null);
                    var roles = manage.RoleID.Split(',');//权限ID分隔字符串
                    for (int i = 0; i < roles.Length; i++)
                    {
                        PermissionAndRole role_Right = new PermissionAndRole();//实例化关系表
                        role_Right.RoleId = manage.Id;   //用户id
                        role_Right.PermissionId = Convert.ToInt32(roles[i]);//角色id
                        string sql1 = string.Format("insert into PermissionAndRole (RoleId,PermissionId) values(:RoleId,:PermissionId)");//关系表添加语句
                        conn.Execute(sql1, role_Right);
                    }
                }
                return result;
            }
        }

        /// <summary>
        /// 绑定数据栏
        /// </summary>
        /// <param name="ManageNumber"></param>
        /// <param name="ManagePass"></param>
        /// <returns></returns>
        public IEnumerable<Permission> Getrights(int id)
        {
            using (System.Data.IDbConnection conn = DapperHelper.GetConnString())
            {
                string sql2 = @"SELECT * from permission  where Id in
(SELECT permissionid from permissionandrole where RoleID in
(SELECT RoleID from manageandrole where ManageID in 
(select Id from manage where Id=:Id)))";
                var result2 = conn.Query<Permission>(sql2, new { Id = id }).ToList();
                return result2;
            }

        }
    }
}
