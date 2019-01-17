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
        public int AddInitiation(Initiation initiation)
        {
            using (OracleConnection conn = DapperHelper.GetConnString())
            {
                string executeSql = @" INSERT INTO Initiation(Code,Applicant,Pid,Pname,Ptype,Requisitionid,Principal,Department,Coordinate,Starts,Starttime,Letter,Limits,Pm,Pmqualification,Identification,Appointtype,Pschedule,Budget,Times,Urgent,Admins,Business,Pteam,Engineer,Architect,Testmanager,Qualityengineer,Configurationadmin,Testarchitect,Financecode,Financetime,Accessory,Projectnum,Productname,Operating,ZPM) VALUES (:Code,:Applicant,:Pid,:Pname,:Ptype,:Requisitionid,:Principal,:Department,:Coordinate,:Starts,:Starttime,:Letter,:Limits,:Pm,:Pmqualification,:Identification,:Appointtype,:Pschedule,:Budget,:Times,:Urgent,:Admins,:Business,:Pteam,:Engineer,:Architect,:Testmanager,:Qualityengineer,:Configurationadmin,:Testarchitect,:Financecode,:Financetime,:Accessory,:Projectnum,:Productname,:Operating,:ZPM) ";
                //initiation.Times = System.DateTime.Now;
                var Collectlist = new { Code = initiation.Code, Applicant = initiation.Applicant, Pid = initiation.Pid, Pname = initiation.Pname, Ptype = initiation.Ptype, Requisitionid = initiation.Requisitionid, Principal = initiation.Principal, Department = initiation.Department, Coordinate = initiation.Coordinate, Starts= initiation.Starts, Starttime = initiation.Starttime, Letter = initiation.Letter, Limits = initiation.Limits, Pm = initiation.Pm, Pmqualification = initiation.Pmqualification, Identification = initiation.Identification, Appointtype = initiation.Appointtype, Pschedule = initiation.Pschedule, Budget = initiation.Budget, Times = initiation.Times, Urgent = initiation.Urgent, Admins = initiation.Admins, Business = initiation.Business, Pteam = initiation.Pteam, Engineer = initiation.Engineer, Architect = initiation.Architect, Testmanager = initiation.Testmanager, Qualityengineer = initiation.Qualityengineer, Configurationadmin = initiation.Configurationadmin, Testarchitect = initiation.Testarchitect, Financecode = initiation.Financecode, Financetime = initiation.Financetime, Accessory = initiation.Accessory, Projectnum = initiation.Projectnum, Productname = initiation.Productname, Operating = initiation.Operating, ZPM = initiation.ZPM };

                //string executeSql = @" INSERT INTO Initiation(Code,Applicant,Pid,Pname,Ptype,Requisitionid,Principal,Department,Coordinate,Starts,Starttime) VALUES (:Code,:Applicant,:Pid,:Pname,:Ptype,:Requisitionid,:Principal,:Department,:Coordinate,:Starts,:Starttime) ";
                ////initiation.Times = System.DateTime.Now;
                //var Collectlist = new { Code = initiation.Code, Applicant = initiation.Applicant, Pid = initiation.Pid, Pname = initiation.Pname, Ptype = initiation.Ptype, Requisitionid = initiation.Requisitionid, Principal = initiation.Principal, Department = initiation.Department, Coordinate = initiation.Coordinate, Starts = initiation.Starts,Starttime = initiation.Starttime };
                int result = conn.Execute(executeSql, initiation);
                return result;
            }
        }

        public List<Initiation> GetInitiation()
        {
            using (OracleConnection conn = DapperHelper.GetConnString())
            {
                string sql = @"select * from Initiation";
                var result = conn.Query<Initiation>(sql, null);
                return result.ToList();

            }
        }
        public List<Initiation> GetInitiationByPname()
        {
            using (OracleConnection conn = DapperHelper.GetConnString())
            {
                string sql = @"select * from Initiation";
                var result = conn.Query<Initiation>(sql, null);
                return result.ToList();

            }
        }
        public List<Initiation> GetInitiationById(int Id)
        {
            using (OracleConnection conn = DapperHelper.GetConnString())
            {
                string sql = @"select * from Initiation where Id=:Id";
                var Collectlist = new { Id = Id };
                var result = conn.Query<Initiation>(sql, Collectlist);
                return result.ToList();
            }
        }
        /// <summary>
        /// 项目审批
        /// </summary>
        /// <param name="initiation"></param>
        /// <returns></returns>
        public int InitiationApprovals(Initiation initiation)
        {
            using (OracleConnection conn = DapperHelper.GetConnString())
            {
                //定义sql语句
                string sql = string.Empty;
                //查询该流程所有节点信息
                sql = @"select nodesid from Configs where approvalsid=(select id from Approvals where name='项目立项')";
                var nodes = conn.Query<string>(sql, null);
                string nodesStr = nodes.FirstOrDefault();
                 sql = @"update  Initiation set Principal=:Principal where Id=:Id";                
                var result = conn.Execute(sql, initiation);
                return result;
            }
        }
    }
}
