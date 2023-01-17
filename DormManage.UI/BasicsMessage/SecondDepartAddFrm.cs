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
    /// 二级部门添加窗体
    /// </summary>
    public partial class SecondDepartAddFrm : Form
    {
        public SecondDepartAddFrm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 实例化
        /// </summary>
        DepartmentBll bll = new DepartmentBll();

        /// <summary>
        /// 窗体加载事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SecondDepartAddFrm_Load(object sender, EventArgs e)
        {
            GetSecondDepartList();
        }

        /// <summary>
        /// 获取一级部信息
        /// </summary>
        public void GetSecondDepartList()
        {
            var secondDepartList = bll.GetStairDepartmentList();
            cmbParentId.DisplayMember = "StairName";
            cmbParentId.ValueMember = "Id";
            cmbParentId.DataSource = secondDepartList;
        }

        /// <summary>
        /// 添加按钮点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddDepartment_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSecondName.Text.Trim()))
            {
                txtSecondName.Focus();
                return;
            }
            Station station = new Station()
            {
                SecondName = this.txtSecondName.Text.Trim(),
                ParentId = Convert.ToInt32(cmbParentId.SelectedValue),
                IsEnable = rdoYIsEnable.Checked ? true : false
            };
            var i = bll.AddStation(station);
            if (i > 0)
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
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
