using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DormManage.Model
{
    /// <summary>
    /// 员工退宿表
    /// </summary>
    public class StaffStayOut
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
        /// 入住id
        /// </summary>
        public int CheckInId { get; set; }

        /// <summary>
        /// 退宿时间
        /// </summary>
        public string StayOutTime { get; set; }

        /// <summary>
        /// 扣款金额
        /// </summary>
        public int Deduction { get; set; }
    }
}
