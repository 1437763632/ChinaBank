using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChinaBank.Service
{
   
    using ChinaBank.IService;
    using ChinaBank.Model;
    using ChinaBank.Common;
    using Oracle.DataAccess.Client;
    using Dapper;

    public class InitiationService : IInitiationService
    {
        public List<Initiation> GetInitiation()
        {
            using (OracleConnection conn = DapperHelper.GetConnString())
            {
                string sql = @"select * from Initiation";
                var result = conn.Query<Initiation>(sql, null);
                return result.ToList();

            }
        }
    }
}
