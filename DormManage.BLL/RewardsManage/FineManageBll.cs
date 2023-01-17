using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DormManage.Model;
using DormManage.DAL.RewardsManage;

namespace DormManage.BLL.RewardsManage
{
    public class FineManageBll
    {
        /// <summary>
        /// 实例化
        /// </summary>
        FineManageDal fineManageDal = new FineManageDal();

        /// <summary>
        /// 获取惩罚信息 支持分页 
        /// </summary>
        /// <param name="startTime"></param>
        /// <param name="endTime"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        public PageResultDto<FineDto> GetFineList(DateTime startTime, DateTime endTime, int pageIndex, int pageSize)
        {
            PageResultDto<FineDto> pageResult = fineManageDal.GetFineList(startTime, endTime, pageIndex, pageSize);
            return pageResult;
        }


        /// <summary>
        /// 获取导出的处罚信息
        /// </summary>
        /// <param name="startTime"></param>
        /// <param name="endTime"></param>
        /// <returns></returns>
        public List<FineDto> GetFines(DateTime startTime, DateTime endTime)
        {
            List<FineDto> fineList = fineManageDal.GetFines(startTime, endTime);
            return fineList;
        }

        /// <summary>
        /// 添加处罚信息
        /// </summary>
        /// <param name="reward"></param>
        /// <returns></returns>
        public int Add(Fine fine)
        {
            var i = fineManageDal.Add(fine);
            return i;
        }

        /// <summary>
        /// 根据id获取单条数据
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public FineDto GetRewardById(int id)
        {
            var fine = fineManageDal.GetRewardById(id);
            return fine;
        }

        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="reward"></param>
        /// <returns></returns>
        public int Update(Fine fine)
        {
            var i = fineManageDal.Update(fine);
            return i;
        }

        /// <summary>
        /// 获取员工信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public List<StaffDto> GetStaffList(int id)
        {
            var staffList = fineManageDal.GetStaffList(id);
            return staffList;
        }
    }
}
