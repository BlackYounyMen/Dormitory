using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DormManage.DAL.StayManage;
using DormManage.Model;

namespace DormManage.BLL.StayManage
{
    public class StayWithholdBll
    {
        /// <summary>
        /// 实例化DAL
        /// </summary>
        StayWithholdDal stayWithholdDal = new StayWithholdDal();

        /// <summary>
        /// 获取数据的信息(住宿扣款) 分页
        /// </summary>
        /// <param name="name">名称查询</param>
        /// <param name="pageindex">当前页数</param>
        /// <param name="pagesize">每页容量</param>
        /// <returns></returns>
        public List<StaffStaffStayOutDto> GetStaffs(string entryTime, string checkInTime, out int totalCount, int pageIndex, int pageSize)
        {
            var quarterages = stayWithholdDal.GetStaffs(entryTime, checkInTime, out totalCount, pageIndex, pageSize);
            return quarterages;
        }
    }
}
