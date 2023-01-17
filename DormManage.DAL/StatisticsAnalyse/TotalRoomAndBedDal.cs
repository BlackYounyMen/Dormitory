using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DormManage.Common;
using DormManage.Model;

namespace DormManage.DAL.StatisticsAnalyse
{
    public class TotalRoomAndBedDal
    {
        /// <summary>
        /// 综合查询页面的汇总信息
        /// </summary>
        /// <returns></returns>
        public TotalRoomDto totalRoomDTO()
        {
            string sql = $" exec p_totalRoom ";
            var i = DapperHelper.GetList<TotalRoomDto>(sql).FirstOrDefault();
            return i;
        }
        /// <summary>
        ///    查询房间、住宿明细
        /// </summary>
        /// <returns></returns>
        public List<DormitoryDetailDTO> DormitoryDetailDTOs()
        {
            string sql = $" select* from DormitoryDetail ";
            var i = DapperHelper.GetList<DormitoryDetailDTO>(sql);
            return i;
        }
    }
}
