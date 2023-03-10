using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using DormManage.BLL.RewardsManage;
using DormManage.Model;

namespace DormManage.UI.RewardsManage
{
    /// <summary>
    /// 添加奖励信息 窗体
    /// </summary>
    public partial class AwardManageAddFrm : Form
    {
        public AwardManageAddFrm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 实例化
        /// </summary>
        AwardManageBll awardManageBll = new AwardManageBll();

        /// <summary>
        /// 窗体加载事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AwardManageAddFrm_Load(object sender, EventArgs e)
        {
            GetStaffList(0);
        }

        /// <summary>
        /// 绑定员工下拉框
        /// </summary>
        public void GetStaffList(int id)
        {
            var staffList = awardManageBll.GetStaffList(id);
            staffList.Insert(0, new StaffDto { Id = 0, Name = "请选择" });
            cmbName.DisplayMember = "Name";
            cmbName.ValueMember = "Id";
            cmbName.DataSource = staffList;
        }

        /// <summary>
        /// 下拉框选择事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbName_SelectionChangeCommitted(object sender, EventArgs e)
        {
            lblEmpNo.Text = string.Empty;
            lblDepartment.Text = string.Empty;
            lblStation.Text = string.Empty;
            int id = (int)cmbName.SelectedValue;
            if (id > 0)
            {
                var staff = awardManageBll.GetStaffList(id).FirstOrDefault();
                lblEmpNo.Text = staff.EmpNo;
                lblDepartment.Text = staff.StairName;
                lblStation.Text = staff.StairName;
            }
        }

        /// <summary>
        /// 保存按钮点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            Reward reward = new Reward()
            {
                StaffId = (int)cmbName.SelectedValue,
                Matter = rchMatter.Text,
                Pursuant = rchPursuant.Text,
                Money = Convert.ToInt32(txtMoney.Text),
                AddTime = dateAddTime.Value,
                Remark = rchRemark.Text
            };
            var i = awardManageBll.Add(reward);
            if (i > 0)
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("保存失败", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
