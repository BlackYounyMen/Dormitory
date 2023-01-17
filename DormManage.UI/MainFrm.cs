using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DormManage.UI.BasicsMessage;
using DormManage.UI.RewardsManage;

using DormManage.UI.StayManage;

namespace DormManage.UI
{
    /// <summary>
    /// 主页面窗体
    /// </summary>
    public partial class MainFrm : Form
    {
        /// <summary>
        /// 构造函数 初始化
        /// </summary>
        public MainFrm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 窗体加载事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmMain_Load(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// 一级部门维护点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void Department_Click(object sender, EventArgs e)
        {
            FirstDepartFrm firstDepartFrm = new FirstDepartFrm();
            firstDepartFrm.Name = "FirstDepartFrm";
            OpenChildForm(firstDepartFrm);
        }

        /// <summary>
        /// 二级部门维护点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Station_Click(object sender, EventArgs e)
        {
            SecondDepartFrm secondDepartFrm = new SecondDepartFrm();
            secondDepartFrm.Name = "SecondDepartFrm";
            OpenChildForm(secondDepartFrm);
        }

        /// <summary>
        /// 员工维护 点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void Staff_Click(object sender, EventArgs e)
        {
            StaffFrm staffFrm = new StaffFrm();
            staffFrm.Name = "StaffFrm";
            OpenChildForm(staffFrm);
        }

        /// <summary>
        /// 宿舍维护点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void Dormitory_Click(object sender, EventArgs e)
        {
            DormitoryFrm dormitoryFrm = new DormitoryFrm();
            dormitoryFrm.Name = "DormitoryFrm";
            OpenChildForm(dormitoryFrm);
        }

        /// <summary>
        /// 床位维护点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void Bunk_Click(object sender, EventArgs e)
        {
            BunkFrm frmBunk = new BunkFrm();
            frmBunk.Name = "FrmBunk";
            OpenChildForm(frmBunk);
        }

        /// <summary>
        /// 入住管理点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void StaffCheckIn_Click(object sender, EventArgs e)
        {
            StaffCheckInFrm frmStaffCheckIn = new StaffCheckInFrm();
            frmStaffCheckIn.Name = "FrmStaffCheckIn";
            OpenChildForm(frmStaffCheckIn);
        }

        /// <summary>
        /// 住宿扣款点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CheckInWithhold_Click(object sender, EventArgs e)
        {
            StayWithholdFrm rewardsWithholdFrm = new StayWithholdFrm();
            rewardsWithholdFrm.Name = "RewardsWithholdFrm";
            OpenChildForm(rewardsWithholdFrm);
        }

        /// <summary>
        /// 退宿管理点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StaffStayOut_Click(object sender, EventArgs e)
        {
            StaffStayOutFrm staffStayOutFrm = new StaffStayOutFrm();
            staffStayOutFrm.Name = "StaffStayOutFrm";
            OpenChildForm(staffStayOutFrm);
        }

        /// <summary>
        /// 退宿扣款点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StayOutWithhold_Click(object sender, EventArgs e)
        {
            StaffStaffStayOutFrm staffCheckInfrm = new StaffStaffStayOutFrm();
            staffCheckInfrm.Name = "StaffStaffStayOutFrm";
            OpenChildForm(staffCheckInfrm);
        }

        /// <summary>
        /// 奖励管理点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Reward_Click(object sender, EventArgs e)
        {
            AwardManageFrm awardManageFrm = new AwardManageFrm();
            awardManageFrm.Name = "AwardManageFrm";
            OpenChildForm(awardManageFrm);
        }

        /// <summary>
        /// 处罚管理点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Fine_Click(object sender, EventArgs e)
        {
            FineManageFrm fineManageFrm = new FineManageFrm();
            fineManageFrm.Name = "FineManageFrm";
            OpenChildForm(fineManageFrm);
        }

        /// <summary>
        /// 激活已经打开的子窗体
        /// </summary>
        /// <param name="formChild"></param>
        private void OpenChildForm(Form formChild)
        {
            bool isOpened = false;
            foreach (Form form in this.MdiChildren)
            {
                if (formChild.Name == form.Name)
                {
                    form.Activate();
                    form.WindowState = FormWindowState.Maximized;
                    formChild.Dispose();
                    isOpened = true;
                    break;
                }
            }

            if (!isOpened)
            {
                formChild.MdiParent = this;
                formChild.WindowState = FormWindowState.Maximized;
                formChild.Show();
            }
        }

        private void MainFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Environment.Exit(0);
        }
    }
}