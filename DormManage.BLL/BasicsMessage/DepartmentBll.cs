using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DormManage.DAL;
using DormManage.Model;

namespace DormManage.BLL.BasicsMessage
{
    /// <summary>
    /// 部门维护  业务逻辑层
    /// </summary>
    public class DepartmentBll
    {
        /// <summary>
        /// 实例化部门维护 数据访问层
        /// </summary>
        DepartmentDal departmentDal = new DepartmentDal();

        /// <summary>
        /// 获取一级部门信息
        /// </summary>
        /// <returns></returns>
        public List<Department> GetStairDepartmentList()
        {
            var departmentList = departmentDal.GetDepartmentList();
            return departmentList;
        }

        /// <summary>
        /// 添加一级部门
        /// </summary>
        /// <param name="department">一级部门信息</param>
        /// <returns></returns>
        public int AddDepartment(Department department)
        {
            var i = departmentDal.AddDepartment(department);
            return i;
        }

        /// <summary>
        /// 根据id获取一条一级部门信息
        /// </summary>
        /// <param name="id">id</param>
        /// <returns></returns>
        public Department GetDepartmentById(int id)
        {
            var department = departmentDal.GetDepartmentById(id);
            return department;
        }

        /// <summary>
        /// 修改一级部门信息
        /// </summary>
        /// <param name="department">部门信息</param>
        /// <returns></returns>
        public int UpdateDepartment(Department department)
        {
            var i = departmentDal.UpdateDepartment(department);
            return i;
        }

        /// <summary>
        /// 获取二级部门信息
        /// </summary>
        /// <returns></returns>
        public List<StationDto> GetStationList()
        {
            var stationList = departmentDal.GetStationList();
            return stationList;
        }

        /// <summary>
        /// 添加二级部门
        /// </summary>
        /// <param name="station">二级部门信息</param>
        /// <returns></returns>
        public int AddStation(Station station)
        {
            var i = departmentDal.AddStation(station);
            return i;
        }

        /// <summary>
        /// 根据id获取一条二级部门信息
        /// </summary>
        /// <param name="id">id</param>
        /// <returns></returns>
        public Station GetStationById(int id)
        {
            var station = departmentDal.GetStationById(id);
            return station;
        }

        /// <summary>
        /// 修改二级部门信息
        /// </summary>
        /// <param name="station">部门信息</param>
        /// <returns></returns>
        public int UpdateStation(Station station)
        {
            var i = departmentDal.UpdateStation(station);
            return i;
        }
    }
}
