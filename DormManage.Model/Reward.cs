using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DormManage.Model
{
    /// <summary>
    /// 奖励详情表
    /// </summary>
    public class Reward
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
        /// 奖励事项
        /// </summary>
        public string Matter { get; set; }

        /// <summary>
        /// 奖励依据
        /// </summary>
        public string Pursuant { get; set; }

        /// <summary>
        /// 奖励金额
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
