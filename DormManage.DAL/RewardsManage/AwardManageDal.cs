using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DormManage.Common;
using DormManage.Model;

namespace DormManage.DAL.RewardsManage
{
    /// <summary>
    /// 奖励管理
    /// </summary>
    public class AwardManageDal
    {
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
            string cmdText = $"select ROW_NUMBER() over(order by t1.Id)as rowId,t1.*,t2.Name,t2.EmpNo,t2.Sex,t3.StairName,t4.SecondName from Reward t1 join Staff t2 on t1.StaffId=t2.Id join Department t3 on t2.DepartmentId=t3.Id join Station t4 on t2.StationId=t4.Id where 1=1 ";
            string countSql = $"select count(*) from Reward t1 join Staff t2 on t1.StaffId=t2.Id join Department t3 on t2.DepartmentId=t3.Id join Station t4 on t2.StationId=t4.Id where 1=1 ";
            if (!string.IsNullOrEmpty(startTime.ToString()) && !string.IsNullOrEmpty(endTime.ToString()))
            {
                cmdText += $" and t1.AddTime between '{startTime}' and '{endTime}'";
                countSql += $" and t1.AddTime between '{startTime}' and '{endTime}'";
            }
            string pageSql = $"select * from ({cmdText})as t where t.rowId between {(pageIndex - 1) * pageSize + 1} and {pageIndex * pageSize}";
            PageResultDto<RewardDto> pageResult = new PageResultDto<RewardDto>()
            {
                Items = DapperHelper.GetList<RewardDto>(pageSql),
                ItemCount =(int) DapperHelper.ExecuteScalar(countSql)
            };
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
            string cmdText = $"select t1.*,t2.Name,t2.EmpNo,t2.Sex,t3.StairName,t4.SecondName from Reward t1 join Staff t2 on t1.StaffId=t2.Id join Department t3 on t2.DepartmentId=t3.Id join Station t4 on t2.StationId=t4.Id where 1=1 ";
            if (!string.IsNullOrEmpty(startTime.ToString()) && !string.IsNullOrEmpty(endTime.ToString()))
            {
                cmdText += $" and t1.AddTime between '{startTime}' and '{endTime}'";
            }
            List<RewardDto> rewardList = DapperHelper.GetList<RewardDto>(cmdText);
            return rewardList;
        }

        /// <summary>
        /// 添加奖励信息
        /// </summary>
        /// <param name="reward"></param>
        /// <returns></returns>
        public int Add(Reward reward)
        {
            string cmdText = $"insert into Reward(StaffId,Matter,Pursuant,[Money],AddTime,Remark) values('{reward.StaffId}','{reward.Matter}','{reward.Pursuant}','{reward.Money}','{reward.AddTime}','{reward.Remark}')";
            var i = DapperHelper.ExecuteSQL(cmdText);
            return i;
        }

        /// <summary>
        /// 根据id获取单条数据
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public RewardDto GetRewardById(int id)
        {
            string cmdText = $"select t1.*,t3.StairName,t4.SecondName from Reward t1 join Staff t2 on t1.StaffId=t2.Id join Department t3 on t2.DepartmentId=t3.Id join Station t4 on t2.StationId=t4.Id where t1.Id={id}";
            var reward = DapperHelper.GetList<RewardDto>(cmdText).FirstOrDefault();
            return reward;
        }

        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="reward"></param>
        /// <returns></returns>
        public int Update(Reward reward)
        {
            string cmdText = $"update Reward set StaffId='{reward.StaffId}',Matter='{reward.Matter}',Pursuant='{reward.Pursuant}',[Money]='{reward.Money}',AddTime='{reward.AddTime}',Remark='{reward.Remark}' where Id={reward.Id}";
            var i = DapperHelper.ExecuteSQL(cmdText);
            return i;
        }


        /// <summary>
        /// 获取员工信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public List<StaffDto> GetStaffList(int id)
        {
            string cmdText = $"select t1.*,t2.StairName,t3.SecondName from Staff t1 join Department t2 on t1.DepartmentId=t2.Id join Station t3 on t1.StationId=t3.Id where 1=1 and t1.IsEnable='true' ";
            if (id > 0)
            {
                cmdText += $" and t1.Id={id}";
            }
            var staffList = DapperHelper.GetList<StaffDto>(cmdText);
            return staffList;
        }
    }
}
