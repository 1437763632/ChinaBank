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
                string executeSql = @" INSERT INTO Initiation(Code,Applicant,Pid,Times,Pname,Ptype,Requisitionid,Productname,Projectnum,Operating,ZPM,Principal,Department,Coordinate,Start,Starttime,Letter,Limit,Pm,Pmqualification,Identification,Appointtype,Pschedule,Budget,Urgent,Admin,Business,Pteam,Engineer,Architect,Testmanager,Qualityengineer,Configurationadmin,Testarchitect,Financecode,Financetime,Accessory) VALUES (:Code,:Applicant,:Pid,:Times,:Pname,:Ptype,:Requisitionid,:Productname,:Projectnum,:Operating,:ZPM,:Principal,:Department,:Coordinate,:Start,:Starttime,:Letter,:Limit,:Pm,:Pmqualification,:Identification,:Appointtype,:Pschedule,:Budget,:Times,:Urgent,:Admin,:Business,:Pteam,:Engineer,:Architect,:Testmanager,:Qualityengineer,:Configurationadmin,:Testarchitect,:Financecode,:Financetime,:Accessory) ";
                initiation.Times= System.DateTime.Now;
                var Collectlist = new { Code = initiation.Code, Applicant = initiation.Applicant, Pid = initiation.Pid, Pname = initiation.Pname, Ptype = initiation.Ptype, Requisitionid = initiation.Requisitionid, Productname = initiation.Productname, Projectnum = initiation.Projectnum, Operating = initiation.Operating, ZPM = initiation.ZPM, Principal = initiation.Principal, Department = initiation.Department, Coordinate = initiation.Coordinate, Start = initiation.Start, Starttime = initiation.Starttime, Letter = initiation.Letter, Limit = initiation.Limit, Pm = initiation.Pm, Pmqualification = initiation.Pmqualification, Identification = initiation.Identification, Appointtype = initiation.Appointtype, Pschedule = initiation.Pschedule, Budget = initiation.Budget, Urgent = initiation.Urgent, Admin = initiation.Admin, Business = initiation.Business, Pteam = initiation.Pteam, Engineer = initiation.Engineer, Architect = initiation.Architect, Testmanager = initiation.Testmanager, Qualityengineer = initiation.Qualityengineer, Configurationadmin = initiation.Configurationadmin, Testarchitect = initiation.Testarchitect, Financecode = initiation.Financecode, Financetime = initiation.Financetime, Accessory = initiation.Accessory };
                int result = conn.Execute(executeSql, Collectlist);
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
        public List<InitiationType> GetInitiationType()
        {
            using (OracleConnection conn = DapperHelper.GetConnString())
            {
                string sql = @"select * from InitiationType";
                var result = conn.Query<InitiationType>(sql, null);
                return result.ToList();

            }
        }
    }
}
