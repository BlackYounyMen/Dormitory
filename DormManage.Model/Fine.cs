using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DormManage.Model
{
    /// <summary>
    /// 处罚详情表
    /// </summary>
    public class Fine
    {
        /// <summary>
        /// 主键id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// 员工id
        /// </summary>
        public int StaffId { get; set; }

        /// <summary>
        /// 事项
        /// </summary>
        public string Matter { get; set; }

        /// <summary>
        /// 依据
        /// </summary>
        public string Pursuant { get; set; }

        /// <summary>
        /// 处罚金额
        /// </summary>
        public int Money { get; set; }

        /// <summary>
        /// 添加时间
        /// </summary>
        public DateTime AddTime { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public string Remark { get; set; }
    }
}
