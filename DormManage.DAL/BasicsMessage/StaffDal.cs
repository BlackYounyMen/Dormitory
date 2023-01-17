using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DormManage.Common;
using DormManage.Model;

namespace DormManage.DAL
{
    /// <summary>
    /// 员工维护 数据访问层
    /// </summary>
    public class StaffDal
    {
        /// <summary>
        /// 添加员工基础信息
        /// </summary>
        /// <param name="staffDTO"></param>
        /// <returns></returns>
        public int Add(Staff staff)
        {
            string cmdText = $"insert into Staff(Name,Sex,TypeId,EmpNo,DepartmentId,StationId,IDCard,Mobile,EmergencyName,EmergencyMobile,EntryTime,IsResidence,IsEnable)values('{staff.Name}','{staff.Sex}','{staff.TypeId}','{staff.EmpNo}','{staff.DepartmentId}','{staff.StationId}','{staff.IDCard}','{staff.Mobile}','{staff.EmergencyName}','{staff.EmergencyMobile}','{staff.EntryTime}','{staff.IsResidence}','{staff.IsEnable}')";
            var i = DapperHelper.ExecuteSQL(cmdText);
            return i;
        }

        /// <summary>
        /// 获取员工数据的信息 查询  分页
        /// </summary>
        /// <param name="name">姓名</param>
        /// <param name="pageIndex">当前页数</param>
        /// <param name="pageSize">每页容量</param>
        /// <returns></returns>
        public PageResultDto<StaffDto> GetStaffList(string name, int pageIndex, int pageSize)
        {
            PageResultDto<StaffDto> pageResult = new PageResultDto<StaffDto>();
            string cmdText = $"select ROW_NUMBER() over(order by t1.Id)as rowId,t1.*,t2.StairName,t3.SecondName from Staff t1 join Department t2 on t1.DepartmentId=t2.Id join Station t3 on t1.StationId=t3.Id where 1=1 ";
            string countSql = $"select count(*) from Staff t1 join Department t2 on t1.DepartmentId=t2.Id join Station t3 on t1.StationId=t3.Id where 1=1 ";
            if (!string.IsNullOrEmpty(name))
            {
                cmdText += $" and t1.Name like '%{name}%'";
                countSql += $" and t1.Name like '%{name}%'";
            }
            pageResult.ItemCount = (int)DapperHelper.ExecuteScalar(countSql);
            string pageSql = $"select * from ({cmdText})as t where t.rowId between {(pageIndex - 1) * pageSize + 1} and {pageIndex * pageSize}";
            pageResult.Items = DapperHelper.GetList<StaffDto>(pageSql);
            return pageResult;
        }

        /// <summary>
        /// 根据ID获取单条数据信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public StaffDto GetStaffById(int id)
        {
            string cmdText = $"select t1.*,t2.StairName,t3.SecondName from Staff t1 join Department t2 on t1.DepartmentId=t2.Id join Station t3 on t1.StationId=t3.Id where t1.Id={id}";
            var staffDTO = DapperHelper.GetList<StaffDto>(cmdText).FirstOrDefault();
            return staffDTO;
        }

        /// <summary>
        /// 执行修改方法
        /// </summary>
        /// <param name="staffDTO"></param>
        /// <returns></returns>
        public int Update(Staff staff)
        {
            string sql = $"Update Staff Set Name='{staff.Name}',Sex='{staff.Sex}',TypeId='{staff.TypeId}',EmpNo='{staff.EmpNo}',DepartmentId='{staff.DepartmentId}',StationId='{staff.StationId}',IDCard='{staff.IDCard}',Mobile='{staff.Mobile}',EmergencyName='{staff.EmergencyName}',EmergencyMobile='{staff.EmergencyMobile}',EntryTime='{staff.EntryTime}',IsResidence='{staff.IsResidence}',IsEnable='{staff.IsEnable}' where Id='{staff.Id}'";
            var i = DapperHelper.ExecuteSQL(sql);
            return i;
        }

        /// <summary>
        /// 根据一级部门信息 获取对应的二级部门信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public List<Station> GetStationList(int id)
        {
            string cmdText = $"select * from Station where Id={id}";
            var stationList = DapperHelper.GetList<Station>(cmdText);
            return stationList;
        }
    }
}
