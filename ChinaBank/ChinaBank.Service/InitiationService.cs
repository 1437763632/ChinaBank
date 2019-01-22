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
                initiation.Times = System.DateTime.Now.ToString("yyyy-MM-dd");
                var Collectlist = new { Code = initiation.Code, Applicant = initiation.Applicant, Pid = initiation.Pid, Pname = initiation.Pname, Ptype = initiation.Ptype, Requisitionid = initiation.Requisitionid, Principal = initiation.Principal, Department = initiation.Department, Coordinate = initiation.Coordinate, Starts = initiation.Starts, Starttime = initiation.Starttime, Letter = initiation.Letter, Limits = initiation.Limits, Pm = initiation.Pm, Pmqualification = initiation.Pmqualification, Identification = initiation.Identification, Appointtype = initiation.Appointtype, Pschedule = initiation.Pschedule, Budget = initiation.Budget, Times = initiation.Times, Urgent = initiation.Urgent, Admins = initiation.Admins, Business = initiation.Business, Pteam = initiation.Pteam, Engineer = initiation.Engineer, Architect = initiation.Architect, Testmanager = initiation.Testmanager, Qualityengineer = initiation.Qualityengineer, Configurationadmin = initiation.Configurationadmin, Testarchitect = initiation.Testarchitect, Financecode = initiation.Financecode, Financetime = initiation.Financetime, Accessory = initiation.Accessory, Projectnum = initiation.Projectnum, Productname = initiation.Productname, Operating = initiation.Operating, ZPM = initiation.ZPM };

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
                //sql = @"select nodesid from Configs where approvalsid=(select id from Approvals where name='项目立项')";
                //var nodes = conn.Query<string>(sql, null);
                //string nodesStr = nodes.FirstOrDefault();
                //var nodeTip = nodesStr.Split(',');
                //string[] node = new string[100];

                //定义返回结果
                var result = 0;
                //流程控制节点1,2,3|4|5|6|7|8,9
                //当节点1时项目管理部主管审批
                if (initiation.State == "1")
                {
                    initiation.State = "2";
                    //根据状态改变查找
                    sql = @"select nodename from nodes where id=" + initiation.State;
                    //将状态信息转换为string类型字符串
                    initiation.Accessory = String.Join(",", conn.Query<string>(sql, null).ToList());
                    //修改要修改的内容
                    sql = @"update  Initiation set Principal=:Principal,Accessory=:Accessory,State=:State where Id=:Id";
                    result = conn.Execute(sql, initiation);
                    return result;
                }
                //财务管理部主管审批
                if (initiation.State == "2")
                {
                    initiation.State = "3";
                    //根据状态改变查找
                    sql = @"select nodename from nodes where id=" + initiation.State;
                    //将状态信息转换为string类型字符串
                    initiation.Accessory = String.Join(",", conn.Query<string>(sql, null).ToList());
                    //修改要修改的内容
                    sql = @"update  Initiation set Accessory=:Accessory,State=:State,Starttime=:Starttime,Letter=:Letter,Limits=:Limits,Code=:Code,Financecode=:Financecode,Financetime=:Financetime where Id=:Id";
                    result = conn.Execute(sql, initiation);
                    return result;
                }
                //开发部主管审批
                if (initiation.State == "3")
                {

                    initiation.State = "4|5|6|7|8";
                    var state = initiation.State.Split('|');
                    var nodename = new List<string>();
                    foreach (var item in state)
                    {
                        if (item != "")
                        {
                            //根据状态改变查找
                            sql = @"select nodename from nodes where id =" + item;
                            nodename.Add(conn.Query<string>(sql, null).FirstOrDefault());
                        }
                    }

                    //将状态信息转换为string类型字符串
                    initiation.Accessory = String.Join(",", nodename);
                    //修改要修改的内容
                    sql = @"update  Initiation set Accessory=:Accessory,State=:State where Id=:Id";
                    result = conn.Execute(sql, initiation);
                    return result;
                }
                //当处于节点4时
                if (initiation.State == "4")
                {
                    initiation.State = initiation.State.Replace("4", "");
                    var state = initiation.State.Split('|');
                    var nodename = new List<string>();
                    foreach (var item in state)
                    {
                        if (item != "")
                        {
                            //根据状态改变查找
                            sql = @"select nodename from nodes where id =" + item;
                            nodename.Add(conn.Query<string>(sql, null).FirstOrDefault());
                        }
                    }

                    //将状态信息转换为string类型字符串
                    initiation.Accessory = String.Join(",", nodename);
                    sql = @"update  Initiation set Accessory=:Accessory,State=:State where Id=:Id";
                    result = conn.Execute(sql, initiation);
                    return result;
                }
                //当处于节点5时
                if (initiation.State == "5")
                {
                    initiation.State = initiation.State.Replace("5", "");
                    var state = initiation.State.Split('|');
                    var nodename = new List<string>();
                    foreach (var item in state)
                    {
                        if (item != "")
                        {
                            //根据状态改变查找
                            sql = @"select nodename from nodes where id =" + item;
                            nodename.Add(conn.Query<string>(sql, null).FirstOrDefault());
                        }
                    }

                    //将状态信息转换为string类型字符串
                    initiation.Accessory = String.Join(",", nodename);
                    sql = @"update  Initiation set Accessory=:Accessory,State=:State where Id=:Id";
                    result = conn.Execute(sql, initiation);
                    return result;
                }
                //当处于节点6时
                if (initiation.State == "6")
                {
                    initiation.State = initiation.State.Replace("6", "");
                    var state = initiation.State.Split('|');
                    var nodename = new List<string>();
                    foreach (var item in state)
                    {
                        if (item != "")
                        {
                            //根据状态改变查找
                            sql = @"select nodename from nodes where id =" + item;
                            nodename.Add(conn.Query<string>(sql, null).FirstOrDefault());
                        }
                    }

                    //将状态信息转换为string类型字符串
                    initiation.Accessory = String.Join(",", nodename);
                    sql = @"update  Initiation set Accessory=:Accessory,State=:State where Id=:Id";
                    result = conn.Execute(sql, initiation);
                    return result;
                }
                //当处于节点7时
                if (initiation.State == "7")
                {
                    initiation.State = initiation.State.Replace("7", "");
                    var state = initiation.State.Split('|');
                    var nodename = new List<string>();
                    foreach (var item in state)
                    {
                        if (item != "")
                        {
                            //根据状态改变查找
                            sql = @"select nodename from nodes where id =" + item;
                            nodename.Add(conn.Query<string>(sql, null).FirstOrDefault());
                        }
                    }

                    //将状态信息转换为string类型字符串
                    initiation.Accessory = String.Join(",", nodename);
                    sql = @"update  Initiation set Accessory=:Accessory,State=:State where Id=:Id";
                    result = conn.Execute(sql, initiation);
                    return result;
                }
                //当处于节点8时
                if (initiation.State == "8")
                {
                    initiation.State = initiation.State.Replace("8", "");
                    var state = initiation.State.Split('|');
                    var nodename = new List<string>();
                    foreach (var item in state)
                    {
                        if (item != "")
                        {
                            //根据状态改变查找
                            sql = @"select nodename from nodes where id =" + item;
                            nodename.Add(conn.Query<string>(sql, null).FirstOrDefault());
                        }
                    }

                    //将状态信息转换为string类型字符串
                    initiation.Accessory = String.Join(",", nodename);
                    sql = @"update  Initiation set Accessory=:Accessory,State=:State where Id=:Id";
                    result = conn.Execute(sql, initiation);
                    return result;
                }
                //当全部走完分步骤
                if (initiation.State == "||||")
                {
                    initiation.State = "9";
                    var state = initiation.State.Split('|');
                    var nodename = new List<string>();
                    foreach (var item in state)
                    {
                        if (item != "")
                        {
                            //根据状态改变查找
                            sql = @"select nodename from nodes where id =" + item;
                            nodename.Add(conn.Query<string>(sql, null).FirstOrDefault());
                        }
                    }

                    //将状态信息转换为string类型字符串
                    initiation.Accessory = String.Join(",", nodename);
                    sql = @"update  Initiation set Accessory=:Accessory,State=:State where Id=:Id";
                    result = conn.Execute(sql, initiation);
                    return result;
                }
                //总经理室成员审批
                if (initiation.State == "9")
                {
                    initiation.State = "0";
                    var state = initiation.State.Split('|');
                    var nodename = new List<string>();
                    foreach (var item in state)
                    {
                        if (item != "")
                        {
                            //根据状态改变查找
                            sql = @"select nodename from nodes where id =" + item;
                            nodename.Add(conn.Query<string>(sql, null).FirstOrDefault());
                        }
                    }

                    //将状态信息转换为string类型字符串
                    initiation.Accessory = String.Join(",", nodename);
                    sql = @"update  Initiation set Accessory=:Accessory,State=:State where Id=:Id";
                    result = conn.Execute(sql, initiation);
                    return result;
                }
                //sql = @"update  Initiation set Principal=:Principal where Id=:Id";
                //result = conn.Execute(sql, initiation);
                return result;
            }
        }
        /// <summary>
        /// 驳回调用方法
        /// </summary>
        /// <param name="initiation"></param>
        /// <returns></returns>
        public int ReInitiationApprovals(Initiation initiation)
        {
            using (OracleConnection conn = DapperHelper.GetConnString())
            {
                string sql = string.Empty;
                sql = string.Format("select * from Nodes where id=" + initiation.State);
                var ini = conn.Query<Nodes>(sql, null).FirstOrDefault();
                initiation.Accessory = ini.NodeName + "已驳回";
                sql = @"update  Initiation set Accessory=:Accessory where Id=:Id";
                var result = conn.Execute(sql, initiation);
                return result;
            }
        }
    }
}
