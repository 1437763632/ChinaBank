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
    public class StackeholderServices:IStackeholderServices
    {
        public int Add(Model.Stackeholder p)
        {
            using (OracleConnection conn = DapperHelper.GetConnString())
            {
                string executeSql = @" INSERT INTO Stackeholder (functionname,projrole,name,role,department) VALUES (:functionname,:projrole,:name,:role,:department)";
                return conn.Execute(executeSql,p);
            }
        }

        public List<Model.Stackeholder> GetStackeholder()
        {
            using (OracleConnection conn = DapperHelper.GetConnString())
            {
                string captureByIdSql = @" select * from Stackeholder";
                var result = conn.Query<Model.Stackeholder>(captureByIdSql, null);
                return result.ToList();
            }
        }
    }
}
