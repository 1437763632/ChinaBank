using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChinaBank.Model
{
    /// <summary>
    /// 审批配置表
    /// </summary>
    public class Configs
    {
        /// <summary>
        /// 主键Id
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// 审批Id
        /// </summary>
        public int ApprovalsId { get; set; }
        /// <summary>
        /// 节点Ids
        /// </summary>
        public string NodesId { get; set; }
    }
}
