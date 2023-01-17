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
    /// 惩罚管理
    /// </summary>
    public class FineManageDal
    {
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
            string cmdText = $"select ROW_NUMBER() over(order by t1.Id)as rowId,t1.*,t2.Name,t2.EmpNo,t2.Sex,t3.StairName,t4.SecondName from Fine t1 join Staff t2 on t1.StaffId=t2.Id join Department t3 on t2.DepartmentId=t3.Id join Station t4 on t2.StationId=t4.Id where 1=1 ";
            string countSql = $"select count(*) from Fine t1 join Staff t2 on t1.StaffId=t2.Id join Department t3 on t2.DepartmentId=t3.Id join Station t4 on t2.StationId=t4.Id where 1=1 ";
            if (!string.IsNullOrEmpty(startTime.ToString()) && !string.IsNullOrEmpty(endTime.ToString()))
            {
                cmdText += $" and t1.AddTime between '{startTime}' and '{endTime}'";
                countSql += $" and t1.AddTime between '{startTime}' and '{endTime}'";
            }
            string pageSql = $"select * from ({cmdText})as t where t.rowId between {(pageIndex - 1) * pageSize + 1} and {pageIndex * pageSize}";
            PageResultDto<FineDto> pageResult = new PageResultDto<FineDto>()
            {
                Items = DapperHelper.GetList<FineDto>(pageSql),
                ItemCount = (int)DapperHelper.ExecuteScalar(countSql)
            };
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
            string cmdText = $"select t1.*,t2.Name,t2.EmpNo,t2.Sex,t3.StairName,t4.SecondName from Fine t1 join Staff t2 on t1.StaffId=t2.Id join Department t3 on t2.DepartmentId=t3.Id join Station t4 on t2.StationId=t4.Id where 1=1 ";
            if (!string.IsNullOrEmpty(startTime.ToString()) && !string.IsNullOrEmpty(endTime.ToString()))
            {
                cmdText += $" and t1.AddTime between '{startTime}' and '{endTime}'";
            }
            List<FineDto> fineList = DapperHelper.GetList<FineDto>(cmdText);
            return fineList;
        }

        /// <summary>
        /// 添加处罚信息
        /// </summary>
        /// <param name="reward"></param>
        /// <returns></returns>
        public int Add(Fine fine)
        {
            string cmdText = $"insert into Fine(StaffId,Matter,Pursuant,[Money],AddTime,Remark) values('{fine.StaffId}','{fine.Matter}','{fine.Pursuant}','{fine.Money}','{fine.AddTime}','{fine.Remark}')";
            var i = DapperHelper.ExecuteSQL(cmdText);
            return i;
        }

        /// <summary>
        /// 根据id获取单条数据
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public FineDto GetRewardById(int id)
        {
            string cmdText = $"select t1.*,t3.StairName,t4.SecondName from Fine t1 join Staff t2 on t1.StaffId=t2.Id join Department t3 on t2.DepartmentId=t3.Id join Station t4 on t2.StationId=t4.Id where t1.Id={id}";
            var fine = DapperHelper.GetList<FineDto>(cmdText).FirstOrDefault();
            return fine;
        }

        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="reward"></param>
        /// <returns></returns>
        public int Update(Fine fine)
        {
            string cmdText = $"update Fine set StaffId='{fine.StaffId}',Matter='{fine.Matter}',Pursuant='{fine.Pursuant}',[Money]='{fine.Money}',AddTime='{fine.AddTime}',Remark='{fine.Remark}' where Id={fine.Id}";
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