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
    public class HangupService : IHangupService
    {
        public int AddHangup(Hangup h)
        {
            using (OracleConnection conn = DapperHelper.GetConnString())
            {
                string executeSql = @" INSERT INTO Hangup(Code,Applicant,Pname,Pid,Createtime,Pm,Department,State,Hangupcause,Processingstep,Handler) VALUES (:Code,:Applicant,:Pname,:Pid,:Createtime,:Pm,:Department,:State,:Hangupcause,:Processingstep,:Handler) ";
                //initiation.Times = System.DateTime.Now;
                var Collectlist = new { Code=h.Code, Applicant = h.Applicant, Pname = h.Pname, Pid = h.Pid, Createtime = h.Createtime, Pm = h.Pm, Department = h.Department, State = h.State, Hangupcause = h.Hangupcause, Processingstep = h.Processingstep, Handler = h.Handler };
                int result = conn.Execute(executeSql, Collectlist);
                return result;
            }
        }

        public List<Hangup> GetHangup()
        {
            using (OracleConnection conn = DapperHelper.GetConnString())
            {
                string sql = @"select * from Hangup";
                var result = conn.Query<Hangup>(sql, null);
                return result.ToList();

            }
        }
        public List<Hangup> GetHangupById(int Id)
        {
            using (OracleConnection conn = DapperHelper.GetConnString())
            {
                string sql = @"select * from Hangup where Id=:Id";
                var Collectlist = new { Id = Id };
                var result = conn.Query<Hangup>(sql, Collectlist);
                return result.ToList();
            }
        }
    }
}
