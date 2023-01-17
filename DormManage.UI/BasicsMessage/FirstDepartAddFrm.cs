using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using DormManage.BLL.BasicsMessage;
using DormManage.Model;

namespace DormManage.UI.BasicsMessage
{
    /// <summary>
    /// 一级部门添加窗体
    /// </summary>
    public partial class FirstDepartAddFrm : Form
    {
        public FirstDepartAddFrm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 实例化
        /// </summary>
        DepartmentBll bll = new DepartmentBll();

        /// <summary>
        /// 添加点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddDepart_Click(object sender, EventArgs e)
        {
            //名称
            var stairName = this.txtStairName.Text.Trim();
            //是否启用
            var IsEnable = rdoYIsEnable.Checked ? true : false;
            //判断非空
            if (string.IsNullOrEmpty(stairName))
            {
                txtStairName.Focus();
                return;
            }
            //添加值
            Department department = new Department()
            {
                StairName = stairName,
                IsEnable = IsEnable
            };
            var result = bll.AddDepartment(department);
            if (result > 0)
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("添加失败");
            }
        }

        /// <summary>
        /// 关闭窗体
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
