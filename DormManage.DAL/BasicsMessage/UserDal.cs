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
    /// 用户管理 数据访问层
    /// </summary>
    public class UserDal
    {
        /// <summary>
        /// 登录 根据账号 密码 获取用户信息
        /// </summary>
        /// <param name="account">账号</param>
        /// <param name="password">密码</param>
        /// <returns></returns>
        public User Login(string account,string password)
        {
            try
            {
                string cmdText = $"select * from [User] where Account='{account}' and PassWord='{password}'";
                var user = DapperHelper.GetList<User>(cmdText).FirstOrDefault();
                return user;
            }
            catch (Exception)
            {
                return null;
            }
            
        }
    }
}
