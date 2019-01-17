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
    public class PMOAuditService : IPMOAuditService
    {
        public List<Hangup> GetHangupDepartment()
        {
            using (OracleConnection conn = DapperHelper.GetConnString())
            {
                string sql = @"select * from Hangup where Schedule=3";
                var result = conn.Query<Hangup>(sql, null);
                return result.ToList();

            }
        }

        public List<Hangup> GetHangupGm()
        {
            using (OracleConnection conn = DapperHelper.GetConnString())
            {
                string sql = @"select * from Hangup where Schedule=9";
                var result = conn.Query<Hangup>(sql, null);
                return result.ToList();

            }
        }

        public List<Hangup> GetHangupItem()
        {
            using (OracleConnection conn = DapperHelper.GetConnString())
            {
                string sql = @"select * from Hangup where Schedule=1";
                var result = conn.Query<Hangup>(sql, null);
                return result.ToList();

            }
        }

        public List<Hangup> GetHangupPMO()
        {
            using (OracleConnection conn = DapperHelper.GetConnString())
            {
                string sql = @"select * from Hangup where Schedule=10";
                var result = conn.Query<Hangup>(sql, null);
                return result.ToList();

            }
        }

        public List<Hangup> GetHangupProject()
        {
            using (OracleConnection conn = DapperHelper.GetConnString())
            {
                string sql = @"select * from Hangup where Schedule=11";
                var result = conn.Query<Hangup>(sql, null);
                return result.ToList();

            }
        }

        public int UpdateHangupDepartment(Hangup hangup)
        {
            using (OracleConnection conn = DapperHelper.GetConnString())
            {
                string executeSql = @" update Hangup set Schedule=:Schedule,Departmentopinion=:Departmentopinion,Processingstep=:Processingstep,Handler=:Handler where Id=:Id";
                hangup.Schedule = 11;
                var Collectlist = new { Id = hangup.Id, Schedule = hangup.Schedule, Departmentopinion = hangup.Departmentopinion, Processingstep = hangup.Processingstep, Handler = hangup.Handler };
                int result = conn.Execute(executeSql, Collectlist);
                return result;
            }
        }

        public int UpdateHangupGm(Hangup hangup)
        {
            using (OracleConnection conn = DapperHelper.GetConnString())
            {
                string executeSql = @" update Hangup set State=:State,Schedule=:Schedule,Gmopinion=:Gmopinion,Processingstep=:Processingstep,Handler=:Handler where Id=:Id";
                hangup.Schedule = 9;
                hangup.State = "已审批";
                var Collectlist = new { Id = hangup.Id, State=hangup.State,Schedule = hangup.Schedule, Gmopinion = hangup.Gmopinion, Processingstep = hangup.Processingstep, Handler = hangup.Handler };
                int result = conn.Execute(executeSql, Collectlist);
                return result;
            }
        }

        public int UpdateHangupItem(Hangup hangup)
        {
            using (OracleConnection conn = DapperHelper.GetConnString())
            {
                string executeSql = @" update Hangup set Schedule=:Schedule,Itemopinion=:Itemopinion,Processingstep=:Processingstep,Handler=:Handler where Id=:Id";
                hangup.Schedule = 9;
                var Collectlist = new { Id = hangup.Id, Schedule = hangup.Schedule, Itemopinion = hangup.Itemopinion, Processingstep = hangup.Processingstep, Handler = hangup.Handler };
                int result = conn.Execute(executeSql, Collectlist);
                return result;
            }
        }

        //public int UpdateHangupDepartment(int Id, int Schedule, string Departmentopinion, string Processingstep, string Handler)
        //{
        //    using (OracleConnection conn = DapperHelper.GetConnString())
        //    {
        //        string executeSql = @" update Hangup set Schedule=:Schedule,Departmentopinion=:Departmentopinion,Processingstep=:Processingstep,Handler=:Handler where Id=:Id";
        //        Schedule = 11;
        //        var Collectlist = new { Id = Id, Schedule = Schedule, Departmentopinion = Departmentopinion, Processingstep = Processingstep, Handler = Handler };
        //        int result = conn.Execute(executeSql, Collectlist);
        //        return result;
        //    }
        //}

        public int UpdateHangupPMO(Hangup hangup)
        {
            using (OracleConnection conn = DapperHelper.GetConnString())
            {
                string executeSql = @" update Hangup set State=:State,Schedule=:Schedule,Pmoopinion=:Pmoopinion,Processingstep=:Processingstep,Handler=:Handler where Id=:Id";
                hangup.Schedule = 3;
                hangup.State = "审核中";
                var Collectlist = new { Id=hangup.Id, State = hangup.State,Schedule = hangup.Schedule, Pmoopinion=hangup.Pmoopinion, Processingstep=hangup.Processingstep, Handler=hangup.Handler};
                int result = conn.Execute(executeSql, Collectlist);
                return result;
            }
        }

        public int UpdateHangupProject(Hangup hangup)
        {
            using (OracleConnection conn = DapperHelper.GetConnString())
            {
                string executeSql = @" update Hangup set Schedule=:Schedule,Projectopinion=:Projectopinion,Processingstep=:Processingstep,Handler=:Handler where Id=:Id";
                hangup.Schedule = 1;
                var Collectlist = new { Id = hangup.Id, Schedule = hangup.Schedule, Projectopinion = hangup.Projectopinion, Processingstep = hangup.Processingstep, Handler = hangup.Handler };
                int result = conn.Execute(executeSql, Collectlist);
                return result;
            }
        }
        /// <summary>
        /// 驳回
        /// </summary>
        /// <param name="hangup"></param>
        /// <returns></returns>
        public int UpdateState(Hangup hangup)
        {
            using (OracleConnection conn = DapperHelper.GetConnString())
            {
                string executeSql = @" update Hangup set State=:State,Schedule=:Schedule where Id=:Id";
                hangup.State = "已驳回";
                hangup.Schedule = 0;
                var Collectlist = new { Id = hangup.Id, State = hangup.State, Schedule = hangup.Schedule };
                int result = conn.Execute(executeSql, Collectlist);
                return result;
            }
        }
    }
}
