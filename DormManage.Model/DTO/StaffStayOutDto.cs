using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DormManage.Model
{
    public class StaffStayOutDto : Staff
    {
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
        public DateTime StayOutTime { get; set; }

        /// <summary>
        /// 扣款金额
        /// </summary>
        public int Deduction { get; set; }

        //入住表下字段

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

        //宿舍表

        /// <summary>
        /// 宿舍号
        /// </summary>
        public string DormitoryNo { get; set; }

        //床位表

        /// <summary>
        /// 床位号
        /// </summary>
        public string BunkNo { get; set; }

        //一级部门表

        /// <summary>
        /// 部门名称
        /// </summary>
        public string StairName { get; set; }

        //二级部门表

        /// <summary>
        /// 部门名称
        /// </summary>
        public string SecondName { get; set; }
    }
}