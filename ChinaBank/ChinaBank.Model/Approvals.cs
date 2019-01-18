using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChinaBank.Model
{
    /// <summary>
    /// 审批表
    /// </summary>
    public class Approvals
    {
        /// <summary>
        /// 主键Id
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// 审批名称
        /// </summary>
        public string Name { get; set; }
    }
}
