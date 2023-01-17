using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DormManage.Model;
using DormManage.DAL.StatisticsAnalyse;

namespace DormManage.BLL.StatisticsAnalyse
{
    public class DormitorystatisticsBll
    {
        DormitorystatisticsDal dormitorystatisticsDal = new DormitorystatisticsDal();

        public List<DormitoryStatisticsDto> GetDormitoriesDto1()
        {
            var i = dormitorystatisticsDal.GetDormitoriesDto1();
            return i;
        }
    }
}
