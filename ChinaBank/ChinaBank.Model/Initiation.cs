using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChinaBank.Model
{
    /// <summary>
    /// 项目立项表
    /// </summary>
    public class Initiation
    {
        /// <summary>
        /// 主键Id
        /// </summary>
        public int id { get; set; }
        /// <summary>
        /// 表单头
        /// </summary>
        public string forms { get; set; }
        /// <summary>
        /// 编码
        /// </summary>
        public string code { get; set; }
        /// <summary>
        /// 申请人
        /// </summary>
        public string applicant { get; set; }
        /// <summary>
        /// 项目编号
        /// </summary>
        public string pid { get; set; }
        /// <summary>
        /// 项目名称
        /// </summary>
        public string pname { get; set; }
        /// <summary>
        /// 项目类型
        /// </summary>
        public string ptype { get; set; }
        /// <summary>
        /// 关联需求单号
        /// </summary>
        public string requisitionid { get; set; }
        /// <summary>
        /// 发起部门
        /// </summary>
        public string section { get; set; }
        /// <summary>
        /// 业务负责人
        /// </summary>
        public string principal { get; set; }
        /// <summary>
        /// 项目所属部门
        /// </summary>
        public string department { get; set; }
        /// <summary>
        /// 实时配合部门
        /// </summary>
        public string coordinate { get; set; }
        /// <summary>
        /// 是否为提前启动项目
        /// </summary>
        public string start { get; set; }
        /// <summary>
        /// 收到提前启动指令时间
        /// </summary>

        public string starttime { get; set; }
        /// <summary>
        /// 提前启动符号
        /// </summary>
        public string letter { get; set; }
        /// <summary>
        /// 提前启动指令中费用额度
        /// </summary>
        public string limit { get; set; }
        /// <summary>
        /// 初步拟定软件中心项目经理
        /// </summary>
        public string pm { get; set; }
        /// <summary>
        /// 项目经理资格
        /// </summary>
        public string pmqualification { get; set; }
        /// <summary>
        /// 正副标识
        /// </summary>
        public string identification { get; set; }
        /// <summary>
        /// 任命类型
        /// </summary>

        public string appointtype { get; set; }

        /// <summary>
        /// 项目工期
        /// </summary>
        public string pschedule { get; set; }
        /// <summary>
        /// 预算工作量
        /// </summary>
        public string budget { get; set; }
        /// <summary>
        /// 申请日期
        /// </summary>
        public string times { get; set; }
        /// <summary>
        /// 是否紧急
        /// </summary>
        public string urgent { get; set; }
        /// <summary>
        /// 计划管理员
        /// </summary>
        public string admin { get; set; }
        /// <summary>
        /// 业务师
        /// </summary>

        public string business { get; set; }
        /// <summary>
        /// 项目组主要成员
        /// </summary>
        public string pteam { get; set; }
        /// <summary>
        /// 系统工程师
        /// </summary>
        public string engineer { get; set; }
        /// <summary>
        /// 架构师
        /// </summary>
        public string architect { get; set; }
        /// <summary>
        /// 测试经理
        /// </summary>
        public string testmanager { get; set; }
        /// <summary>
        /// 质量工程师
        /// </summary>
        public string qualityengineer { get; set; }
        /// <summary>
        /// 配置管理员
        /// </summary>

        public string configurationadmin { get; set; }
        /// <summary>
        /// 测试架构师
        /// </summary>
        public string testarchitect { get; set; }
        /// <summary>
        /// 财务核算项目编码
        /// </summary>
        public string financecode { get; set; }
        /// <summary>
        /// 财务核算项目编码维护时间
        /// </summary>
        public string financetime { get; set; }
        /// <summary>
        /// 附件
        /// </summary>
        public string accessory { get; set; }
    }
}
