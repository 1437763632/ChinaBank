using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChinaBank.Model
{
    /// <summary>
    /// 审批节点表
    /// </summary>
    public class Nodes
    {
        /// <summary>
        /// 主键Id
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// 审批节点名称
        /// </summary>
        public string NodeName { get; set; }
        /// <summary>
        /// 负责部门
        /// </summary>
        public int DepartmentId { get; set; }
    }
}
