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
    public class Projmessage : IProjmessageServices
    {
        /// <summary>
        /// 添加项目信息
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        public int Add(Model.Projmessage message)
        {
            using (OracleConnection conn = DapperHelper.GetConnString())
            {
                string executeSql = @"INSERT INTO Projmessage
(formfirst,projname,projcoding,maintaindate,accounting,approvaldate,approvalnum,projcategory,projtype,business,businessteam,department,problemteam,cooperation,isstart,isstartdate,letter,limit,isurgency,isagility,creationdate,projdate,projstate,sbstage,schedutestate,nature,headoffice,businessleader,managerperson,phone,qualification,zhengfu,appointtype,centremanager,contactnumber,qualifications,Andidentify,appointmenttype,architect,parlor,programmanager,testarchitect,testmanager,qualityengineer,systemsengineer,configurationadministrator,versionmanager,projteam,problem) VALUES 
(:formfirst,:projname,:projcoding,:maintaindate,:accounting,:approvaldate,:approvalnum,:projcategory,:projtype,:business,:businessteam,:department,:problemteam,:cooperation,:isstart,:isstartdate,:letter,:limit,:isurgency,:isagility,:creationdate,:projdate,:projstate,:sbstage,:schedutestate,:nature,:headoffice,:businessleader,:managerperson,:phone,:qualification,:zhengfu,:appointtype,:centremanager,:contactnumber,:qualifications,:Andidentify,:appointmenttype,:architect,:parlor,:programmanager,:testarchitect,:testmanager,:qualityengineer,:systemsengineer,:configurationadministrator,:versionmanager,:projteam,:problem)";
                return conn.Execute(executeSql, message);
            }
        }

        /// <summary>
        /// 显示项目信息
        /// </summary>
        /// <returns></returns>
        public List<Model.Projmessage> GetProjmessage()
        {
            using (OracleConnection conn = DapperHelper.GetConnString())
            {
                string captureByIdSql = @"select * from Projmessage";
                var result = conn.Query<Model.Projmessage>(captureByIdSql, null);
                return result.ToList();
            }
        }

        /// <summary>
        /// 删除项目信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int Delete(int id)
        {
            using (OracleConnection conn = DapperHelper.GetConnString())
            {
                string executeSql = @"delete from Projmessage where Id=" + id;
                return conn.Execute(executeSql, id);
            }
        }
    }
}
