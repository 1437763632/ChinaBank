using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChinaBank.Model
{
    /// <summary>
    /// 分页
    /// </summary>
    public class PageBox
    {
        /// <summary>
        /// 当前页
        /// </summary>
        public int CurrentPage { get; set; }
        /// <summary>
        /// 总页数
        /// </summary>
        public int TotlePage { get; set; }
        /// <summary>
        /// 分页数据
        /// </summary>
        public object PageData { get; set; }
    }
}
