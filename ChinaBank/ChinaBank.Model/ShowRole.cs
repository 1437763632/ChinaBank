using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChinaBank.Model
{
    /// <summary>
    /// 角色显示虚拟表
    /// </summary>
   public class ShowRole
    {
        /// <summary>
        /// 主键
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// 角色名称
        /// </summary>
        public string RoleName { get; set; }
        /// <summary>
        /// 权限id
        /// </summary>
        public int PermissionId { get; set; }
        /// <summary>
        /// 权限名称
        /// </summary>
        public string PermissionName { get; set; }
    }
}
