using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DormManage.DAL.RewardsManage;
using DormManage.Model;

namespace DormManage.BLL.RewardsManage
{
    /// <summary>
    /// 奖励管理
    /// </summary>
    public class AwardManageBll
    {
        /// <summary>
        /// 实例化
        /// </summary>
        AwardManageDal awardManageDal = new AwardManageDal();

        /// <summary>
        /// 获取奖励信息 支持分页 
        /// </summary>
        /// <param name="startTime"></param>
        /// <param name="endTime"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        public PageResultDto<RewardDto> GetRewardList(DateTime startTime, DateTime endTime, int pageIndex, int pageSize)
        {
            PageResultDto<RewardDto> pageResult = awardManageDal.GetRewardList(startTime,endTime,pageIndex,pageSize);
            return pageResult;
        }

        /// <summary>
        /// 获取导出的奖励信息
        /// </summary>
        /// <param name="startTime"></param>
        /// <param name="endTime"></param>
        /// <returns></returns>
        public List<RewardDto> GetRewards(DateTime startTime, DateTime endTime)
        {
            List<RewardDto> rewardList = awardManageDal.GetRewards(startTime, endTime);
            return rewardList;
        }

        /// <summary>
        /// 添加奖励信息
        /// </summary>
        /// <param name="reward"></param>
        /// <returns></returns>
        public int Add(Reward reward)
        {
            var i = awardManageDal.Add(reward);
            return i;
        }

        /// <summary>
        /// 根据id获取单条数据
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public RewardDto GetRewardById(int id)
        {
            var reward = awardManageDal.GetRewardById(id);
            return reward;
        }

        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="reward"></param>
        /// <returns></returns>
        public int Update(Reward reward)
        {
            var i = awardManageDal.Update(reward);
            return i;
        }

        /// <summary>
        /// 获取员工信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public List<StaffDto> GetStaffList(int id)
        {
            var staffList = awardManageDal.GetStaffList(id);
            return staffList;
        }
    }
}
