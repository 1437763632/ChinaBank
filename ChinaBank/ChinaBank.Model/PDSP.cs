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
        public int Id { get; set; }
        /// <summary>
        /// 表单头
        /// </summary>
        public string Forms { get; set; }
        /// <summary>
        /// 项目编号
        /// </summary>
        public string Pid { get; set; }
        /// <summary>
        /// 项目名称
        /// </summary>
        public string Pname { get; set; }
        /// <summary>
        /// 申请人
        /// </summary>
        public string Applicant { get; set; }
        /// <summary>
        /// 总行项目经理
        /// </summary>
        public string Pmheadoffice { get; set; }
        /// <summary>
        /// 创建日期
        /// </summary>
        public DateTime Createtime { get; set; }
        /// <summary>
        /// 所属部门
        /// </summary>
        public string Department { get; set; }
        /// <summary>
        /// 结束日期
        /// </summary>
        public DateTime? Finishtime { get; set; }
        /// <summary>
        /// 生效日期
        /// </summary>
        public DateTime? Takeeffecttime { get; set; }
        /// <summary>
        /// 结项性质
        /// </summary>
        public string Postprojectnature { get; set; }
        /// <summary>
        /// 中心项目经理
        /// </summary>
        public string Centerprojectpm { get; set; }
        
        /// <summary>
        /// 成果评测会
        /// </summary>
        public string Resultsevaluation { get; set; }
        /// <summary>
        /// 项目干系人
        /// </summary>
        public string Stakeholder { get; set; }
        /// <summary>
        /// 问题编号
        /// </summary>
        public string Questionid { get; set; }
        /// <summary>
        /// 问题描述
        /// </summary>
        public string QuestionName { get; set; }
        /// <summary>
        /// 是否修改
        /// </summary>
        public string Ismodify { get; set; }
        /// <summary>
        /// 提出人
        /// </summary>
        public string Introducer { get; set; }
        /// <summary>
        /// 是否通过
        /// </summary>
        public string Passed { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        public string Remarks { get; set; }
        /// <summary>
        /// 审核结论
        /// </summary>
        public string Auditconclusion { get; set; }
        /// <summary>
        /// 遗留事项
        /// </summary>
        public string Legacymatters { get; set; }
        /// <summary>
        /// 其他事宜
        /// </summary>
        public string Othermatters { get; set; }
        /// <summary>
        /// 相关干系人签名
        /// </summary>
        public string Signature { get; set; }
        /// <summary>
        /// 实施牵头部门
        /// </summary>
        public string Implementation { get; set; }
        /// <summary>
        /// 项目管理部
        /// </summary>
        public string Itemopinion { get; set; }
        /// <summary>
        /// 工程管理部
        /// </summary>
        public string Projectopinion { get; set; }
        /// <summary>
        /// 资源管理部
        /// </summary>
        public string Resourceadmin { get; set; }
        /// <summary>
        /// 财务管理部
        /// </summary>
        public string Financialadmin { get; set; }
        /// <summary>
        /// 所属部门意见
        /// </summary>
        public string Departmentopinion { get; set; }
        /// <summary>
        /// 总经理室
        /// </summary>
        public string Executiveoffice { get; set; }
        /// <summary>
        /// 状态
        /// </summary>
        public int Projstateid { get; set; }
    }
}
