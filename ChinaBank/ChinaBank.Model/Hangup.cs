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
        public int id { get; set; }
        /// <summary>
        /// 表单头
        /// </summary>
        public string forms { get; set; }
        /// <summary>
        /// 编码
        /// </summary>
        public string documentcode { get; set; }
        /// <summary>
        /// 申请人
        /// </summary>
        public string applicant { get; set; }
        /// <summary>
        /// 项目名称
        /// </summary>
        public string pname { get; set; }
        /// <summary>
        /// 项目编码
        /// </summary>
        public string pcode { get; set; }
        /// <summary>
        /// 创建日期
        /// </summary>
        public DateTime createtime { get; set; }
        /// <summary>
        /// 挂起日期
        /// </summary>
        public string hanguptime { get; set; }
        /// <summary>
        /// 项目经理
        /// </summary>
        public string pm { get; set; }
        /// <summary>
        /// 所属部门
        /// </summary>
        public string department { get; set; }
        /// <summary>
        /// 项目副经理
        /// </summary>
        public string dpm { get; set; }
        /// <summary>
        /// 项目状态
        /// </summary>
        public string state { get; set; }
        /// <summary>
        /// 项目进度状态
        /// </summary>
        public string schedule { get; set; }
        /// <summary>
        /// 附件
        /// </summary>
        public string accessory { get; set; }
        /// <summary>
        /// 挂起原因
        /// </summary>
        public string Hangupcause { get; set; }
        /// <summary>
        /// PMO意见
        /// </summary>
        public string pmoopinion { get; set; }
        /// <summary>
        /// 所属部门意见
        /// </summary>
        public string departmentopinion { get; set; }
        /// <summary>
        /// 工程管理部意见
        /// </summary>
        public string projectopinion { get; set; }
        /// <summary>
        /// 项目管理部意见
        /// </summary>
        public string itemopinion { get; set; }
        /// <summary>
        /// 总经理意见
        /// </summary>
        public string gmopinion { get; set; }
        /// <summary>
        /// 处理步骤
        /// </summary>
        public string processingstep { get; set; }
        /// <summary>
        /// 处理人
        /// </summary>
        public string handler { get; set; }
    }
}
