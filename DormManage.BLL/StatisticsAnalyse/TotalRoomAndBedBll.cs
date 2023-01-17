using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DormManage.DAL.StatisticsAnalyse;
using DormManage.Model;

namespace DormManage.BLL.StatisticsAnalyse
{
    public class TotalRoomAndBedBll
    {
        TotalRoomAndBedDal totalRoomAndBedDal = new TotalRoomAndBedDal();
        /// <summary>
        /// 综合查询页面的汇总信息
        /// </summary>
        /// <returns></returns>
        public TotalRoomDto totalRoomDTO()
        {
            var i = totalRoomAndBedDal.totalRoomDTO();
            return i;
        }
        /// <summary>
        ///    查询房间、住宿明细
        /// </summary>
        /// <returns></returns>
        public List<DormitoryDetailDTO> DormitoryDetailDTOs()
        {
            var i = totalRoomAndBedDal.DormitoryDetailDTOs();
            return i;
        }
    }
}
