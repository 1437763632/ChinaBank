using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChinaBank.Model
{
    /// <summary>
    /// 项目问题表
    /// </summary>
    public class Projproblem
    {
        public int Id { get; set; }
        /// <summary>
        /// 问题识别
        /// </summary>
        public string Recognition { get; set; }
        /// <summary>
        /// 编号
        /// </summary>
        public int Serialnumber { get; set; }
        /// <summary>
        /// 提出人
        /// </summary>
        public string Introducer { get; set; }
        /// <summary>
        /// 提出日期
        /// </summary>
        public string Inriqi { get; set; }
        /// <summary>
        /// 识别事件
        /// </summary>
        public int Identification { get; set; }
        /// <summary>
        /// 任务类型
        /// </summary>
        public int Tasktype { get; set; }
        /// <summary>
        /// 任务名称
        /// </summary>
        public string Taskname { get; set; }
        /// <summary>
        /// 任务链接
        /// </summary>
        public string Tasklink { get; set; }
        /// <summary>
        /// 项目名称
        /// </summary>
        public string Projname { get; set; }
        /// <summary>
        /// 识别部门
        /// </summary>
        public string Department { get; set; }
        /// <summary>
        /// 项目经理
        /// </summary>
        public string Projmanager { get; set; }
        /// <summary>
        /// 所属批次
        /// </summary>
        public string Batch { get; set; }
        /// <summary>
        /// 主要成因产品
        /// </summary>
        public string Causes { get; set; }
        /// <summary>
        /// 问题名称
        /// </summary>
        public string Probname { get; set; }
        /// <summary>
        /// 问题描述
        /// </summary>
        public string Probdescription { get; set; }
        /// <summary>
        /// 栏位（分析与解决）
        /// </summary>
        public string Analyze { get; set; }
        /// <summary>
        /// 分析与解决
        /// </summary>
        public string Solve { get; set; }
        /// <summary>
        /// 附件
        /// </summary>
        public string Accessory { get; set; }
        /// <summary>
        /// 问题分类
        /// </summary>
        public int Probtype { get; set; }
        /// <summary>
        /// 技术成因
        /// </summary>
        public int Technology { get; set; }
        /// <summary>
        /// 问题优先级
        /// </summary>
        public string Probpriority { get; set; }
        /// <summary>
        /// 严重程度
        /// </summary>
        public int Severity { get; set; }
        /// <summary>
        /// 问题影响批次
        /// </summary>
        public string Influencebatch { get; set; }
        /// <summary>
        /// 问题所属条线
        /// </summary>
        public int Subordinate { get; set; }
        /// <summary>
        /// 栏位（状态跟踪）
        /// </summary>
        public string Statetail { get; set; }
        /// <summary>
        /// 限期解决日期
        /// </summary>
        public string Deadline { get; set; }
        /// <summary>
        /// 实际解决日期
        /// </summary>
        public string Practical { get; set; }
        /// <summary>
        /// 问题状态
        /// </summary>
        public int Probstate { get; set; }
        /// <summary>
        /// 问题级别
        /// </summary>
        public int Probrank { get; set; }
        /// <summary>
        /// 当前解决部门
        /// </summary>
        public string Currentdepartment { get; set; }
        /// <summary>
        /// 当前解决人
        /// </summary>
        public string Currentperson { get; set; }
        /// <summary>
        /// 辅助解决人
        /// </summary>
        public string Assistperson { get; set; }
        /// <summary>
        /// 跟踪人
        /// </summary>
        public string Followperson { get; set; }
        /// <summary>
        /// 当前部门开始日期
        /// </summary>
        public string Startdate { get; set; }
        /// <summary>
        /// 当前部门持续天数
        /// </summary>
        public string Continuenumber { get; set; }
        /// <summary>
        /// 总持续天数
        /// </summary>
        public string Totalduration { get; set; }
        /// <summary>
        /// 最新更新日期
        /// </summary>
        public string Lastupdate { get; set; }
    }
}
