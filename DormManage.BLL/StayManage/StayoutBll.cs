using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DormManage.DAL.StayManage;
using DormManage.Model;

namespace DormManage.BLL.StayManage
{
    public class StayoutBll
    {
        StayoutDal stayoutdal = new StayoutDal();
        /// <summary>
        /// 退宿扣款显示 查询
        /// </summary>
        /// <param name="startDate">开始时间</param>
        /// <param name="endDate">结束时间</param>
        /// <returns></returns>
        public PageResultDto<StaffStaffStayOutDto> GetStaffStaffStayOutDto(string startDate, string endDate, int PageIndex, int PageSize)
        {
            PageResultDto<StaffStaffStayOutDto> staffstaffstayoutdto = stayoutdal.GetStaffStaffStayOutDto(startDate, endDate, PageIndex, PageSize);
            return staffstaffstayoutdto;
        }

        /// <summary>
        /// 退宿扣款显示查询 导出时使用方法
        /// </summary>
        /// <param name="checkintime">开始时间</param>
        /// <param name="stayouttime">结束时间</param>
        /// <returns></returns>
        public List<StaffStaffStayOutDto> GetStaffStaffStayOutList(string starttime, string finishtime)
        {
            List<StaffStaffStayOutDto> staffstaffStayout = stayoutdal.GetStaffStaffStayOutList(starttime, finishtime);
            return staffstaffStayout;
        }
    }
}
