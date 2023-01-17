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
    /// 宿舍维护 业务逻辑层
    /// </summary>
    public class DormitoryBll
    {
        /// <summary>
        /// 实例化
        /// </summary>
        DormitoryDal dormitoryDal = new DormitoryDal();

        /// <summary>
        /// 获取宿舍信息
        /// </summary>
        /// <returns></returns>
        public List<Dormitory> GetDormList()
        {
            var dormList = dormitoryDal.GetDormList();
            return dormList;
        }

        /// <summary>
        /// 根据id获取宿舍信息
        /// </summary>
        /// <returns></returns>
        public Dormitory GetDormById(int Id)
        {
            var dormitory = dormitoryDal.GetDormById(Id);
            return dormitory;
        }

        /// <summary>
        /// 添加宿舍信息
        /// </summary>
        /// <returns></returns>
        public int Add(Dormitory dormitory)
        {
            var i = dormitoryDal.Add(dormitory);
            return i;
        }
        /// <summary>
        /// 修改宿舍信息
        /// </summary>
        /// <returns></returns>
        public int Update(Dormitory depadorm)
        {
            var i = dormitoryDal.Update(depadorm);
            return i;
        }
    }
}
