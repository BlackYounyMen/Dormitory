using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DormManage.Model
{
    /// <summary>
    /// 二级部门Dto
    /// </summary>
    public class StationDto:Station
    {
        /// <summary>
        /// 部门名称
        /// </summary>
        public string StairName { get; set; }
    }
}
