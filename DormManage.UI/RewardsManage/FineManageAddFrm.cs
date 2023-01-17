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
    public partial class FineManageAddFrm : Form
    {
        public FineManageAddFrm()
        {
            InitializeComponent();
        }

        FineManageBll fineManageBll = new FineManageBll();

        private void cmbName_SelectionChangeCommitted(object sender, EventArgs e)
        {
            lblEmpNo.Text = string.Empty;
            lblDepartment.Text = string.Empty;
            lblStation.Text = string.Empty;
            int id = (int)cmbName.SelectedValue;
            if (id > 0)
            {
                var staff = fineManageBll.GetStaffList(id).FirstOrDefault();
                lblEmpNo.Text = staff.EmpNo;
                lblDepartment.Text = staff.StairName;
                lblStation.Text = staff.StairName;
            }
        }

        /// <summary>
        /// 绑定员工下拉框
        /// </summary>
        public void GetStaffList(int id)
        {
            var staffList = fineManageBll.GetStaffList(id);
            staffList.Insert(0, new StaffDto { Id = 0, Name = "请选择" });
            cmbName.DisplayMember = "Name";
            cmbName.ValueMember = "Id";
            cmbName.DataSource = staffList;
        }

        private void FineManageAddFrm_Load(object sender, EventArgs e)
        {
            GetStaffList(0);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Fine fine = new Fine()
            {
                StaffId = (int)cmbName.SelectedValue,
                Matter = rchMatter.Text,
                Pursuant = rchPursuant.Text,
                Money = Convert.ToInt32(txtMoney.Text),
                AddTime = dateAddTime.Value,
                Remark = rchRemark.Text
            };
            var i = fineManageBll.Add(fine);
            if (i > 0)
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("保存失败", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
