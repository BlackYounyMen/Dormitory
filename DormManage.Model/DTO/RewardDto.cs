using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DormManage.Model
{
    public class RewardDto:Reward
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
        /// 工号
        /// </summary>
        public string EmpNo { get; set; }

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
