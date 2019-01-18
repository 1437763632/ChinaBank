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
    public class PMOSolutionServices:IPMOSolutionServices
    {
        /// <summary>
        /// PMO
        /// </summary>
        /// <returns></returns>
        public List<Solutiontohang> GetSolutionpmo()
        {
            using (OracleConnection conn = DapperHelper.GetConnString())
            {
                string sql = @"select * from Solutiontohang where Schedule=10";
                var result = conn.Query<Solutiontohang>(sql, null);
                return result.ToList();
            }
        }
        /// <summary>
        /// 所属部门
        /// </summary>
        /// <returns></returns>
        public List<Solutiontohang> GetSolutiondepart()
        {
            using (OracleConnection conn = DapperHelper.GetConnString())
            {
                string sql = @"select * from Solutiontohang where Schedule=4";
                var result = conn.Query<Solutiontohang>(sql, null);
                return result.ToList();
            }
        }
        /// <summary>
        /// 工程管理部
        /// </summary>
        /// <returns></returns>
        public List<Solutiontohang> GetSolutionproject()
        {
            using (OracleConnection conn = DapperHelper.GetConnString())
            {
                string sql = @"select * from Solutiontohang where Schedule=11";
                var result = conn.Query<Solutiontohang>(sql, null);
                return result.ToList();
            }
        }
        /// <summary>
        /// 项目管理部
        /// </summary>
        /// <returns></returns>
        public List<Solutiontohang> GetSolutionitem()
        {
            using (OracleConnection conn = DapperHelper.GetConnString())
            {
                string sql = @"select * from Solutiontohang where Schedule=1";
                var result = conn.Query<Solutiontohang>(sql, null);
                return result.ToList();
            }
        }
        /// <summary>
        /// 总经理
        /// </summary>
        /// <returns></returns>
        public List<Solutiontohang> GetSolutiongmo()
        {
            using (OracleConnection conn = DapperHelper.GetConnString())
            {
                string sql = @"select * from Solutiontohang where Schedule=9";
                var result = conn.Query<Solutiontohang>(sql, null);
                return result.ToList();
            }
        }

        public int UpdateSolutionpmo(Solutiontohang solution)
        {
            using (OracleConnection conn = DapperHelper.GetConnString())
            {
                string executeSql = @" update Solutiontohang set State=:State,Schedule=:Schedule,Pmoopinion=:Pmoopinion,Processingstep=:Processingstep,Handler=:Handler where Id=:Id";
                solution.Schedule = "10";
                solution.State = "解挂审核中";
                var Collectlist = new { Id = solution.Id, State = solution.State, Schedule = solution.Schedule, Pmoopinion = solution.Pmoopinion, Processingstep = solution.Processingstep, Handler = solution.Handler };
                int result = conn.Execute(executeSql, Collectlist);
                return result;
            }
        }

        public int UpdateSolutionpart(Solutiontohang solution)
        {
            using (OracleConnection conn = DapperHelper.GetConnString())
            {
                string executeSql = @" update Solutiontohang set Schedule=:Schedule,Pmoopinion=:Pmoopinion,Processingstep=:Processingstep,Handler=:Handler where Id=:Id";
                solution.Schedule = "4";
                var Collectlist = new { Id = solution.Id, State = solution.State, Schedule = solution.Schedule, Pmoopinion = solution.Pmoopinion, Processingstep = solution.Processingstep, Handler = solution.Handler };
                int result = conn.Execute(executeSql, Collectlist);
                return result;
            }
        }

        public int UpdateSolutionproc(Solutiontohang solution)
        {
            using (OracleConnection conn = DapperHelper.GetConnString())
            {
                string executeSql = @" update Solutiontohang set Schedule=:Schedule,Pmoopinion=:Pmoopinion,Processingstep=:Processingstep,Handler=:Handler where Id=:Id";
                solution.Schedule = "11";
                var Collectlist = new { Id = solution.Id, State = solution.State, Schedule = solution.Schedule, Pmoopinion = solution.Pmoopinion, Processingstep = solution.Processingstep, Handler = solution.Handler };
                int result = conn.Execute(executeSql, Collectlist);
                return result;
            }
        }

        public int UpdateSolutionitem(Solutiontohang solution)
        {
            using (OracleConnection conn = DapperHelper.GetConnString())
            {
                string executeSql = @" update Solutiontohang set Schedule=:Schedule,Pmoopinion=:Pmoopinion,Processingstep=:Processingstep,Handler=:Handler where Id=:Id";
                solution.Schedule = "1";
                var Collectlist = new { Id = solution.Id, State = solution.State, Schedule = solution.Schedule, Pmoopinion = solution.Pmoopinion, Processingstep = solution.Processingstep, Handler = solution.Handler };
                int result = conn.Execute(executeSql, Collectlist);
                return result;
            }
        }

        public int UpdateSolutiongmo(Solutiontohang solution)
        {
            using (OracleConnection conn = DapperHelper.GetConnString())
            {
                string executeSql = @" update Solutiontohang set State=:State,Schedule=:Schedule,Pmoopinion=:Pmoopinion,Processingstep=:Processingstep,Handler=:Handler where Id=:Id";
                solution.Schedule = "9";
                solution.State = "已解挂";
                var Collectlist = new { Id = solution.Id, State = solution.State, Schedule = solution.Schedule, Pmoopinion = solution.Pmoopinion, Processingstep = solution.Processingstep, Handler = solution.Handler };
                int result = conn.Execute(executeSql, Collectlist);
                return result;
            }
        }
        /// <summary>
        /// 驳回
        /// </summary>
        /// <param name="solution"></param>
        /// <returns></returns>
        public int UpdateState(Solutiontohang solution)
        {
            using (OracleConnection conn = DapperHelper.GetConnString())
            {
                string executeSql = @" update Solutiontohang set State=:State,Schedule=:Schedule where Id=:Id";
                solution.State = "已驳回";
                solution.Schedule = "0";
                var Collectlist = new { Id = solution.Id, State = solution.State, Schedule = solution.Schedule };
                int result = conn.Execute(executeSql, Collectlist);
                return result;
            }
        }
    }
}
