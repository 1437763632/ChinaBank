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
    public class Managemessage:IManagessageServices
    {
        /// <summary>
        /// 添加项目经理信息
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        public int Add(Model.Managemessage message)
        {
            using (OracleConnection conn = DapperHelper.GetConnString())
            {   
                string executeSql = @" INSERT INTO Managemessage (projectmanager,qualification,identify,appointment,projectplan,situation,appointmentdate) VALUES (:projectmanager,:qualification,:identify,:appointment,:projectplan,:situation,:appointmentdate)";
                return conn.Execute(executeSql, message);
            }
        }

        /// <summary>
        /// 查询项目经理信息
        /// </summary>
        /// <returns></returns>
        public List<Model.Managemessage> GetManagemessage()
        {
            using (OracleConnection conn = DapperHelper.GetConnString())
            {
                string captureByIdSql = @" select * from Managemessage";
                var result = conn.Query<Model.Managemessage>(captureByIdSql, null);
                return result.ToList();
            }
        }

        /// <summary>
        /// 删除项目经理信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int Delete(int id)
        {
            using (OracleConnection conn = DapperHelper.GetConnString())
            {
                string executeSql = @"delete from Managemessage where Id=" + id;
                return conn.Execute(executeSql, id);
            }
        }
        /// <summary>
        /// 根据ID查询
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public List<Model.Managemessage> GetManagemessageId(int Id)
        {
            using (OracleConnection conn = DapperHelper.GetConnString())
            {
                string sql = @"select * from Managemessage where Id=:Id";
                var Collectlist = new { Id = Id };
                var result = conn.Query<Model.Managemessage>(sql, Collectlist);
                return result.ToList();
            }
        }

        /// <summary>
        /// 修改项目经理信息
        /// </summary>
        /// <returns></returns>
        public int Update(Model.Managemessage managemessage)
        {
            using (OracleConnection conn = DapperHelper.GetConnString())
            {
                string executeSql = @"update Managemessage set Projectmanager=:Projectmanager,Qualification=:Qualification,Identify=:Identify,Appointment=:Appointment,Projectplan=:Projectplan,Situation=:Situation,Appointmentdate=:Appointmentdate where Id=:Id";
                int result = conn.Execute(executeSql, managemessage);
                return result;
            }
        }
    }
}
