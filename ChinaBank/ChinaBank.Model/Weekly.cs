using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChinaBank.Model
{
    /// <summary>
    /// 项目周报表
    /// </summary>
    public class Weekly
    {
        public int Id { get; set; }
        /// <summary>
        /// 表单头
        /// </summary>
        public string Formfirst { get; set; }
        /// <summary>
        /// 项目名称
        /// </summary>
        public string Projectname { get; set; }
        /// <summary>
        /// 所属部门
        /// </summary>
        public string Affiliated { get; set; }
        /// <summary>
        /// 项目经理
        /// </summary>
        public string Projmanager { get; set; }
        /// <summary>
        /// 建单人
        /// </summary>
        public string Single { get; set; }
        /// <summary>
        /// 建立日期
        /// </summary>
        public string Creadate { get; set; }
        /// <summary>
        /// 本周时段
        /// </summary>
        public string Weektime { get; set; }
        /// <summary>
        /// 所属批次1
        /// </summary>
        public string Batchone { get; set; }
        /// <summary>
        /// 当前阶段
        /// </summary>
        public int Currentgeneration { get; set; }
        /// <summary>
        /// 所属批次（同1）
        /// </summary>
        public string Batchtong { get; set; }
        /// <summary>
        /// 项目进度状态
        /// </summary>
        public string Projectstatus { get; set; }
        /// <summary>
        /// 本周进展
        /// </summary>
        public string Weekproj { get; set; }
        /// <summary>
        /// 下周计划
        /// </summary>
        public string Nextweekproj { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        public string Remark { get; set; }
        /// <summary>
        /// 通知对象
        /// </summary>
        public string Notifyobj { get; set; }
    }
}
