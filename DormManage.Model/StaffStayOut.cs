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
        /// 住宿金额
        /// </summary>
        public int Money { get; set; }

        /// <summary>
        /// 是否签订宿舍安全条约
        /// </summary>
        public bool Treaty { get; set; }

        /// <summary>
        /// 是否开通门禁权限
        /// </summary>
        public bool Access { get; set; }

        /// <summary>
        /// 是否楼长
        /// </summary>
        public bool TowerParent { get; set; }

        /// <summary>
        /// 是否宿舍长
        /// </summary>
        public bool DormParent { get; set; }

        /// <summary>
        /// 入住时间
        /// </summary>
        public DateTime CheckInTime { get; set; }

        /// <summary>
        /// 宿舍id
        /// </summary>
        public int DormitoryId { get; set; }

        /// <summary>
        /// 床位id
        /// </summary>
        public int BunkId { get; set; }

        /// <summary>
        /// 是否入住
        /// </summary>
        public bool IsEnable { get; set; }
    }
}
