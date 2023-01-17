using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DormManage.Common;
using DormManage.Model;

namespace DormManage.DAL.StayManage
{
    /// <summary>
    /// /// <summary>
    /// 员工退宿 数据访问层 -王保宁
    /// </summary>
    /// </summary>
    public class StaffStayOutDal
    {
        #region //获取员工退宿信息

        /// <summary>
        /// 获取员工退宿信息
        /// </summary>
        /// <param name="name">姓名</param>
        /// <param name="pageIndex">当前页</param>
        /// <param name="pageSize">页容量</param>
        /// <returns></returns>
        public PageResultDto<StaffStayOutDto> GetStaffStayOutList(string name, int pageIndex, int pageSize)
        {
            string cmdText = "select  ROW_Number() over(order by A.Id) as rowId,A.Id,C.Name,C.Sex,C.TypeId,C.EmpNo,F.StairName,G.SecondName,B.Treaty,B.Access,B.CheckInTime,A.StayOutTime,A.Deduction,B.TowerParent,B.DormParent,D.DormitoryNo,E.BunkNo from StaffStayOut A inner join StaffCheckIn B on A.CheckInId=B.Id inner join Staff C on A.StaffId=C.Id inner join Dormitory D on B.DormitoryId=D.Id inner join Bunk E on B.BunkId=E.Id inner join Department F on C.DepartmentId=F.Id inner join Station G on C.StationId=G.Id where 1=1 ";
            string countSql = "select count(*) from StaffStayOut A inner join StaffCheckIn B on A.CheckInId=B.Id inner join Staff C on A.StaffId=C.Id inner join Dormitory D on B.DormitoryId=D.Id inner join Bunk E on B.BunkId=E.Id inner join Department F on C.DepartmentId=F.Id inner join Station G on C.StationId=G.Id where 1=1 ";
            if (!string.IsNullOrEmpty(name))
            {
                cmdText += $" and C.Name like '%{name}%'";
                countSql += $" and C.Name like '%{name}%'";
            }
            int totalCount = (int)DapperHelper.ExecuteScalar(countSql);
            string pageSql = $"select * from ({cmdText})as t where t.rowId between {(pageIndex - 1) * pageSize + 1} and {pageIndex * pageSize}";
            var staffStayOuts = DapperHelper.GetList<StaffStayOutDto>(pageSql);
            PageResultDto<StaffStayOutDto> pageResult = new PageResultDto<StaffStayOutDto>()
            {
                ItemCount = totalCount,
                Items = staffStayOuts
            };
            return pageResult;
        }

        #endregion

        #region // 添加退宿信息

        /// <summary>
        /// 添加退宿信息
        /// </summary>
        /// <param name="staff"></param>
        /// <returns></returns>
        public int Add(StaffStayOutDto staff)
        {
            var firstId = $"select * from StaffCheckIn where StaffId = {staff.StaffId}";
            var data = DapperHelper.GetList<StaffCheckIn>(firstId);
            string cmdText = $"insert into StaffStayOut(StaffId,CheckInId,StayOutTime,Deduction) values('{staff.StaffId}','{data[0].Id}','{staff.StayOutTime}','{staff.Deduction}')";
            var i = DapperHelper.ExecuteSQL(cmdText);
            cmdText = $"update StaffCheckIn set IsEnable=0 where StaffId={data[0].Id}";
            i = DapperHelper.ExecuteSQL(cmdText);
            return i;
        }

        #endregion

        #region //获取员工信息

        /// <summary>
        /// 获取所有员工信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public List<StaffStayOutDto> GetStaffList(int id)
        {
            var staffList = new List<StaffStayOutDto>();
            string cmdText = "";
            if (id == 0)
            {
                cmdText = $"select t1.*,t2.StairName,t3.SecondName,t4.Id as CheckInId from Staff t1 join Department t2 on t1.DepartmentId=t2.Id join Station t3 on t1.StationId=t3.Id join StaffCheckIn t4 on t1.Id=t4.StaffId where t1.Id in(select StaffId from StaffCheckIn where StaffCheckIn.IsEnable=1)";
                staffList = DapperHelper.GetList<StaffStayOutDto>(cmdText);
                return staffList;
            }
            else
            {
                cmdText += $"select t1.*,t2.StairName,t3.SecondName,t4.Id as CheckInId,t4.CheckInTime,t4.TowerParent,t4.DormParent,t4.Treaty,t4.Access from Staff t1 join Department t2 on t1.DepartmentId=t2.Id join Station t3 on t1.StationId=t3.Id inner join StaffCheckIn t4 on t1.Id=t4.StaffId where 1=1 and t1.Id={id}";
                staffList = DapperHelper.GetList<StaffStayOutDto>(cmdText);
                return staffList;
            }
        }

        #endregion

        #region //根据id获取数据

        /// <summary>
        /// 根据id获取一条数据
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public StaffStayOutDto GetStaffStayOutById(int id)
        {
            string cmdText = $"select A.Id,A.StaffId,C.Name,C.Sex,C.TypeId,C.EmpNo,F.StairName,G.SecondName,C.Mobile,C.EmergencyName,C.EmergencyMobile,B.Treaty,B.Access,B.CheckInTime,A.StayOutTime,A.Deduction,B.TowerParent,B.DormParent,D.DormitoryNo,E.BunkNo from StaffStayOut A inner join StaffCheckIn B on A.CheckInId=B.Id inner join Staff C on A.StaffId=C.Id inner join Dormitory D on B.DormitoryId=D.Id inner join Bunk E on B.BunkId=E.Id inner join Department F on C.DepartmentId=F.Id inner join Station G on C.StationId=G.Id where A.Id={id}";
            var saffstayOut = DapperHelper.GetList<StaffStayOutDto>(cmdText).FirstOrDefault();
            return saffstayOut;
        }

        #endregion

        #region // 修改员工入住信息

        /// <summary>
        /// 修改员工入住信息
        /// </summary>
        /// <param name="staff"></param>
        /// <returns>StaffId='{staff.StaffId}',</returns>
        public int Update(StaffStayOutDto staff)
        {
            //CheckInId = '{staff.CheckInId}',
            string cmdText = $"update StaffStayOut set StayOutTime='{staff.StayOutTime}',Deduction='{staff.Deduction}' where Id={staff.Id}";
            var i = DapperHelper.ExecuteSQL(cmdText);
            return i;
        }

        #endregion
    }
}