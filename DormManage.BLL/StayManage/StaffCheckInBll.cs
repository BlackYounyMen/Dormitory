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
    /// 员工入住 业务逻辑层 
    /// </summary>
    public class StaffCheckInBll
    {
        /// <summary>
        /// 实例化
        /// </summary>
        StaffCheckInDal staffDal = new StaffCheckInDal();

        /// <summary>
        /// 获取员工入住信息
        /// </summary>
        /// <param name="name">姓名</param>
        /// <param name="pageIndex">当前页</param>
        /// <param name="pageSize">页容量</param>
        /// <returns></returns>
        public PageResultDto<StaffCheckInDto> GetStaffCheckInList(string name, int pageIndex, int pageSize)
        {
            PageResultDto<StaffCheckInDto> pageResult = staffDal.GetStaffCheckInList(name, pageIndex, pageSize);
            return pageResult;
        }

        /// <summary>
        /// 添加入住信息
        /// </summary>
        /// <param name="staff"></param>
        /// <returns></returns>
        public int Add(StaffCheckIn staff)
        {
            var i = staffDal.Add(staff);
            return i;
        }

        /// <summary>
        /// 获取所有员工信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public List<StaffDto> GetStaffList(int id)
        {
            var staffList = staffDal.GetStaffList(id);
            return staffList;
        }


        /// <summary>
        /// 获取宿舍信息
        /// </summary>
        /// <returns></returns>
        public List<Dormitory> GetDormitorieList()
        {
            var dormitorieList = staffDal.GetDormitorieList();
            return dormitorieList;
        }

        /// <summary>
        /// 获取对应的床位信息
        /// </summary>
        /// <param name="dormId"></param>
        /// <returns></returns>
        public List<Bunk> GetBunkList(int dormId)
        {
            var bunkList = staffDal.GetBunkList(dormId);
            return bunkList;
        }

        /// <summary>
        /// 根据id获取一条数据
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public StaffStayOutDto GetStaffCheckInById(int id)
        {
            var saffCheckIn = staffDal.GetStaffCheckInById(id);
            return saffCheckIn;
        }

        /// <summary>
        /// 修改员工入住信息
        /// </summary>
        /// <param name="staff"></param>
        /// <returns></returns>
        public int Update(StaffCheckIn staff)
        {
            var i = staffDal.Update(staff);
            return i;
        }
    }
}
