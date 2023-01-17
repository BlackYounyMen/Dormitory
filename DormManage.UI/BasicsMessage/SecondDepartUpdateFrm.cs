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
    /// 二级部门修改窗体
    /// </summary>
    public partial class SecondDepartUpdateFrm : Form
    {
        /// <summary>
        /// 定义变量
        /// </summary>
        private int departmentId;

        /// <summary>
        /// 实例化
        /// </summary>
        DepartmentBll bll = new DepartmentBll();

        public SecondDepartUpdateFrm(int id)
        {
            departmentId = id;
            InitializeComponent();
        }

        /// <summary>
        /// 窗体加载事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SecondDepartUpdateFrm_Load(object sender, EventArgs e)
        {
            GetSecondDepartList();
            var station = bll.GetStationById(departmentId);
            cmbParentId.SelectedValue = station.ParentId;
            txtSecondName.Text = station.SecondName;
            if (station.IsEnable)
                rdoYIsEnable.Checked = true;
            else
                rdoNIsEnable.Checked = true;
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
        /// 修改按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdateDepartment_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSecondName.Text.Trim()))
            {
                txtSecondName.Focus();
                return;
            }
            Station station = new Station()
            {
                Id=departmentId,
                SecondName = this.txtSecondName.Text.Trim(),
                ParentId = Convert.ToInt32(cmbParentId.SelectedValue),
                IsEnable = rdoYIsEnable.Checked ? true : false
            };
            var i = bll.UpdateStation(station);
            if (i > 0)
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("修改失败");
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
