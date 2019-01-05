using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChinaBank.Model
{
    /// <summary>
    /// 封装查询条件相关信息的类
    /// </summary>
    public class PageCriteria
    {
        public string TableName { get; set; }

        public string Sort { get; set; }

        public string Condition { get; set; }

        public int RecordCount { get; set; }

        public string Fields { get; set; }

        public string PrimaryKey { get; set; }

        public int PageSize { get; set; }

        public int CurrentPage { get; set; }
        public PageCriteria()
        {
            Sort = "";
            Condition = "";
            RecordCount = 0;
            Fields = "*";
            PrimaryKey = "ID";
            PageSize = 10;
            CurrentPage = 1;
        }
    }
}