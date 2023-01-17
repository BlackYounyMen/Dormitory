using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using DormManage.BLL;
using DormManage.Model;

namespace DormManage.UI
{
    /// <summary>
    /// 登录窗体
    /// </summary>
    public partial class LoginFrm : Form
    {
        /// <summary>
        /// 构造函数初始化
        /// </summary>
        public LoginFrm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 实例化用户业务逻辑类
        /// </summary>
        UserBll userBll = new UserBll();

        /// <summary>
        /// 登录点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string account = txtAccount.Text.Trim();
            string password = txtPassword.Text.Trim();
            var user = userBll.Login(account, password);
            if (user != null)
            {
                this.Hide();
                MainFrm main = new MainFrm();
                main.Show();
            }
            else
            {
                MessageBox.Show("登录失败！");
            }
        }

        /// <summary>
        /// 重置点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReset_Click(object sender, EventArgs e)
        {
            txtAccount.Text = string.Empty;
            txtPassword.Text = string.Empty;    
        }

        private void FrmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Environment.Exit(0);
        }
    }
}
