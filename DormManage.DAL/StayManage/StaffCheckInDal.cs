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
    /// 员工入住 数据访问层 - 熊向东
    /// </summary>
    public class StaffCheckInDal
    {
        /// <summary>
        /// 获取员工入住信息
        /// </summary>
        /// <param name="name">姓名</param>
        /// <param name="pageIndex">当前页</param>
        /// <param name="pageSize">页容量</param>
        /// <returns></returns>
        public PageResultDto<StaffCheckInDto> GetStaffCheckInList(string name, int pageIndex, int pageSize)
        {
            string cmdText = "select ROW_NUMBER() over(order by t1.Id)as rowId,t1.*,t2.Name,t2.Sex,t2.TypeId,t2.EmpNo,t3.DormitoryNo,t4.BunkNo from StaffCheckIn t1 join Staff t2 on t1.StaffId=t2.Id join Dormitory t3 on t1.DormitoryId=t3.Id join Bunk t4 on t1.BunkId=t4.Id where 1=1 ";
            string countSql = "select count(*) from StaffCheckIn t1 join Staff t2 on t1.StaffId=t2.Id join Dormitory t3 on t1.DormitoryId=t3.Id join Bunk t4 on t1.BunkId=t4.Id where 1=1 ";
            if (!string.IsNullOrEmpty(name))
            {
                cmdText += $" and t2.Name like '%{name}%'";
                countSql += $" and t2.Name like '%{name}%'";
            }
            int totalCount = (int)DapperHelper.ExecuteScalar(countSql);
            string pageSql = $"select * from ({cmdText})as t where t.rowId between {(pageIndex - 1) * pageSize + 1} and {pageIndex * pageSize}";
            var staffCheckIns = DapperHelper.GetList<StaffCheckInDto>(pageSql);
            PageResultDto<StaffCheckInDto> pageResult = new PageResultDto<StaffCheckInDto>()
            {
                ItemCount = totalCount,
                Items = staffCheckIns
            };
            return pageResult;
        }

        /// <summary>
        /// 添加入住信息
        /// </summary>
        /// <param name="staff"></param>
        /// <returns></returns>
        public int Add(StaffCheckIn staff)
        {
            string cmdText = $"insert into StaffCheckIn(StaffId,[Money],Treaty,Access,TowerParent,DormParent,CheckInTime,DormitoryId,BunkId,IsEnable) values('{staff.StaffId}',{staff.Money},'{staff.Treaty}','{staff.Access}','{staff.TowerParent}','{staff.DormParent}','{staff.CheckInTime}','{staff.DormitoryId}','{staff.BunkId}','1')";
            var i = DapperHelper.ExecuteSQL(cmdText);
            return i;
        }

        /// <summary>
        /// 获取所有员工信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public List<StaffDto> GetStaffList(int id)
        {
            var staffList = new List<StaffDto>();
            string cmdText = "";
            if (id == 0)
            {
                cmdText = $"select t1.*,t2.StairName,t3.SecondName from Staff t1 join Department t2 on t1.DepartmentId=t2.Id join Station t3 on t1.StationId=t3.Id where t1.Id not in(select StaffId from StaffCheckIn)";
                staffList = DapperHelper.GetList<StaffDto>(cmdText);
                return staffList;
            }
            else
            {
                cmdText = $"select t1.*,t2.StairName,t3.SecondName from Staff t1 join Department t2 on t1.DepartmentId=t2.Id join Station t3 on t1.StationId=t3.Id where 1=1 and t1.Id={id}";
                staffList = DapperHelper.GetList<StaffDto>(cmdText);
                return staffList;
            }
        }

        /// <summary>
        /// 获取宿舍信息
        /// </summary>
        /// <returns></returns>
        public List<Dormitory> GetDormitorieList()
        {
            string cmdText = "select * from Dormitory";
            var dormitorieList = DapperHelper.GetList<Dormitory>(cmdText);
            return dormitorieList;
        }

        /// <summary>
        /// 获取对应的床位信息
        /// </summary>
        /// <param name="dormId"></param>
        /// <returns></returns>
        public List<Bunk> GetBunkList(int dormId)
        {
            string cmdText = $"select * from Bunk where DormitoryId={dormId}";
            var bunkList = DapperHelper.GetList<Bunk>(cmdText);
            return bunkList;
        }

        /// <summary>
        /// 根据id获取一条数据
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public StaffCheckInDto GetStaffCheckInById(int id)
        {
            string cmdText = $"select t1.*,t2.Name,t2.EmpNo,t2.Sex,t2.TypeId,t2.Mobile,t2.EmergencyName,t2.EmergencyMobile,t3.StairName,t4.SecondName,t5.BunkNo from StaffCheckIn t1 join Staff t2 on t1.StaffId=t2.Id join Department t3 on t2.DepartmentId=t3.Id join Station t4 on t2.StationId=t4.Id join Bunk t5 on t1.BunkId=t5.Id where t1.Id={id}";
            var saffCheckIn = DapperHelper.GetList<StaffCheckInDto>(cmdText).FirstOrDefault();
            return saffCheckIn;
        }

        /// <summary>
        /// 修改员工入住信息
        /// </summary>
        /// <param name="staff"></param>
        /// <returns></returns>
        public int Update(StaffCheckIn staff)
        {
            string cmdText = $"update StaffCheckIn set [Money]='{staff.Money}',Treaty='{staff.Treaty}',Access='{staff.Access}',TowerParent='{staff.TowerParent}',DormParent='{staff.DormParent}',CheckInTime='{staff.CheckInTime}',DormitoryId='{staff.DormitoryId}',BunkId='{staff.BunkId}' where Id={staff.Id}";
            var i = DapperHelper.ExecuteSQL(cmdText);
            return i;
        }
    }
}
