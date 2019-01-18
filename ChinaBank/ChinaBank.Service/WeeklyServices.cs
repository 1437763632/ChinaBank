using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChinaBank.Service
{
    using Model;
    using ChinaBank.Common;
    using Dapper;
    using IService;
    using Oracle.DataAccess.Client;
    public class WeeklyServices:IWeeklyServices
    {
        /// <summary>
        /// 添加项目周报
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public int Add(Model.Weekly p)
        {
            using (OracleConnection conn = DapperHelper.GetConnString())
            {
                string executeSql = @" INSERT INTO Weekly (formfirst,projectname,affiliated,projmanager,single,creadate,weektime,batchone,currentgeneration,batchtong,projectstatus,weekproj,nextweekproj,remark,notifyobj) VALUES (:formfirst,:projectname,:affiliated,:projmanager,:single,:creadate,:weektime,:batchone,:currentgeneration,:batchtong,:projectstatus,:weekproj,:nextweekproj,:remark,:notifyobj)";
                return conn.Execute(executeSql, p);
            }
        }

        /// <summary>
        /// 删除项目周报
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int Delete(int id)
        {
            using (OracleConnection conn = DapperHelper.GetConnString())
            {
                string executeSql = @"delete from Weekly where Id="+id;
                return conn.Execute(executeSql,id);
            }
        }

        /// <summary>
        /// 显示项目周报
        /// </summary>
        /// <returns></returns>
        public List<Model.Weekly> GetWeekly()
        {
            using (OracleConnection conn = DapperHelper.GetConnString())
            {
                string captureByIdSql = @" select * from Weekly";
                var result = conn.Query<Model.Weekly>(captureByIdSql, null);
                return result.ToList();
            }
        }

        /// <summary>
        /// 查询项目周报
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public List<Model.Weekly> GetWeeklybyid(int Id)
        {
            using (OracleConnection conn = DapperHelper.GetConnString())
            {
                string sql = @"select * from Weekly where Id=:Id";
                var Collectlist = new { Id = Id };
                var result = conn.Query<Weekly>(sql, Collectlist);
                return result.ToList();
            }
        }
    }
}
