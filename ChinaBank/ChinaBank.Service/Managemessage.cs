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
    class Managemessage:IManagessageServices
    {
        public int Add(Managemessage message)
        {
            using (OracleConnection conn = DapperHelper.GetConnString())
            {   
                string executeSql = @" INSERT INTO Managemessage (itemnumber,projectmanager,qualification,identify,appointment,projectplan,situation,appointmentdate) VALUES ( :formfirst, :projname, :projcoding, :maintaindate, :accounting, :approvaldate, :approvalnum, :projcategory, :projtype,:business,:businessteam,:department,:problemteam,:cooperation,:isstart,:isstartdate,:letter,:limit,:isurgency,:isagility,:creationdate,:projdate,:projstate,:sbstage,:schedutestate,:nature，:headoffice，:businessleader，:managerperson，:phone，:qualification，:zhengfu，:appointtype，:centremanager，:contactnumber，:qualifications，:Andidentify,:appointmenttype,:architect,:parlor,:programmanager,:testarchitect,:testmanager,:qualityengineer,:systemsengineer,:configurationadministrator,:versionmanager,:projteam,:problem)";
                return conn.Execute(executeSql, message);
            }
        }

        public List<Managemessage> GetManagemessage()
        {
            using (OracleConnection conn = DapperHelper.GetConnString())
            {
                string captureByIdSql = @" select * from Managemessage";
                var result = conn.Query<Managemessage>(captureByIdSql, null);
                return result.ToList();
            }
        }
    }
}
