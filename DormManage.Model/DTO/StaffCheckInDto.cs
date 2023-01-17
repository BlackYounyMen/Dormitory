using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DormManage.Model
{
    /// <summary>
    /// 入住管理Dto
    /// </summary>
    public class StaffCheckInDto:StaffCheckIn
    {
        /// <summary>
        /// 姓名
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 性别
        /// </summary>
        public bool Sex { get; set; }

        /// <summary>
        /// 类型id
        /// </summary>
        public bool TypeId { get; set; }

        /// <summary>
        /// 工号
        /// </summary>
        public string EmpNo { get; set; }

        /// <summary>
        /// 宿舍号
        /// </summary>
        public string DormitoryNo { get; set; }

        /// <summary>
        /// 床位号
        /// </summary>
        public string BunkNo { get; set; }

        /// <summary>
        /// 一级部门名称
        /// </summary>
        public string StairName { get; set; }

        /// <summary>
        /// 二级部门
        /// </summary>
        public int StationId { get; set; }

        /// <summary>
        /// 手机号
        /// </summary>
        public string Mobile { get; set; }

        /// <summary>
        /// 紧急联系人
        /// </summary>
        public string EmergencyName { get; set; }

        /// <summary>
        /// 紧急联系人手机号
        /// </summary>
        public string EmergencyMobile { get; set; }
    }
}
