using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DormManage.Model
{
    /// <summary>
    /// 分页公共类
    /// </summary>
    public class PageResultDto<T>
    {
        /// <summary>
        /// 总条数
        /// </summary>
        public int ItemCount { get; set; }

        /// <summary>
        /// 数据
        /// </summary>
        public List<T> Items { get; set; }
    }
}
