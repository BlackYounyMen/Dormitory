
namespace DormManage.UI
{
    partial class MainFrm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFrm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.基础信息维护ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Department = new System.Windows.Forms.ToolStripMenuItem();
            this.Station = new System.Windows.Forms.ToolStripMenuItem();
            this.Staff = new System.Windows.Forms.ToolStripMenuItem();
            this.Dormitory = new System.Windows.Forms.ToolStripMenuItem();
            this.Bunk = new System.Windows.Forms.ToolStripMenuItem();
            this.住宿管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StaffCheckIn = new System.Windows.Forms.ToolStripMenuItem();
            this.CheckInWithhold = new System.Windows.Forms.ToolStripMenuItem();
            this.StaffStayOut = new System.Windows.Forms.ToolStripMenuItem();
            this.StayOutWithhold = new System.Windows.Forms.ToolStripMenuItem();
            this.奖惩管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Reward = new System.Windows.Forms.ToolStripMenuItem();
            this.Fine = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.基础信息维护ToolStripMenuItem,
            this.住宿管理ToolStripMenuItem,
            this.奖惩管理ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1127, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 基础信息维护ToolStripMenuItem
            // 
            this.基础信息维护ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Department,
            this.Station,
            this.Staff,
            this.Dormitory,
            this.Bunk});
            this.基础信息维护ToolStripMenuItem.Name = "基础信息维护ToolStripMenuItem";
            this.基础信息维护ToolStripMenuItem.Size = new System.Drawing.Size(113, 24);
            this.基础信息维护ToolStripMenuItem.Text = "基础信息维护";
         
            // 
            // Department
            // 
            this.Department.Name = "Department";
            this.Department.Size = new System.Drawing.Size(224, 26);
            this.Department.Text = "一级部门维护";
            this.Department.Click += new System.EventHandler(this.Department_Click);
            // 
            // Station
            // 
            this.Station.Name = "Station";
            this.Station.Size = new System.Drawing.Size(224, 26);
            this.Station.Text = "二级部门维护";
            this.Station.Click += new System.EventHandler(this.Station_Click);
            // 
            // Staff
            // 
            this.Staff.Name = "Staff";
            this.Staff.Size = new System.Drawing.Size(224, 26);
            this.Staff.Text = "员工维护";
            this.Staff.Click += new System.EventHandler(this.Staff_Click);
            // 
            // Dormitory
            // 
            this.Dormitory.Name = "Dormitory";
            this.Dormitory.Size = new System.Drawing.Size(224, 26);
            this.Dormitory.Text = "宿舍维护";
            this.Dormitory.Click += new System.EventHandler(this.Dormitory_Click);
            // 
            // Bunk
            // 
            this.Bunk.Name = "Bunk";
            this.Bunk.Size = new System.Drawing.Size(224, 26);
            this.Bunk.Text = "床位维护";
            this.Bunk.Click += new System.EventHandler(this.Bunk_Click);
            // 
            // 住宿管理ToolStripMenuItem
            // 
            this.住宿管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StaffCheckIn,
            this.CheckInWithhold,
            this.StaffStayOut,
            this.StayOutWithhold});
            this.住宿管理ToolStripMenuItem.Name = "住宿管理ToolStripMenuItem";
            this.住宿管理ToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.住宿管理ToolStripMenuItem.Text = "住宿管理";
            // 
            // StaffCheckIn
            // 
            this.StaffCheckIn.Name = "StaffCheckIn";
            this.StaffCheckIn.Size = new System.Drawing.Size(152, 26);
            this.StaffCheckIn.Text = "入住管理";
            this.StaffCheckIn.Click += new System.EventHandler(this.StaffCheckIn_Click);
            // 
            // CheckInWithhold
            // 
            this.CheckInWithhold.Name = "CheckInWithhold";
            this.CheckInWithhold.Size = new System.Drawing.Size(152, 26);
            this.CheckInWithhold.Text = "住宿扣款";
            this.CheckInWithhold.Click += new System.EventHandler(this.CheckInWithhold_Click);
            // 
            // StaffStayOut
            // 
            this.StaffStayOut.Name = "StaffStayOut";
            this.StaffStayOut.Size = new System.Drawing.Size(152, 26);
            this.StaffStayOut.Text = "退宿管理";
            this.StaffStayOut.Click += new System.EventHandler(this.StaffStayOut_Click);
            // 
            // StayOutWithhold
            // 
            this.StayOutWithhold.Name = "StayOutWithhold";
            this.StayOutWithhold.Size = new System.Drawing.Size(152, 26);
            this.StayOutWithhold.Text = "退宿扣款";
            this.StayOutWithhold.Click += new System.EventHandler(this.StayOutWithhold_Click);
            // 
            // 奖惩管理ToolStripMenuItem
            // 
            this.奖惩管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Reward,
            this.Fine});
            this.奖惩管理ToolStripMenuItem.Name = "奖惩管理ToolStripMenuItem";
            this.奖惩管理ToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.奖惩管理ToolStripMenuItem.Text = "奖惩管理";
            // 
            // Reward
            // 
            this.Reward.Name = "Reward";
            this.Reward.Size = new System.Drawing.Size(152, 26);
            this.Reward.Text = "奖励管理";
            this.Reward.Click += new System.EventHandler(this.Reward_Click);
            // 
            // Fine
            // 
            this.Fine.Name = "Fine";
            this.Fine.Size = new System.Drawing.Size(152, 26);
            this.Fine.Text = "处罚管理";
            this.Fine.Click += new System.EventHandler(this.Fine_Click);
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1127, 634);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "宿舍管理系统";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainFrm_FormClosing);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 基础信息维护ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Department;
        private System.Windows.Forms.ToolStripMenuItem Station;
        private System.Windows.Forms.ToolStripMenuItem Staff;
        private System.Windows.Forms.ToolStripMenuItem Dormitory;
        private System.Windows.Forms.ToolStripMenuItem Bunk;
        private System.Windows.Forms.ToolStripMenuItem 住宿管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem StaffCheckIn;
        private System.Windows.Forms.ToolStripMenuItem CheckInWithhold;
        private System.Windows.Forms.ToolStripMenuItem StaffStayOut;
        private System.Windows.Forms.ToolStripMenuItem StayOutWithhold;
        private System.Windows.Forms.ToolStripMenuItem 奖惩管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Reward;
        private System.Windows.Forms.ToolStripMenuItem Fine;
    }
}