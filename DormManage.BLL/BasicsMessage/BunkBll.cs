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
    /// 床位维护 业务逻辑层
    /// </summary>
    public class BunkBll
    {
        /// <summary>
        /// 实例化床位维护 数据访问层
        /// </summary>
        BunkDal bunkdal = new BunkDal();

        /// <summary>
        /// 获取所有宿舍信息
        /// </summary>
        /// <returns></returns>
        public List<Dormitory> GetDormitoryList()
        {
            var dormitoryList = bunkdal.GetDormitoryList();
            return dormitoryList;
        }

        /// <summary>
        /// 两表联查 显示宿舍信息
        /// </summary>
        /// <returns></returns>
        public List<DormitoryBunkDto> GetBunkList()
        {
            var dormitorybunkList = bunkdal.GetBunkList();
            return dormitorybunkList;
        }

        /// <summary>
        /// 添加床位信息
        /// </summary>
        /// <param name="bunk"></param>
        /// <returns></returns>
        public int AddBunk(Bunk bunk)
        {
            var i = bunkdal.AddBunk(bunk);
            return i;
        }

        /// <summary>
        /// 根据ID获取床位的第一条数据
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Bunk GetBunkById(int id)
        {
            var bunk = bunkdal.GetBunkById(id);
            return bunk;
        }

        /// <summary>
        /// 修改床位的信息
        /// </summary>
        /// <param name="bunk"></param>
        /// <returns></returns>
        public int UpdateBunk(Bunk bunk)
        {
            var i = bunkdal.UpdateBunk(bunk);
            return i;
        }
    }
}
