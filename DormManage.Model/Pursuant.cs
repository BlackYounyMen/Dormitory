using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DormManage.Model
{
    /// <summary>
    /// 奖惩依据
    /// </summary>
    public class Pursuant
    {
        /// <summary>
        /// 主键id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// 依据信息
        /// </summary>
        public string PursuantName { get; set; }

        /// <summary>
        /// 类型
        /// </summary>
        public int TypeId { get; set; }
    }
}
