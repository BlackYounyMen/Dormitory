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
    /// 查看员工基本信息
    /// </summary>
    public partial class StaffExamineFrm : Form
    {
        private int staffId;

        /// <summary>
        /// 实例化
        /// </summary>
        private StaffBll staffBll = new StaffBll();

        public StaffExamineFrm(int id)
        {
            staffId = id;
            InitializeComponent();
        }

        /// <summary>
        /// 返回按钮点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// 窗体加载事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StaffExamineFrm_Load(object sender, EventArgs e)
        {
            var staff = staffBll.GetStaffById(staffId);
            lblName.Text = staff.Name;
            lblEmpNo.Text = staff.EmpNo;
            lblSex.Text = staff.Sex ? "男" : "女";
            lblType.Text = staff.TypeId ? "工人" : "员工";
            lblDepartment.Text = staff.StairName;
            lblStation.Text = staff.SecondName;
            lblMobile.Text = staff.Mobile;
            lblEmergencyName.Text = staff.EmergencyName;
            lblEmergencyMobile.Text = staff.EmergencyMobile;
            lblIDCard.Text = staff.IDCard ? "是" : "否";
            if (staff.IsResidence == 1)
                lblIsResidence.Text = "否";
            if (staff.IsResidence == 2)
                lblIsResidence.Text = "公司办理";
            if (staff.IsResidence == 3)
                lblIsResidence.Text = "自行办理";
            lblIsEnable.Text = staff.IsEnable ? "是" : "否";
            lblEntryTime.Text = staff.EntryTime.ToString();
        }
    }
}