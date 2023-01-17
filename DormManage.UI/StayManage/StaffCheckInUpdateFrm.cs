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
    public partial class StaffCheckInUpdateFrm : Form
    {
        /// <summary>
        /// 定义全局变量
        /// </summary>
        public int checkInId;
        public StaffCheckInUpdateFrm(int id)
        {
            checkInId = id;
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
        private void FrmUpdateStaffCheckIn_Load(object sender, EventArgs e)
        {
            GetDormitorieList();
            GetStaff();
        }

        /// <summary>
        /// 保存按钮点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
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
            staffCheckIn.Id = checkInId;
            staffCheckIn.Money = Convert.ToInt32(cmbMoney.SelectedItem);
            staffCheckIn.Treaty = rdoTreatyYes.Checked ? true : false;
            staffCheckIn.Access = rdoAccessYes.Checked ? true : false;
            staffCheckIn.TowerParent = rdoTowerParentYes.Checked ? true : false;
            staffCheckIn.DormParent = rdoDormParentYes.Checked ? true : false;
            staffCheckIn.CheckInTime = dateCheckIn.Value;
            staffCheckIn.DormitoryId = Convert.ToInt32(cmbDormitory.SelectedValue);
            staffCheckIn.BunkId = Convert.ToInt32(cmbBunk.SelectedValue);
            var i = staffCheckInBll.Update(staffCheckIn);
            if (i > 0)
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("修改失败", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        /// <summary>
        /// 反填数据
        /// </summary>
        public void GetStaff()
        {
            var staff = staffCheckInBll.GetStaffCheckInById(checkInId);
            lblName.Text = staff.Name;
            lblEmpNo.Text = staff.EmpNo;
            lblSex.Text = staff.Sex == true ? "男" : "女";
            lblTypeId.Text = staff.TypeId == true ? "员工" : "工人";
            lblDepartment.Text = staff.StairName;
            lblStation.Text = staff.StairName;
            lblMobile.Text = staff.Mobile;
            lblEmergencyName.Text = staff.EmergencyName;
            lblEmergencyMobile.Text = staff.EmergencyMobile;
            cmbMoney.Text = staff.Money.ToString();
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
            cmbDormitory.SelectedValue = staff.DormitoryId;
            GetBunkList(staff.DormitoryId);
            cmbBunk.SelectedValue = staff.BunkId;
            dateCheckIn.Value = staff.CheckInTime;
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
        /// 获取宿舍对应的床位信息
        /// </summary>
        /// <param name="id"></param>
        public void GetBunkList(int id)
        {
            var bunkList = staffCheckInBll.GetBunkList(id);
            cmbBunk.DisplayMember = "BunkNo";
            cmbBunk.ValueMember = "Id";
            cmbBunk.DataSource = bunkList;
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
    }
}
