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
    /// 员工维护 业务逻辑层
    /// </summary>
    public class StaffBll
    {
        /// <summary>
        /// 实例化
        /// </summary>
        StaffDal staffDal = new StaffDal();

        /// <summary>
        /// 添加员工基础信息
        /// </summary>
        /// <param name="staffDTO"></param>
        /// <returns></returns>
        public int Add(Staff staff)
        {
            var i = staffDal.Add(staff);
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
            var pageResult = staffDal.GetStaffList(name, pageIndex, pageSize);
            return pageResult;
        }

        /// <summary>
        /// 根据ID获取单条数据信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public StaffDto GetStaffById(int id)
        {
            var staffDTO = staffDal.GetStaffById(id);
            return staffDTO;
        }

        /// <summary>
        /// 执行修改方法
        /// </summary>
        /// <param name="staffDTO"></param>
        /// <returns></returns>
        public int Update(Staff staff)
        {
            var i = staffDal.Update(staff);
            return i;
        }


        /// <summary>
        /// 根据一级部门信息 获取对应的二级部门信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public List<Station> GetStationList(int id)
        {
            var stationList = staffDal.GetStationList(id);
            return stationList;
        }
    }
}
