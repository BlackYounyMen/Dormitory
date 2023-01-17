using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using DormManage.Model;
using DormManage.BLL.StayManage;

namespace DormManage.UI.StayManage
{
    /// <summary>
    /// 添加员工入住信息
    /// </summary>
    public partial class StaffCheckInAddFrm : Form
    {
        public StaffCheckInAddFrm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 实例化
        /// </summary>
        StaffCheckInBll staffCheckInBll = new StaffCheckInBll();

        /// <summary>
        /// 窗体加载事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmAddStaffCheckIn_Load(object sender, EventArgs e)
        {
            GetStaffList();
            GetDormitorieList();
        }

        /// <summary>
        /// 绑定员工下拉框
        /// </summary>
        public void GetStaffList()
        {
            var staffList = staffCheckInBll.GetStaffList(0);
            staffList.Insert(0, new StaffDto { Id = 0, Name = "请选择" });
            cmbName.DisplayMember = "Name";
            cmbName.ValueMember = "Id";
            cmbName.DataSource = staffList;
        }

        /// <summary>
        /// 员工姓名下拉框选择事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                var staff = staffCheckInBll.GetStaffList(id).FirstOrDefault();
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

        /// <summary>
        /// 保存按钮点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(cmbName.SelectedValue) == 0)
            {
                cmbName.Focus();
                return;
            }
            if (Convert.ToInt32(cmbDormitory.SelectedValue) == 0)
            {
                cmbDormitory.Focus();
                return;
            }
            if (Convert.ToInt32(cmbBunk.SelectedValue) == 0)
            {
                cmbBunk.Focus();
                return;
            }
            StaffCheckIn staffCheckIn = new StaffCheckIn();
            staffCheckIn.StaffId = Convert.ToInt32(cmbName.SelectedValue);
            staffCheckIn.Money = Convert.ToInt32(cmbMoney.SelectedItem);
            staffCheckIn.Treaty = rdoTreatyYes.Checked ? true : false;
            staffCheckIn.Access = rdoAccessYes.Checked ? true : false;
            staffCheckIn.TowerParent = rdoTowerParentYes.Checked ? true : false;
            staffCheckIn.DormParent = rdoDormParentYes.Checked ? true : false;
            staffCheckIn.CheckInTime = dateCheckIn.Value;
            staffCheckIn.DormitoryId = Convert.ToInt32(cmbDormitory.SelectedValue);
            staffCheckIn.BunkId = Convert.ToInt32(cmbBunk.SelectedValue);
            var i = staffCheckInBll.Add(staffCheckIn);
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
        /// 绑定宿舍下拉框
        /// </summary>
        public void GetDormitorieList()
        {
            var dormitorieList = staffCheckInBll.GetDormitorieList();
            dormitorieList.Insert(0, new Dormitory { Id = 0, DormitoryNo = "请选择" });
            cmbDormitory.DisplayMember = "DormitoryNo";
            cmbDormitory.ValueMember = "Id";
            cmbDormitory.DataSource = dormitorieList;
        }

        /// <summary>
        /// 绑定床位下拉框
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbDormitory_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cmbBunk.Items.Count > 0)
            {
                cmbBunk.DataSource = null;
                cmbBunk.Items.Clear();
            }
            int dormId = (int)cmbDormitory.SelectedValue;
            var bunkList = staffCheckInBll.GetBunkList(dormId);
            cmbBunk.DisplayMember = "BunkNo";
            cmbBunk.ValueMember = "Id";
            cmbBunk.DataSource = bunkList;
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
