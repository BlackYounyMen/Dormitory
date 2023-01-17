using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DormManage.Model;
using DormManage.Common;

namespace DormManage.DAL
{
    /// <summary>
    /// 床位维护 数据访问层
    /// </summary>
    public class BunkDal
    {
        /// <summary>
        /// 获取所有宿舍信息
        /// </summary>
        /// <returns></returns>
        public List<Dormitory> GetDormitoryList()
        {
            string sql = "select * from Dormitory";
            List<Dormitory> dormitoryList = DapperHelper.GetList<Dormitory>(sql);
            return dormitoryList;
        }

        /// <summary>
        /// 两表联查 显示宿舍信息
        /// </summary>
        /// <returns></returns>
        public List<DormitoryBunkDto> GetBunkList()
        {
            string sql = "select t2.Id,t1.DormitoryNo,t2.IsEnable,t2.BunkNo from Dormitory t1 join Bunk t2 on t1.Id=t2.DormitoryId";
            List<DormitoryBunkDto> dormitorybunkList = DapperHelper.GetList<DormitoryBunkDto>(sql);
            return dormitorybunkList;
        }

        /// <summary>
        /// 添加宿舍信息
        /// </summary>
        /// <param name="bunk"></param>
        /// <returns></returns>
        public int AddBunk(Bunk bunk)
        {
            string sql = $"insert into Bunk(BunkNo,DormitoryId,IsEnable) values('{bunk.BunkNo}','{bunk.DormitoryId}','{bunk.IsEnable}')";
            var i = DapperHelper.ExecuteSQL(sql);
            return i;
        }

        /// <summary>
        /// 根据ID获取床位的第一条数据
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Bunk GetBunkById(int id)
        {
            string sql = $"select * from Bunk where Id={id}";
            var bunk = DapperHelper.GetList<Bunk>(sql).FirstOrDefault();
            return bunk;
        }

        /// <summary>
        /// 修改床位的信息
        /// </summary>
        /// <param name="bunk"></param>
        /// <returns></returns>
        public int UpdateBunk(Bunk bunk)
        {
            string sql = $"update Bunk set BunkNo='{bunk.BunkNo}',DormitoryId='{bunk.DormitoryId}',IsEnable='{bunk.IsEnable}' where Id={bunk.Id}";
            var i = DapperHelper.ExecuteSQL(sql);
            return i;
        }
    }
}
