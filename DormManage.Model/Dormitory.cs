using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DormManage.Model
{
    /// <summary>
    /// 宿舍表
    /// </summary>
    public class Dormitory
    {
        /// <summary>
        /// 主键id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// 宿舍号
        /// </summary>
        public string DormitoryNo { get; set; }

        /// <summary>
        /// 是否男女宿舍
        /// </summary>
        public string DormitoryType { get; set; }

        /// <summary>
        /// 是否启用
        /// </summary>
        public bool IsEnable { get; set; }
    }
}
