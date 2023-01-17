using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DormManage.Common;
using DormManage.Model;

namespace DormManage.DAL.StatisticsAnalyse
{
    public class DormitorystatisticsDal
    {
        public List<DormitoryStatisticsDto> GetDormitoriesDto1()
        {
            string sql = $" exec  p_TotalBormitorys ";
            var i = DapperHelper.GetList<DormitoryStatisticsDto>(sql);
            return i;
        }
    }
}
