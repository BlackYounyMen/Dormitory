using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DormManage.Model
{
    /// <summary>
    /// 员工基础信息Dto
    /// </summary>
    public class StaffDto:Staff
    {
        /// <summary>
        /// 一级部门名称
        /// </summary>
        public string StairName { get; set; }

        /// <summary>
        /// 二级部门名称
        /// </summary>
        public string SecondName { get; set; }
    }
}
