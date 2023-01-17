using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DormManage.Model;
using DormManage.Common;

namespace DormManage.DAL.StayManage
{
    public class StayoutDal
    {
        /// <summary>
        /// 退宿扣款显示 查询
        /// </summary>
        /// <param name="startDate">开始时间</param>
        /// <param name="endDate">结束时间</param>
        /// <returns></returns>
        public PageResultDto<StaffStaffStayOutDto> GetStaffStaffStayOutDto(string startDate, string endDate, int PageIndex, int PageSize)
        {
            string cmdText = "select ROW_NUMBER() over(order by t1.Id) as rowId,t1.Id,t1.Name,t1.Sex,t1.TypeId,t1.EmpNo,t2.StairName,t3.SecondName,t4.Money,t4.CheckInTime,t5.StayOutTime,t5.Deduction  from Staff t1 join Department t2 on t1.DepartmentId=t2.Id join Station t3 on t1.StationId = t3.Id join StaffCheckIn t4 on t1.Id=t4.StaffId join StaffStayOut t5 on t1.Id=t5.StaffId where 1=1 ";

            string countsql = "select COUNT(*) from Staff t1 join Department t2 on t1.DepartmentId=t2.Id join Station t3 on t1.StationId = t3.Id join StaffCheckIn t4 on t1.Id=t4.StaffId join StaffStayOut t5 on t1.Id=t5.StaffId where 1=1 ";
            if (!string.IsNullOrEmpty(startDate) || !string.IsNullOrEmpty(endDate))
            {
                cmdText += $" and t5.StayOutTime between '{startDate}' and '{endDate}'";
                countsql += $" and t5.StayOutTime between '{startDate}' and '{endDate}'";
            }
            int totalCount = (int)DapperHelper.ExecuteScalar(countsql);
            string pagesql = $"select * from ({cmdText}) as t where t.rowId between {(PageIndex - 1) * PageSize + 1} and {PageIndex * PageSize}";
            var staffCheckIns = DapperHelper.GetList<StaffStaffStayOutDto>(pagesql);
            PageResultDto<StaffStaffStayOutDto> staffstaffstayoutdto = new PageResultDto<StaffStaffStayOutDto>()
            {
                ItemCount = totalCount,
                Items = staffCheckIns
            };
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
            string cmdText = "select ROW_NUMBER() over(order by t1.Id) as rowId,t1.Id,t1.Name,t1.Sex,t1.TypeId,t1.EmpNo,t2.StairName,t3.SecondName,t4.Money,t4.CheckInTime,t5.StayOutTime,t5.Deduction  from Staff t1 join Department t2 on t1.DepartmentId=t2.Id join Station t3 on t1.StationId = t3.Id join StaffCheckIn t4 on t1.Id=t4.StaffId join StaffStayOut t5 on t1.Id=t5.StaffId where 1=1 ";

            if (!string.IsNullOrEmpty(starttime) || !string.IsNullOrEmpty(finishtime))
            {
                cmdText += $" and t5.StayOutTime between '{starttime}' and '{finishtime}'";
            }
            List<StaffStaffStayOutDto> staffstaffStayout = DapperHelper.GetList<StaffStaffStayOutDto>(cmdText);
            return staffstaffStayout;
        }
    }
}
