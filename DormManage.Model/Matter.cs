using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DormManage.Model
{
    /// <summary>
    /// 奖惩事项
    /// </summary>
    public class Matter
    {
        /// <summary>
        /// 主键id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// 事项信息
        /// </summary>
        public string MatterName { get; set; }

        /// <summary>
        /// 类型
        /// </summary>
        public int TypeId { get; set; }
    }
}
