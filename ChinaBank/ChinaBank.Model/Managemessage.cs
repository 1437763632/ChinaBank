using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChinaBank.Model
{
    /// <summary>
    /// 项目经理信息字段
    /// </summary>
    public class Managemessage
    {
        public int Id { get; set; }
        /// <summary>
        /// 项目编号
        /// </summary>
        public int Itemnumber { get; set; }
        /// <summary>
        /// 项目经理
        /// </summary>
        public string Projectmanager { get; set; }
        /// <summary>
        /// 项目经理资格
        /// </summary>
        public string Qualification { get; set; }
        /// <summary>
        /// 正副标识
        /// </summary>
        public string Identify { get; set; }
        /// <summary>
        /// 任命类型
        /// </summary>
        public string Appointment { get; set; }
        /// <summary>
        /// 立项拟定
        /// </summary>
        public string Projectplan { get; set; }
        /// <summary>
        /// 任命情况
        /// </summary>
        public string Situation { get; set; }
        /// <summary>
        /// 任命日期
        /// </summary>
        public string Appointmentdate { get; set; }
    }
}
