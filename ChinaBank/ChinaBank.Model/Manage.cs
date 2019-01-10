using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChinaBank.Model
{
    /// <summary>
    /// 管理员表
    /// </summary>
   public class Manage
    {
        /// <summary>
        /// 主键
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// 管理员名称
        /// </summary>
        public string ManageName { get; set; }
        /// <summary>
        /// 管理员密码
        /// </summary>
        public string ManagePwd { get; set; }
        /// <summary>
        /// 角色id
        /// </summary>
        [NotMapped]
        public string RoleID { get; set; }
        /// <summary>
        /// 角色名称
        /// </summary>
        [NotMapped]
        public string RoleName { get; set; }
    }
}
