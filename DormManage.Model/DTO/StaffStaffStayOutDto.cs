using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DormManage.Model
{
    public class StaffStaffStayOutDto
    {
        /// <summary>
        /// 主键id
        /// </summary>
        public int Id { get; set; }

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
        /// 入职日期
        /// </summary>
        public DateTime EntryTime { get; set; }
        /// <summary>
        /// 一级部门名称
        /// </summary>
        public string StairName { get; set; }
        /// <summary>
        /// 二级部门名称
        /// </summary>
        public string SecondName { get; set; }
        /// <summary>
        /// 入住时间
        /// </summary>
        public DateTime CheckInTime { get; set; }
        /// <summary>
        /// 退宿时间
        /// </summary>
        public DateTime StayOutTime { get; set; }
        /// <summary>
        /// 住宿金额
        /// </summary>
        public int Money { get; set; }
        /// <summary>
        /// 扣款金额
        /// </summary>
        public int Deduction { get; set; }
    }
}
