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
    public class PDSPService : IPDSPService
    {
        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="pdsp"></param>
        /// <returns></returns>
        public int Addpdsp(PDSP pdsp)
        {
            using (OracleConnection conn = DapperHelper.GetConnString())
            {
                string executeSql = @" INSERT INTO pdsp(Forms,Pid,Pname,Applicant,Pmheadoffice,Createtime,Department,Finishtime,Takeeffecttime,Postprojectnature,Centerprojectpm,Resultsevaluation,Stakeholder,Questionid,QuestionName,Ismodify,Introducer,Passed,Remarks,Auditconclusion,Legacymatters,Othermatters,Signature,Implementation,Itemopinion,Projectopinion,Resourceadmin,Financialadmin,Departmentopinion,Executiveoffice,Projstateid) VALUES (:Forms,:Pid,:Pname,:Applicant,:Pmheadoffice,:Createtime,:Department,:Finishtime,:Takeeffecttime,:Postprojectnature,:Centerprojectpm,:Resultsevaluation,:Stakeholder,:Questionid,:QuestionName,:Ismodify,:Introducer,:Passed,:Remarks,:Auditconclusion,:Legacymatters,:Othermatters,:Signature,:Implementation,:Itemopinion,:Projectopinion,:Resourceadmin,:Financialadmin,:Departmentopinion,:Executiveoffice,:Projstateid) ";
                
                int result = conn.Execute(executeSql, pdsp);
                return result;
            }
        }
        /// <summary>
        /// 显示
        /// </summary>
        /// <returns></returns>

        public List<PDSP> GetPDSPs()
        {
            using (OracleConnection conn = DapperHelper.GetConnString())
            {
                string sql = @"select * from pdsp";
                var result = conn.Query<PDSP>(sql, null);
                return result.ToList();

            }
        }

        /// <summary>
        /// 项目信息表显示
        /// </summary>
        /// <returns></returns>
        public List<Model.Projmessage> projmessages()
        {
            using (OracleConnection conn = DapperHelper.GetConnString())
            {
                string sql = @"select * from Projmessage";
                var result = conn.Query<Model.Projmessage>(sql, null);
                return result.ToList();

            }
        }
        /// <summary>
        /// 反填
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public List<PDSP> GetPs(int Id)
        {
            using (OracleConnection conn = DapperHelper.GetConnString())
            {
                string sql = @"select * from pdsp where Id=:Id";
                var Collectlist = new { Id = Id };
                var result = conn.Query<PDSP>(sql, Collectlist);
                return result.ToList();
            }
        }
        /// <summary>
        /// 驳回修改
        /// </summary>
        /// <param name="pdsp"></param>
        /// <returns></returns>
        public int updatePdsp(PDSP pdsp)
        {
            using (OracleConnection conn = DapperHelper.GetConnString())
            {
                string sql = @"Update pdsp set Projstateid=:Projstateid where id=:id";
                var result = conn.Execute(sql, pdsp);
                return result;
            }
        }

        /// <summary>
        /// PMO修改
        /// </summary>
        /// <param name="pdsp"></param>
        /// <returns></returns>
        public int PmoUpdatePdsp(PDSP pdsp)
        {
            using (OracleConnection conn = DapperHelper.GetConnString())
            {
                string sql = @"Update pdsp set Questionid=:Questionid,QuestionName=:QuestionName,Legacymatters=:Legacymatters,Othermatters=:Othermatters Projstateid=:Projstateid where id=:id";
                var result = conn.Execute(sql, pdsp);
                return result;
            }
        }
        /// <summary>
        /// 牵头部门修改
        /// </summary>
        /// <param name="pdsp"></param>
        /// <returns></returns>
        public int ImpUpdatePdsp(PDSP pdsp)
        {
            using (OracleConnection conn = DapperHelper.GetConnString())
            {
                string sql = @"Update pdsp set Implementation=:Implementation,Projstateid=:Projstateid where id=:id";
                var result = conn.Execute(sql, pdsp);
                return result;
            }
        }

        /// <summary>
        /// 项目管理修改
        /// </summary>
        /// <param name="pdsp"></param>
        /// <returns></returns>
        public int ItemUpdatePdsp(PDSP pdsp)
        {
            using (OracleConnection conn = DapperHelper.GetConnString())
            {
                string sql = @"Update pdsp set Itemopinion=:Itemopinion,Projstateid=:Projstateid where id=:id";
                var result = conn.Execute(sql, pdsp);
                return result;
            }
        }

        /// <summary>
        /// 资源管理修改
        /// </summary>
        /// <param name="pdsp"></param>
        /// <returns></returns>
        public int ResourceUpdatePdsp(PDSP pdsp)
        {
            using (OracleConnection conn = DapperHelper.GetConnString())
            {
                string sql = @"Update pdsp set Resourceadmin=:Resourceadmin,Projstateid=:Projstateid where id=:id";
                var result = conn.Execute(sql, pdsp);
                return result;
            }
        }

        /// <summary>
        /// 财务管理修改
        /// </summary>
        /// <param name="pdsp"></param>
        /// <returns></returns>
        public int FinancialUpdatePdsp(PDSP pdsp)
        {
            using (OracleConnection conn = DapperHelper.GetConnString())
            {
                string sql = @"Update pdsp set Financialadmin=:Financialadmin,Projstateid=:Projstateid where id=:id";
                var result = conn.Execute(sql, pdsp);
                return result;
            }
        }

        /// <summary>
        /// 总经理管理修改
        /// </summary>
        /// <param name="pdsp"></param>
        /// <returns></returns>
        public int GeneralUpdatePdsp(PDSP pdsp)
        {
            using (OracleConnection conn = DapperHelper.GetConnString())
            {   
                string sql = @"Update pdsp set Executiveoffice=:Executiveoffice,Projstateid=:Projstateid where id=:id";
                var result = conn.Execute(sql, pdsp);
                string sql1 = @"select * from  pdsp where id=:id";
                var result1 = conn.Query<PDSP>(sql1, new { id= pdsp.Id }).FirstOrDefault();
                string sql2= @"Update Projmessage set Projstate='结项' where Projcoding=:Projcoding";
                var res = conn.Execute(sql2, new { Projcoding = result1.Pid });
                return result;
            }
        }
    }

}
