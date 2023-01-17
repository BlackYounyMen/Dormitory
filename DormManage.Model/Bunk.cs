using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DormManage.Model
{
    /// <summary>
    /// 床位表
    /// </summary>
    public class Bunk
    {
        /// <summary>
        /// 主键id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// 床位号
        /// </summary>
        public string BunkNo { get; set; }

        /// <summary>
        /// 宿舍号
        /// </summary>
        public int DormitoryId { get; set; }

        /// <summary>
        /// 是否启用
        /// </summary>
        public bool IsEnable { get; set; }
    }
}
