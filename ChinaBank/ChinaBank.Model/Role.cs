using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChinaBank.Model
{
    using System.ComponentModel.DataAnnotations.Schema;
    /// <summary>
    /// 角色表
    /// </summary>
   public class Role
    {
        /// <summary>
        /// 主键
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// 角色名称
        /// </summary>
        public string  RoleName { get; set; }
        /// <summary>
        /// 权限ID
        /// </summary>
        [NotMapped]
        public string RightID { get; set; }
    }
}
