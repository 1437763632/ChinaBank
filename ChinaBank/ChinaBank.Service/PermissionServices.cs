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
    using Common;
    using Oracle.DataAccess.Client;
    using Dapper;
    public class PermissionServices : IPermissionServices
    {
        /// <summary>
        /// 权限添加
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public int PermissionAdd(Permission permission)
        {
            using (OracleConnection conn = DapperHelper.GetConnString())
            {
                string executeSql = @" INSERT INTO Permission (PermissionName,Url) VALUES (:PermissionName,:Url) ";
                int result = conn.Execute(executeSql, permission);
                return result;
            }
        }
        /// <summary>
        /// 权限显示
        /// </summary>
        /// <returns></returns>

        public List<Permission> permissions()
        {
            using (OracleConnection conn = DapperHelper.GetConnString())
            {
                string executeSql = @"select * from permission ";
                var result = conn.Query<Permission>(executeSql,null).ToList();
                return result;
            }
        }

        /// <summary>
        /// 反填
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public List<Permission> permissionsID(int Id)
        {
            using (OracleConnection conn = DapperHelper.GetConnString())
            {
                string executeSql = @"select * from permission where Id=:id ";
                var result = conn.Query<Permission>(executeSql, new { id=Id}).ToList();
                return result;
            }
        }
        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>

        public int UpdatePermission(Permission permission)
        {
            using (OracleConnection conn = DapperHelper.GetConnString())
            {
                string sql = @"Update permission set PermissionName=:PermissionName,Url=：Url where Id=:Id";
                var result = conn.Execute(sql, permission);
                return result;
            }
        }
    }
}
