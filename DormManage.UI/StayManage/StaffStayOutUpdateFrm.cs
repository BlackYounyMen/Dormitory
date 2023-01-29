using DormManage.BLL.StayManage;
using DormManage.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DormManage.UI.StayManage
{
    public partial class StaffStayOutUpdateFrm : Form
    {


        StaffCheckInBll StaffCheckInBll = new StaffCheckInBll();

        StaffStayOutBll StaffStayOutbll = new StaffStayOutBll();

        public int checkInId;

        public StaffStayOutUpdateFrm(int id)
        {
            checkInId = id;
            InitializeComponent();
        }
        public void GetStaffList()
        {
            var staffList = StaffCheckInBll.GetStaffList(0);
            staffList.Insert(0, new StaffDto { Id = 0, Name = "请选择" });
            this.cmbName.DisplayMember = "Name";
            this.cmbName.ValueMember = "Id";
       
            cmbName.DataSource = staffList;
        }

        



        private void StaffStayOutUpdateFrm_Load(object sender, EventArgs e)
        {
            var staff = StaffCheckInBll.GetStaffCheckInById(checkInId);
            cmbName.Text = staff.Name;
            lblEmpNo.Text = staff.EmpNo;
            lblSex.Text = staff.Sex == true ? "男" : "女";
            lblTypeId.Text = staff.TypeId == true ? "员工" : "工人";
            lblDepartment.Text = staff.StairName;
            lblStation.Text = staff.StairName;
            lblMobile.Text = staff.Mobile;
            lblEmergencyName.Text = staff.EmergencyName;
            lblEmergencyMobile.Text = staff.EmergencyMobile;
            cmbMoney.Text = staff.Money.ToString();
            dateCheckIn.Value = staff.CheckInTime;
            dateTimePicker1.Value = staff.StayOutTime;
            GetStaffList();
            GetStaff();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void GetStaff()
        {
            var staff = StaffCheckInBll.GetStaffCheckInById(checkInId);
            if (staff.Treaty)
                rdoTreatyYes.Checked = true;
            else
                rdoTreatyNo.Checked = true;
            if (staff.Access)
                rdoAccessYes.Checked = true;
            else
                rdoAccessNo.Checked = true;
            if (staff.TowerParent)
                rdoTowerParentYes.Checked = true;
            else
                rdoTowerParentNo.Checked = true;
            if (staff.DormParent)
                rdoDormParentYes.Checked = true;
            else
                rdoDormParentNo.Checked = true;
          
           
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            StaffStayOutDto staffStayOut = new StaffStayOutDto();
            staffStayOut.Id = checkInId;
            staffStayOut.Money = Convert.ToInt32(cmbMoney.SelectedItem);
            staffStayOut.Treaty = rdoTreatyYes.Checked ? true : false;
            staffStayOut.Access = rdoAccessYes.Checked ? true : false;
            staffStayOut.TowerParent = rdoTowerParentYes.Checked ? true : false;
            staffStayOut.DormParent = rdoDormParentYes.Checked ? true : false;
            staffStayOut.CheckInTime = dateCheckIn.Value;
            staffStayOut.StayOutTime = dateTimePicker1.Value;



            var i = StaffStayOutbll.Update(staffStayOut);
            if (i > 0)
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("修改失败", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
