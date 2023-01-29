using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DormManage.DAL.StayManage;
using DormManage.Model;

namespace DormManage.BLL.StayManage
{
    /// <summary>
    /// 员工退宿 业务逻辑层 - 
    /// </summary>
    public class StaffStayOutBll
    {
        /// <summary>
        /// 实例化
        /// </summary>
        private StaffStayOutDal staffOutDal = new StaffStayOutDal();

        #region //获取员工入住信息

        /// <summary>
        /// 获取员工入住信息
        /// </summary>
        /// <param name="name">姓名</param>
        /// <param name="pageIndex">当前页</param>
        /// <param name="pageSize">页容量</param>
        /// <returns></returns>
        public PageResultDto<StaffStayOutDto> GetStaffStayOutList(string name, int pageIndex, int pageSize)
        {
            PageResultDto<StaffStayOutDto> pageResult = staffOutDal.GetStaffStayOutList(name, pageIndex, pageSize);
            return pageResult;
        }

        #endregion

        #region //获取所有员工信息

        /// <summary>
        /// 获取所有员工信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public List<StaffStayOutDto> GetStaffList(int id)
        {
            var staffList = staffOutDal.GetStaffList(id);
            return staffList;
        }

        #endregion

        #region // 添加入住信息

        /// <summary>
        /// 添加入住信息
        /// </summary>
        /// <param name="staff"></param>
        /// <returns></returns>
        public int Add(StaffStayOutDto staff)
        {
            var i = staffOutDal.Add(staff);
            return i;
        }

        #endregion

        #region //根据id获取一条数据

        /// <summary>
        /// 根据id获取一条数据
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public StaffStayOutDto GetStaffStayOutById(int id)
        {
            var saffStayOut = staffOutDal.GetStaffStayOutById(id);
            return saffStayOut;
        }

        #endregion

        #region // 修改员工入住信息

        /// <summary>
        /// 修改员工入住信息
        /// </summary>
        /// <param name="staff"></param>
        /// <returns></returns>
        public int Update(StaffStayOutDto staff)
        {
            var i = staffOutDal.Update(staff);
            return i;
        }

        #endregion
    }
}