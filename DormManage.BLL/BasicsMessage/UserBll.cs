using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DormManage.DAL;
using DormManage.Model;

namespace DormManage.BLL
{
    /// <summary>
    /// 用户管理 数据访问层
    /// </summary>
    public class UserBll
    {
        /// <summary>
        /// 实例化用户管理 数据访问层
        /// </summary>
        UserDal userDal = new UserDal();

        /// <summary>
        /// 登录 根据账号 密码 获取用户信息
        /// </summary>
        /// <param name="account">账号</param>
        /// <param name="password">密码</param>
        /// <returns></returns>
        public User Login(string account, string password)
        {
            var user = userDal.Login(account, password);
            return user;
        }
    }
}
