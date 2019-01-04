using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChinaBank.Model
{
    /// <summary>
    /// 挂起表
    /// </summary>
    public class Hangup
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
        public string Documentcode { get; set; }
        /// <summary>
        /// 申请人
        /// </summary>
        public string Applicant { get; set; }
        /// <summary>
        /// 项目名称
        /// </summary>
        public string Pname { get; set; }
        /// <summary>
        /// 项目编码
        /// </summary>
        public string Pcode { get; set; }
        /// <summary>
        /// 创建日期
        /// </summary>
        public DateTime Createtime { get; set; }
        /// <summary>
        /// 挂起日期
        /// </summary>
        public string Hanguptime { get; set; }
        /// <summary>
        /// 项目经理
        /// </summary>
        public string Pm { get; set; }
        /// <summary>
        /// 所属部门
        /// </summary>
        public string Department { get; set; }
        /// <summary>
        /// 项目副经理
        /// </summary>
        public string Dpm { get; set; }
        /// <summary>
        /// 项目状态
        /// </summary>
        public string State { get; set; }
        /// <summary>
        /// 项目进度状态
        /// </summary>
        public string Schedule { get; set; }
        /// <summary>
        /// 附件
        /// </summary>
        public string Accessory { get; set; }
        /// <summary>
        /// 挂起原因
        /// </summary>
        public string Hangupcause { get; set; }
        /// <summary>
        /// PMO意见
        /// </summary>
        public string Pmoopinion { get; set; }
        /// <summary>
        /// 所属部门意见
        /// </summary>
        public string Departmentopinion { get; set; }
        /// <summary>
        /// 工程管理部意见
        /// </summary>
        public string Projectopinion { get; set; }
        /// <summary>
        /// 项目管理部意见
        /// </summary>
        public string Itemopinion { get; set; }
        /// <summary>
        /// 总经理意见
        /// </summary>
        public string Gmopinion { get; set; }
        /// <summary>
        /// 处理步骤
        /// </summary>
        public string Processingstep { get; set; }
        /// <summary>
        /// 处理人
        /// </summary>
        public string Handler { get; set; }
    }
}
