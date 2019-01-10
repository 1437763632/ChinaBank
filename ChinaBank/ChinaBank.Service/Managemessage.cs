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
        public int Add(Model.Managemessage message)
        {
            using (OracleConnection conn = DapperHelper.GetConnString())
            {   
                string executeSql = @" INSERT INTO Managemessage (itemnumber,projectmanager,qualification,identify,appointment,projectplan,situation,appointmentdate) VALUES (:itemnumber,:projectmanager,:qualification,:identify,:appointment,:projectplan,:situation,:appointmentdate)";
                return conn.Execute(executeSql, message);
            }
        }

        public List<Model.Managemessage> GetManagemessage()
        {
            using (OracleConnection conn = DapperHelper.GetConnString())
            {
                string captureByIdSql = @" select * from Managemessage";
                var result = conn.Query<Model.Managemessage>(captureByIdSql, null);
                return result.ToList();
            }
        }
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
