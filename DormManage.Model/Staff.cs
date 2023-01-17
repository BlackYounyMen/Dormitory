using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DormManage.Model
{
    /// <summary>
    /// 员工基础信息表
    /// </summary>
    public class Staff
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
        /// 一级部门
        /// </summary>
        public int DepartmentId { get; set; }

        /// <summary>
        /// 二级部门
        /// </summary>
        public int StationId { get; set; }

        /// <summary>
        /// 是否提供身份证
        /// </summary>
        public bool IDCard { get; set; }

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

        /// <summary>
        /// 入职日期
        /// </summary>
        public DateTime EntryTime { get; set; }

        /// <summary>
        /// 居住证办理情况
        /// </summary>
        public int IsResidence { get; set; }

        /// <summary>
        /// 是否启用
        /// </summary>
        public bool IsEnable { get; set; }
    }
}
