using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DormManage.Common;
using DormManage.Model;

namespace DormManage.DAL
{
    /// <summary>
    /// 宿舍维护 数据访问层
    /// </summary>
    public class DormitoryDal
    {
        /// <summary>
        /// 获取宿舍信息
        /// </summary>
        /// <returns></returns>
        public List<Dormitory> GetDormList()
        {
            string cmdText = "select * from Dormitory";
            var dormList = DapperHelper.GetList<Dormitory>(cmdText);
            return dormList;
        }

        /// <summary>
        /// 根据id获取宿舍信息
        /// </summary>
        /// <returns></returns>
        public Dormitory GetDormById(int Id)
        {
            string cmdText = $"select * from Dormitory where Id={Id}";
            var dormitory = DapperHelper.GetList<Dormitory>(cmdText).FirstOrDefault();
            return dormitory;
        }

        /// <summary>
        /// 添加宿舍信息
        /// </summary>
        /// <returns></returns>
        public int Add(Dormitory dormitory)
        {
            string cmdText = $"insert into Dormitory(DormitoryNo,IsEnable) values('{dormitory.DormitoryNo}','{dormitory.IsEnable}')";
            var i = DapperHelper.ExecuteSQL(cmdText);
            return i;
        }

        /// <summary>
        /// 修改宿舍信息
        /// </summary>
        /// <returns></returns>
        public int Update(Dormitory depadorm)
        {
            string cmdText = $"Update Dormitory set DormitoryNo= '{depadorm.DormitoryNo}',IsEnable='{depadorm.IsEnable}' where Id={depadorm.Id}";
            var i = DapperHelper.ExecuteSQL(cmdText);
            return i;
        }
    }
}
