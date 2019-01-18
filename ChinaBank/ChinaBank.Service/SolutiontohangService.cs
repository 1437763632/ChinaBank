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

    public class SolutiontohangService:ISolutiontohangService
    {
        public int AddSolutiontohang(Solutiontohang s)
        {
            using (OracleConnection conn = DapperHelper.GetConnString())
            {
                string executeSql = @" INSERT INTO Solutiontohang(Code,Applicant,Pname,Pid,Createtime,Solutiontohangtime,Pm,Department,State,Solutiontohangcause,Processingstep,Handler) VALUES (:Code,:Applicant,:Pname,:Pid,:Createtime,:Solutiontohangtime,:Pm,:Department,:State,:Solutiontohangcause,:Processingstep,:Handler) ";
                s.Solutiontohangtime = System.DateTime.Now;
                var Collectlist = new { Code = s.Code, Applicant = s.Applicant, Pname = s.Pname, Pid = s.Pid, Createtime = s.Createtime, Solutiontohangtime=s.Solutiontohangtime,Pm = s.Pm, Department = s.Department, State = s.State, Solutiontohangcause = s.Solutiontohangcause, Processingstep = s.Processingstep, Handler = s.Handler };
                int result = conn.Execute(executeSql, Collectlist);
                return result;
            }
        }

        public List<Solutiontohang> GetSolutiontohang()
        {
            using (OracleConnection conn = DapperHelper.GetConnString())
            {
                string sql = @"select * from Solutiontohang";
                var result = conn.Query<Solutiontohang>(sql, null);
                return result.ToList();
            }
        }
        public List<Solutiontohang> GetSolutiontohangById(int Id)
        {
            using (OracleConnection conn = DapperHelper.GetConnString())
            {
                string sql = @"select * from Solutiontohang where Id=:Id";
                var Collectlist = new { Id = Id };
                var result = conn.Query<Solutiontohang>(sql, Collectlist);
                return result.ToList();
            }
        }
        public List<Nodes> GetNode()
        {
            using (OracleConnection conn = DapperHelper.GetConnString())
            {
                string sql = @"select * from Nodes";
                var result = conn.Query<Nodes>(sql, null);
                return result.ToList();
            }
        }

        public List<Manage> GetManage(int DepartmentId)
        {
            using (OracleConnection conn = DapperHelper.GetConnString())
            {
                string sql = @"select * from Manage where Id=:DepartmentId";
                //var Collectlist = new { DepartmentId = DepartmentId };
                var result = conn.Query<Manage>(sql, new { DepartmentId = DepartmentId });
                return result.ToList();
            }
        }
    }
}
