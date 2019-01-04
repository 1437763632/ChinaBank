using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChinaBank.Model
{
    /// <summary>
    /// 管理员角色关系表
    /// </summary>
   public class ManageAndRole
    {
        /// <summary>
        /// 主键
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// 角色id
        /// </summary>
        public int RoleId { get; set; }
        /// <summary>
        /// 管理员ID
        /// </summary>
        public int ManageId { get; set; }
    }
}
