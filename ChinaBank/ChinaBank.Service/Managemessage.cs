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
    }
}
