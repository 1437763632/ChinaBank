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
    class WeeklyServices:IWeeklyServices
    {
        public int Add(Model.Weekly p)
        {
            using (OracleConnection conn = DapperHelper.GetConnString())
            {
                string executeSql = @" INSERT INTO Weekly ( formfirst, projectname, affiliated, projmanager, single, creadate, weektime, batchone, currentgeneration,batchtong,projectstatus,weekproj,nextweekproj,remark,notifyobj) VALUES (:formfirst,:projectname,:affiliated,:projmanager,:single, :creadate, :weektime, :batchone, ；currentgeneration,：batchtong,：projectstatus,：weekproj,：nextweekproj,：remark,：notifyobj)";
                return conn.Execute(executeSql, p);
            }
        }

        public List<Model.Weekly> GetWeekly()
        {
            using (OracleConnection conn = DapperHelper.GetConnString())
            {
                string captureByIdSql = @" select * from Weekly";
                var result = conn.Query<Model.Weekly>(captureByIdSql, null);
                return result.ToList();
            }
        }
    }
}
