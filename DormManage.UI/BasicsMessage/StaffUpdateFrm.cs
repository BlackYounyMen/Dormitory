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
    public partial class StaffUpdateFrm : Form
    {
        private int staffId;
        public StaffUpdateFrm(int id)
        {
            staffId = id;
            InitializeComponent();
        }


        /// <summary>
        /// 实例化
        /// </summary>
        DepartmentBll departmentBll = new DepartmentBll();

        /// <summary>
        /// 实例化
        /// </summary>
        StaffBll staffBll = new StaffBll();

        /// <summary>
        /// 窗体加载事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StaffUpdateFrm_Load(object sender, EventArgs e)
        {
            GetSecondDepartList();
            var staff = staffBll.GetStaffById(staffId);
            txtStaffName.Text = staff.Name;
            if (staff.Sex)
                rdoStaffSex1.Checked = true;
            else
                rdoStaffSex2.Checked = true;
            if (staff.TypeId)
                rdoStaffTypeId1.Checked = true;
            else
                rdoStaffTypeId2.Checked = true;
            txtEmpNo.Text = staff.EmpNo;
            cmbStaffDepartmentId.SelectedValue = staff.DepartmentId;
            int departId = (int)cmbStaffDepartmentId.SelectedValue;
            var stationList = staffBll.GetStationList(departId);
            cmbStaffStationId.DisplayMember = "SecondName";
            cmbStaffStationId.ValueMember = "Id";
            cmbStaffStationId.DataSource = stationList;
            cmbStaffStationId.SelectedValue = staff.StationId;
            if (staff.IDCard)
                rdoStaffIDCard1.Checked = true;
            else
                rdoStaffIDCard2.Checked = true;
            txtStaffMobile.Text = staff.Mobile;
            txtStaffEmergencyName.Text = staff.EmergencyName;
            txtStaffEmergencyMobile.Text = staff.EmergencyMobile;
            dateStaffEntryTime.Value = staff.EntryTime;
            if (staff.IsEnable)
                rdoStaffIsEnable1.Checked = true;
            else
                rdoStaffIsEnable2.Checked = true;
            if (staff.IsResidence == 1)
                rdoStaffIsResidence1.Checked = true;
            if (staff.IsResidence == 2)
                rdoStaffIsResidence2.Checked = true;
            if (staff.IsResidence == 3)
                rdoStaffIsResidence3.Checked = true;
        }

        /// <summary>
        /// 获取一级部信息
        /// </summary>
        public void GetSecondDepartList()
        {
            var secondDepartList = departmentBll.GetStairDepartmentList();
            secondDepartList.Insert(0, new Department() { Id = 0, StairName = "请选择" });
            cmbStaffDepartmentId.DisplayMember = "StairName";
            cmbStaffDepartmentId.ValueMember = "Id";
            cmbStaffDepartmentId.DataSource = secondDepartList;
        }

        /// <summary>
        /// 修改按钮点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtStaffName.Text.Trim()))
            {
                txtStaffName.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtEmpNo.Text.Trim()))
            {
                txtEmpNo.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtStaffMobile.Text.Trim()))
            {
                txtStaffMobile.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtStaffEmergencyName.Text.Trim()))
            {
                txtStaffEmergencyName.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtStaffEmergencyMobile.Text.Trim()))
            {
                txtStaffEmergencyMobile.Focus();
                return;
            }
            int residence = 0;
            if (rdoStaffIsResidence1.Checked)
                residence = Convert.ToInt32(rdoStaffIsResidence1.Tag);
            if (rdoStaffIsResidence2.Checked)
                residence = Convert.ToInt32(rdoStaffIsResidence2.Tag);
            if (rdoStaffIsResidence3.Checked)
                residence = Convert.ToInt32(rdoStaffIsResidence3.Tag);
            Staff staff = new Staff()
            {
                Id=staffId,
                Name = txtStaffName.Text.Trim(),
                Sex = rdoStaffSex1.Checked ? true : false,
                TypeId = rdoStaffTypeId1.Checked ? true : false,
                EmpNo = txtEmpNo.Text.Trim(),
                DepartmentId = (int)cmbStaffDepartmentId.SelectedValue,
                StationId = (int)cmbStaffStationId.SelectedValue,
                IDCard = rdoStaffIDCard1.Checked ? true : false,
                Mobile = txtStaffMobile.Text.Trim(),
                EmergencyName = txtStaffEmergencyName.Text.Trim(),
                EmergencyMobile = txtStaffEmergencyMobile.Text.Trim(),
                EntryTime = dateStaffEntryTime.Value,
                IsEnable = rdoStaffIsEnable1.Checked ? true : false,
                IsResidence = residence
            };
            var i = staffBll.Update(staff);
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
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// 下拉框选择事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbStaffDepartmentId_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cmbStaffStationId.Items.Count > 0)
            {
                cmbStaffStationId.DataSource = null;
                cmbStaffStationId.Items.Clear();
            }
            int departId = (int)cmbStaffDepartmentId.SelectedValue;
            var stationList = staffBll.GetStationList(departId);
            cmbStaffStationId.DisplayMember = "SecondName";
            cmbStaffStationId.ValueMember = "Id";
            cmbStaffStationId.DataSource = stationList;
        }
    }
}
