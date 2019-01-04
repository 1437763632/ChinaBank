using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChinaBank.Model
{
    /// <summary>
    /// 项目干系人变更表
    /// </summary>
    public class Stackeholder
    {
        public int Id { get; set; }
        /// <summary>
        /// 功能名称
        /// </summary>
        public string Functionname { get; set; }
        /// <summary>
        /// 项目角色
        /// </summary>
        public string Projrole { get; set; }
        /// <summary>
        /// 姓名
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 勾选字段
        /// </summary>
        public string Checkfield { get; set; }
        /// <summary>
        /// 角色
        /// </summary>
        public string Role { get; set; }
        /// <summary>
        /// 部门
        /// </summary>
        public string Department { get; set; }
    }
}
