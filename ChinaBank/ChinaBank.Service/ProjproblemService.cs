using ChinaBank.IService;
using ChinaBank.Model;
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

    public class ProjproblemService : IProjproblemServices
    {
        /// <summary>
        /// 添加项目问题
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public int Add(Model.Projproblem p)
        {
            using (OracleConnection conn = DapperHelper.GetConnString())
            {
                string executeSql = @" INSERT INTO Projproblem ( recognition, serialnumber, introducer, inriqi, identification, tasktype, taskname, tasklink, projname,department,projmanager,batch,causes,probname,probdescription,analyze,solve,accessory,probtype,technology,probpriority,severity,influencebatch,subordinate,statetail,deadline，practical，probstate，probrank，currentdepartment，currentperson，assistperson，followperson，startdate，continuenumber，totalduration，lastupdate) VALUES ( :recognition, :serialnumber, :introducer, :inriqi, :identification, :tasktype, :taskname, :tasklink, :projname, :department, :projmanager, :batch, :causes, :probname, :probdescription, :analyze, :solve, :accessory, :probtype, :technology, :probpriority, :severity, :influencebatch, :subordinate, :statetail, :deadline, :practical, :probstate,:probrank, :currentdepartment, :currentperson, :assistperson, :followperson, :startdate, :continuenumber, :totalduration, :lastupdate)";
                return conn.Execute(executeSql, p);
            }
        }

        /// <summary>
        /// 显示项目问题
        /// </summary>
        /// <returns></returns>
        public List<Model.Projproblem> GetProjproblems()
        {
            using (OracleConnection conn = DapperHelper.GetConnString())
            {
                string captureByIdSql = @" select * from Projproblem";
                var result = conn.Query<Model.Projproblem>(captureByIdSql, null);
                return result.ToList();
            }
        }

        /// <summary>
        /// 查询项目问题
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public List<Model.Projproblem> Getproj(int id)
        {
            using (OracleConnection conn = DapperHelper.GetConnString())
            {
                string sql = @"select * from Projproblem where Id=" + id;
                var result = conn.Query<Model.Projproblem>(sql, id);
                return result.ToList();
            }
        }
    }
}
