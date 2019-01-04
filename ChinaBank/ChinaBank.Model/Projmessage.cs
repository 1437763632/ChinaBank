using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChinaBank.Model
{
    /// <summary>
    /// 项目信息表
    /// </summary>
    public class Projmessage
    {
        public int Id { get; set; }
        /// <summary>
        /// 表单头
        /// </summary>
        public string Formfirst { get; set; }
        /// <summary>
        /// 项目名称
        /// </summary>
        public string Projname { get; set; }
        /// <summary>
        /// 项目编码
        /// </summary>
        public string Projcoding { get; set; }
        /// <summary>
        /// 财务核算项目编码维护时间
        /// </summary>
        public string Maintaindate { get; set; }
        /// <summary>
        /// 财务核算项目编码
        /// </summary>
        public string Accounting { get; set; }
        /// <summary>
        /// 总行立项时间
        /// </summary>
        public string Approvaldate { get; set; }
        /// <summary>
        /// 总行立项编号
        /// </summary>
        public string Approvalnum { get; set; }
        /// <summary>
        /// 项目类别
        /// </summary>
        public string Projcategory { get; set; }
        /// <summary>
        /// 项目类型
        /// </summary>
        public string Projtype { get; set; }
        /// <summary>
        /// 总行业务部门
        /// </summary>
        public string Business { get; set; }
        /// <summary>
        /// 所属业务团队
        /// </summary>
        public string Businessteam { get; set; }
        /// <summary>
        /// 项目所属部门
        /// </summary>
        public string Department { get; set; }
        /// <summary>
        /// 主产品团队
        /// </summary>
        public string Problemteam { get; set; }
        /// <summary>
        /// 合作公司
        /// </summary>
        public string Cooperation { get; set; }
        /// <summary>
        /// 是否Wie提前启动项目
        /// </summary>
        public string Isstart { get; set; }
        /// <summary>
        /// 收到提前启动指令时间
        /// </summary>
        public string Isstartdate { get; set; }
        /// <summary>
        /// 提前启动函号
        /// </summary>
        public string Letter { get; set; }
        /// <summary>
        /// 提前启动指令中费用额度
        /// </summary>
        public int Limit { get; set; }
        /// <summary>
        /// 是否紧急项目
        /// </summary>
        public string Isurgency { get; set; }
        /// <summary>
        /// 是否敏捷项目
        /// </summary>
        public string Isagility { get; set; }
        /// <summary>
        /// 建立日期
        /// </summary>
        public DateTime Creationdate { get; set; }
        /// <summary>
        /// 立项日期
        /// </summary>
        public DateTime Projdate { get; set; }
        /// <summary>
        /// 项目状态
        /// </summary>
        public string Projstate { get; set; }
        /// <summary>
        /// 所属阶段
        /// </summary>
        public string Sbstage { get; set; }
        /// <summary>
        /// 项目进度状态
        /// </summary>
        public string Schedutestate { get; set; }
        /// <summary>
        /// 结项性质
        /// </summary>
        public string Nature { get; set; }
        /// <summary>
        /// 结项日期总行项目经理
        /// </summary>
        public string Headoffice { get; set; }
        /// <summary>
        /// 业务负责人
        /// </summary>
        public string Businessleader { get; set; }
        /// <summary>
        /// 前期项目管理人员
        /// </summary>
        public string Managerperson { get; set; }
        /// <summary>
        /// 练习电话（项目立项获取）
        /// </summary>
        public string Phone { get; set; }
        /// <summary>
        /// 项目经理资格
        /// </summary>
        public string Qualification { get; set; }
        /// <summary>
        /// 正副标识
        /// </summary>
        public string Zhengfu { get; set; }
        /// <summary>
        /// 任命类型
        /// </summary>
        public string Appointtype { get; set; }
        /// <summary>
        /// 软件中心项目经理
        /// </summary>
        public string Centremanager { get; set; }
        /// <summary>
        /// 联系电话（项目经理任命审批获取）
        /// </summary>
        public string Contactnumber { get; set; }
        /// <summary>
        /// 项目经理资格（项目经理任命审批）
        /// </summary>
        public string Qualifications { get; set; }
        /// <summary>
        /// 正副标识（项目经理任命审批获取）
        /// </summary>
        public string Andidentify { get; set; }
        /// <summary>
        /// 任命类型（项目经理审批获取）
        /// </summary>
        public string Appointmenttype { get; set; }
        /// <summary>
        /// 架构师
        /// </summary>
        public string Architect { get; set; }
        /// <summary>
        /// 业务师
        /// </summary>
        public string Parlor { get; set; }
        /// <summary>
        /// 计划管理员
        /// </summary>
        public string Programmanager { get; set; }
        /// <summary>
        /// 测试架构师
        /// </summary>
        public string Testarchitect { get; set; }
        /// <summary>
        /// 测试经理
        /// </summary>
        public string Testmanager { get; set; }
        /// <summary>
        /// 质量工程师
        /// </summary>
        public string Qualityengineer { get; set; }
        /// <summary>
        /// 系统工程师
        /// </summary>
        public string Systemsengineer { get; set; }
        /// <summary>
        /// 配置管理员
        /// </summary>
        public string Configurationadministrator { get; set; }
        /// <summary>
        /// 版本管理员
        /// </summary>
        public string Versionmanager { get; set; }
        /// <summary>
        /// 项目组主要成员
        /// </summary>
        public string Projteam { get; set; }
        /// <summary>
        /// 问题与风险（待设计）
        /// </summary>
        public string Problem { get; set; }
    }
}
