using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Dapper;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DormManage.Common
{
    /// <summary>
    /// Dapper帮助类
    /// </summary>
    public class DapperHelper
    {
        /// <summary>
        /// 读取配置文件 连接数据库字符串
        /// </summary>
        public static string connectionStr = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;
        /// <summary>
        /// 返回指定数据
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static List<T> GetList<T>(string sql)
        {
            //异常处理
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionStr))
                {
                    List<T> list = conn.Query<T>(sql).ToList();
                    return list;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// 返回受影响的行数
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static int ExecuteSQL(string sql)
        {
            //异常处理
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionStr))
                {
                    int i = conn.Execute(sql);
                    return i;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// 返回首行首列
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static object ExecuteScalar(string sql)
        {
            //异常处理
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionStr))
                {
                    var i = conn.ExecuteScalar(sql);
                    return i;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
