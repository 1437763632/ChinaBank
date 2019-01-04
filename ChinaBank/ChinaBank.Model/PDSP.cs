using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChinaBank.Model
{
    /// <summary>
    /// 项目结项表
    /// </summary>
    public class PDSP
    {
        /// <summary>
        /// 主键Id
        /// </summary>
        public int id { get; set; }
        /// <summary>
        /// 表单头
        /// </summary>
        public string forms { get; set; }
        /// <summary>
        /// 项目编号
        /// </summary>
        public string pid { get; set; }
        /// <summary>
        /// 项目名称
        /// </summary>
        public string pname { get; set; }
        /// <summary>
        /// 申请人
        /// </summary>
        public string applicant { get; set; }
        /// <summary>
        /// 总行项目经理
        /// </summary>
        public string pmheadoffice { get; set; }
        /// <summary>
        /// 创建日期
        /// </summary>
        public DateTime createtime { get; set; }
        /// <summary>
        /// 所属部门
        /// </summary>
        public string department { get; set; }
        /// <summary>
        /// 结束日期
        /// </summary>
        public DateTime finishtime { get; set; }
        /// <summary>
        /// 生效日期
        /// </summary>
        public string takeeffecttime { get; set; }
        /// <summary>
        /// 结项性质
        /// </summary>
        public string Postprojectnature { get; set; }
        /// <summary>
        /// 中心项目经理
        /// </summary>
        public string Centerprojectpm { get; set; }
        /// <summary>
        /// 项目副经理
        /// </summary>
        public string dpm { get; set; }
        /// <summary>
        /// 项目结项报告
        /// </summary>
        public string Projectreport { get; set; }
        /// <summary>
        /// 成果评测会
        /// </summary>
        public string Resultsevaluation { get; set; }
        /// <summary>
        /// 项目干系人
        /// </summary>
        public string stakeholder { get; set; }
        /// <summary>
        /// 问题编号
        /// </summary>
        public string questionid { get; set; }
        /// <summary>
        /// 问题描述
        /// </summary>
        public string questionName { get; set; }
        /// <summary>
        /// 是否修改
        /// </summary>
        public string ismodify { get; set; }
        /// <summary>
        /// 提出人
        /// </summary>
        public string introducer { get; set; }
        /// <summary>
        /// 是否通过
        /// </summary>
        public string passed { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        public string remarks { get; set; }
        /// <summary>
        /// 审核结论
        /// </summary>
        public string auditconclusion { get; set; }
        /// <summary>
        /// 遗留事项
        /// </summary>
        public string Legacymatters { get; set; }
        /// <summary>
        /// 其他事宜
        /// </summary>
        public string othermatters { get; set; }
        /// <summary>
        /// 相关干系人签名
        /// </summary>
        public string signature { get; set; }
        /// <summary>
        /// 实施牵头部门
        /// </summary>
        public string Implementation { get; set; }
        /// <summary>
        /// 项目管理部
        /// </summary>
        public string itemopinion { get; set; }
        /// <summary>
        /// 工程管理部
        /// </summary>
        public string projectopinion { get; set; }
        /// <summary>
        /// 资源管理部
        /// </summary>
        public string resourceadmin { get; set; }
        /// <summary>
        /// 财务管理部
        /// </summary>
        public string financialadmin { get; set; }
        /// <summary>
        /// 所属部门意见
        /// </summary>
        public string departmentopinion { get; set; }
        /// <summary>
        /// 总经理室
        /// </summary>
        public string executiveoffice { get; set; }
    }
}
