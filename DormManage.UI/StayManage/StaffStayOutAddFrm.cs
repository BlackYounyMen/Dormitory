using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using DormManage.BLL.StayManage;
using DormManage.Model;

namespace DormManage.UI.StayManage
{
    public partial class StaffStayOutAddFrm : Form
    {
        /// <summary>
        /// 实例化
        /// </summary>
        private StaffStayOutBll staffStayOutBll = new StaffStayOutBll();

        public StaffStayOutAddFrm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 绑定员工下拉框
        /// </summary>
        public void GetStaffList()
        {
            var staffList = staffStayOutBll.GetStaffList(0);
            staffList.Insert(0, new StaffStayOutDto { Id = 0, Name = "请选择" });
            cmbName.DisplayMember = "Name";
            cmbName.ValueMember = "Id";
            cmbName.DataSource = staffList;
        }

        private void StaffStayOutAddFrm_Load(object sender, EventArgs e)
        {
            GetStaffList();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbName_SelectionChangeCommitted(object sender, EventArgs e)
        {
            lblEmpNo.Text = string.Empty;
            lblSex.Text = string.Empty;
            lblTypeId.Text = string.Empty;
            lblDepartment.Text = string.Empty;
            lblStation.Text = string.Empty;
            lblMobile.Text = string.Empty;
            lblEmergencyName.Text = string.Empty;
            lblEmergencyMobile.Text = string.Empty;
            int id = (int)cmbName.SelectedValue;
            if (id > 0)
            {
                var staff = staffStayOutBll.GetStaffList(id).FirstOrDefault();
                lblEmpNo.Text = staff.EmpNo;
                lblSex.Text = staff.Sex == true ? "男" : "女";
                lblTypeId.Text = staff.TypeId == true ? "员工" : "工人";
                lblDepartment.Text = staff.StairName;
                lblStation.Text = staff.StairName;
                lblMobile.Text = staff.Mobile;
                lblEmergencyName.Text = staff.EmergencyName;
                lblEmergencyMobile.Text = staff.EmergencyMobile;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(cmbName.SelectedValue) == 0)
            {
                cmbName.Focus();
                return;
            }
            if (Convert.ToInt32(cmbMoney.SelectedItem) == 0)
            {
                cmbMoney.Focus();
                return;
            }
            if (Convert.ToString(dateTimePicker1.Value) == "")
            {
                dateTimePicker1.Focus();
                return;
            }
            
            StaffStayOutDto staffStayOutDto = new StaffStayOutDto();
            staffStayOutDto.StaffId = Convert.ToInt32(cmbName.SelectedValue);
            staffStayOutDto.Deduction = Convert.ToInt32(cmbMoney.SelectedItem);
            staffStayOutDto.Treaty = rdoTreatyYes.Checked ? true : false;
            staffStayOutDto.Access = rdoAccessYes.Checked ? true : false;
            staffStayOutDto.TowerParent = rdoTowerParentYes.Checked ? true : false;
            staffStayOutDto.DormParent = rdoDormParentYes.Checked ? true : false;
            staffStayOutDto.CheckInTime = dateCheckIn.Value;
            staffStayOutDto.Money = Convert.ToInt32(cmbMoney.SelectedValue);
            staffStayOutDto.StayOutTime = dateTimePicker1.Value;
            var i = staffStayOutBll.Add(staffStayOutDto);
            if (i > 0)
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("保存失败", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}