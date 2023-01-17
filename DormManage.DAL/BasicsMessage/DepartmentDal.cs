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
    /// 部门维护 数据访问层
    /// </summary>
    public class DepartmentDal
    {
        /// <summary>
        /// 获取一级部门信息
        /// </summary>
        /// <returns></returns>
        public List<Department> GetDepartmentList()
        {
            string cmdText = "select * from Department";
            var departmentList = DapperHelper.GetList<Department>(cmdText);
            return departmentList;
        }

        /// <summary>
        /// 添加一级部门
        /// </summary>
        /// <param name="department">一级部门信息</param>
        /// <returns></returns>
        public int AddDepartment(Department department)
        {
            string cmdText = $"insert into Department(StairName,IsEnable) values('{department.StairName}','{department.IsEnable}')";
            var i = DapperHelper.ExecuteSQL(cmdText);
            return i;
        }

        /// <summary>
        /// 根据id获取一条一级部门信息
        /// </summary>
        /// <param name="id">id</param>
        /// <returns></returns>
        public Department GetDepartmentById(int id)
        {
            string cmdText = $"select * from Department where Id={id}";
            var department = DapperHelper.GetList<Department>(cmdText).FirstOrDefault();
            return department;
        }

        /// <summary>
        /// 修改一级部门信息
        /// </summary>
        /// <param name="department">部门信息</param>
        /// <returns></returns>
        public int UpdateDepartment(Department department)
        {
            string cmdText = $"update Department set StairName='{department.StairName}',IsEnable='{department.IsEnable}' where Id={department.Id}";
            var i = DapperHelper.ExecuteSQL(cmdText);
            return i;
        }

        /// <summary>
        /// 获取二级部门信息
        /// </summary>
        /// <returns></returns>
        public List<StationDto> GetStationList()
        {
            string cmdText = "select t1.*,t2.StairName from Station t1 join Department t2 on t1.ParentId=t2.Id";
            var stationList = DapperHelper.GetList<StationDto>(cmdText);
            return stationList;
        }

        /// <summary>
        /// 添加二级部门
        /// </summary>
        /// <param name="station">二级部门信息</param>
        /// <returns></returns>
        public int AddStation(Station station)
        {
            string cmdText = $"insert into Station(SecondName,ParentId,IsEnable) values('{station.SecondName}',{station.ParentId},'{station.IsEnable}')";
            var i = DapperHelper.ExecuteSQL(cmdText);
            return i;
        }

        /// <summary>
        /// 根据id获取一条二级部门信息
        /// </summary>
        /// <param name="id">id</param>
        /// <returns></returns>
        public Station GetStationById(int id)
        {
            string cmdText = $"select * from Station where Id={id}";
            var station = DapperHelper.GetList<Station>(cmdText).FirstOrDefault();
            return station;
        }

        /// <summary>
        /// 修改二级部门信息
        /// </summary>
        /// <param name="department">部门信息</param>
        /// <returns></returns>
        public int UpdateStation(Station station)
        {
            string cmdText = $"update Station set SecondName='{station.SecondName}',ParentId={station.ParentId},IsEnable='{station.IsEnable}' where Id={station.Id}";
            var i = DapperHelper.ExecuteSQL(cmdText);
            return i;
        }
    }
}
