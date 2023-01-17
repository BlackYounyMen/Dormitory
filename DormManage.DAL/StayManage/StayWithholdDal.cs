using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DormManage.Model;
using DormManage.Common;

namespace DormManage.DAL.StayManage
{
    public class StayWithholdDal
    {
        /// <summary>
        /// 获取数据的信息(住宿扣款) 分页
        /// </summary>
        /// <param name="name">名称查询</param>
        /// <param name="pageindex">当前页数</param>
        /// <param name="pagesize">每页容量</param>
        /// <returns></returns>
        public List<StaffStaffStayOutDto> GetStaffs(string entryTime, string checkInTime, out int totalCount, int pageIndex, int pageSize)
        {
            string sql = $"select row_number()over(order by t1.Id) rowid, t1.Id,t1.EmpNo,t1.Name,t1.Sex,t2.StairName,t3.SecondName,t1.TypeId,t1.EntryTime,t4.CheckInTime,t5.Deduction from Staff t1 join Department t2 on t1.DepartmentId=t2.Id join Station t3 on t1.StationId = t3.Id join StaffCheckIn t4 on t1.Id=t4.StaffId join StaffStayOut t5 on t1.Id=t5.StaffId where 1=1";

            if (!string.IsNullOrEmpty(entryTime) || !string.IsNullOrEmpty(checkInTime))
            {
                sql += $" and checkInTime between '{entryTime}' and '{checkInTime}'";
            }
            string cmdText = $"select * from ({sql}) tt where tt.rowid between {pageSize * (pageIndex - 1) + 1} and {pageSize * pageIndex}";
            totalCount = DapperHelper.GetList<StaffStaffStayOutDto>(sql).Count;
            var totactmxt = DapperHelper.GetList<StaffStaffStayOutDto>(cmdText);
            return totactmxt;
        }
    }
}
