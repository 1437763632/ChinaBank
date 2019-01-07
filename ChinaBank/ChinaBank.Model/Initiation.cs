using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChinaBank.Model
{
    /// <summary>
    /// 项目立项表
    /// </summary>
    public class Initiation
    {
        /// <summary>
        /// 主键Id
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// 表单头
        /// </summary>
        public string Forms { get; set; }
        /// <summary>
        /// 编码
        /// </summary>
        public string Code { get; set; }
        /// <summary>
        /// 申请人
        /// </summary>
        public string Applicant { get; set; }
        /// <summary>
        /// 项目编号
        /// </summary>
        public string Pid { get; set; }
        /// <summary>
        /// 项目名称
        /// </summary>
        public string Pname { get; set; }
        /// <summary>
        /// 项目类型
        /// </summary>
        public string Ptype { get; set; }
        /// <summary>
        /// 关联需求单号
        /// </summary>
        public string Requisitionid { get; set; }

        /// <summary>
        /// 发起部门
        /// </summary>
        public string Section { get; set; }
        /// <summary>
        /// 业务负责人
        /// </summary>
        public string Principal { get; set; }
        /// <summary>
        /// 项目所属部门
        /// </summary>
        public string Department { get; set; }
        /// <summary>
        /// 实时配合部门
        /// </summary>
        public string Coordinate { get; set; }
        /// <summary>
        /// 是否为提前启动项目
        /// </summary>
        public string Start { get; set; }
        /// <summary>
        /// 收到提前启动指令时间
        /// </summary>

        public string Starttime { get; set; }
        /// <summary>
        /// 提前启动符号
        /// </summary>
        public string Letter { get; set; }
        /// <summary>
        /// 提前启动指令中费用额度
        /// </summary>
        public string Limit { get; set; }
        /// <summary>
        /// 初步拟定软件中心项目经理
        /// </summary>
        public string Pm { get; set; }
        /// <summary>
        /// 项目经理资格
        /// </summary>
        public string Pmqualification { get; set; }
        /// <summary>
        /// 正副标识
        /// </summary>
        public string Identification { get; set; }
        /// <summary>
        /// 任命类型
        /// </summary>

        public string Appointtype { get; set; }

        /// <summary>
        /// 项目工期
        /// </summary>
        public string Pschedule { get; set; }
        /// <summary>
        /// 预算工作量
        /// </summary>
        public string Budget { get; set; }
        /// <summary>
        /// 申请日期
        /// </summary>
        public DateTime Times { get; set; }
        /// <summary>
        /// 是否紧急
        /// </summary>
        public string Urgent { get; set; }
        /// <summary>
        /// 计划管理员
        /// </summary>
        public string Admin { get; set; }
        /// <summary>
        /// 业务师
        /// </summary>

        public string Business { get; set; }
        /// <summary>
        /// 项目组主要成员
        /// </summary>
        public string Pteam { get; set; }
        /// <summary>
        /// 系统工程师
        /// </summary>
        public string Engineer { get; set; }
        /// <summary>
        /// 架构师
        /// </summary>
        public string Architect { get; set; }
        /// <summary>
        /// 测试经理
        /// </summary>
        public string Testmanager { get; set; }
        /// <summary>
        /// 质量工程师
        /// </summary>
        public string Qualityengineer { get; set; }
        /// <summary>
        /// 配置管理员
        /// </summary>

        public string Configurationadmin { get; set; }
        /// <summary>
        /// 测试架构师
        /// </summary>
        public string Testarchitect { get; set; }
        /// <summary>
        /// 财务核算项目编码
        /// </summary>
        public string Financecode { get; set; }
        /// <summary>
        /// 财务核算项目编码维护时间
        /// </summary>
        public string Financetime { get; set; }
        /// <summary>
        /// 附件
        /// </summary>
        public string Accessory { get; set; }
        /// <summary>
        /// 状态
        /// </summary>
        public int State { get; set; }
        /// <summary>
        /// 总行立项编号
        /// </summary>
        public string Projectnum { get; set; }
        /// <summary>
        /// 涉及产品名称
        /// </summary>
        public string Productname { get; set; }
        /// <summary>
        /// 总行业务部门
        /// </summary>
        public string Operating { get; set; }
        /// <summary>
        /// 总行项目经理
        /// </summary>
        public string ZPM { get; set; }
    }
}
