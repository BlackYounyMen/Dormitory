
namespace DormManage.UI.StayManage
{
    partial class StaffCheckInAddFrm
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
            this.cmbBunk = new System.Windows.Forms.ComboBox();
            this.cmbDormitory = new System.Windows.Forms.ComboBox();
            this.lblTypeId = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.dateCheckIn = new System.Windows.Forms.DateTimePicker();
            this.panel4 = new System.Windows.Forms.Panel();
            this.rdoDormParentNo = new System.Windows.Forms.RadioButton();
            this.rdoDormParentYes = new System.Windows.Forms.RadioButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.rdoTowerParentNo = new System.Windows.Forms.RadioButton();
            this.rdoTowerParentYes = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rdoAccessNo = new System.Windows.Forms.RadioButton();
            this.rdoAccessYes = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rdoTreatyNo = new System.Windows.Forms.RadioButton();
            this.rdoTreatyYes = new System.Windows.Forms.RadioButton();
            this.cmbMoney = new System.Windows.Forms.ComboBox();
            this.lblEmergencyMobile = new System.Windows.Forms.Label();
            this.lblEmergencyName = new System.Windows.Forms.Label();
            this.lblMobile = new System.Windows.Forms.Label();
            this.lblStation = new System.Windows.Forms.Label();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.lblEmpNo = new System.Windows.Forms.Label();
            this.lblSex = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbName = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbBunk
            // 
            this.cmbBunk.FormattingEnabled = true;
            this.cmbBunk.Location = new System.Drawing.Point(460, 259);
            this.cmbBunk.Name = "cmbBunk";
            this.cmbBunk.Size = new System.Drawing.Size(136, 23);
            this.cmbBunk.TabIndex = 73;
            // 
            // cmbDormitory
            // 
            this.cmbDormitory.FormattingEnabled = true;
            this.cmbDormitory.Location = new System.Drawing.Point(155, 259);
            this.cmbDormitory.Name = "cmbDormitory";
            this.cmbDormitory.Size = new System.Drawing.Size(136, 23);
            this.cmbDormitory.TabIndex = 72;
            this.cmbDormitory.SelectionChangeCommitted += new System.EventHandler(this.cmbDormitory_SelectionChangeCommitted);
            // 
            // lblTypeId
            // 
            this.lblTypeId.AutoSize = true;
            this.lblTypeId.Location = new System.Drawing.Point(463, 96);
            this.lblTypeId.Name = "lblTypeId";
            this.lblTypeId.Size = new System.Drawing.Size(0, 15);
            this.lblTypeId.TabIndex = 71;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(346, 396);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 28);
            this.btnClose.TabIndex = 70;
            this.btnClose.Text = "取消";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(155, 396);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 28);
            this.btnSave.TabIndex = 69;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dateCheckIn
            // 
            this.dateCheckIn.Location = new System.Drawing.Point(155, 326);
            this.dateCheckIn.Name = "dateCheckIn";
            this.dateCheckIn.Size = new System.Drawing.Size(136, 25);
            this.dateCheckIn.TabIndex = 68;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.rdoDormParentNo);
            this.panel4.Controls.Add(this.rdoDormParentYes);
            this.panel4.Location = new System.Drawing.Point(460, 288);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(136, 28);
            this.panel4.TabIndex = 67;
            // 
            // rdoDormParentNo
            // 
            this.rdoDormParentNo.AutoSize = true;
            this.rdoDormParentNo.Location = new System.Drawing.Point(50, 8);
            this.rdoDormParentNo.Name = "rdoDormParentNo";
            this.rdoDormParentNo.Size = new System.Drawing.Size(43, 19);
            this.rdoDormParentNo.TabIndex = 1;
            this.rdoDormParentNo.Text = "否";
            this.rdoDormParentNo.UseVisualStyleBackColor = true;
            // 
            // rdoDormParentYes
            // 
            this.rdoDormParentYes.AutoSize = true;
            this.rdoDormParentYes.Checked = true;
            this.rdoDormParentYes.Location = new System.Drawing.Point(1, 8);
            this.rdoDormParentYes.Name = "rdoDormParentYes";
            this.rdoDormParentYes.Size = new System.Drawing.Size(43, 19);
            this.rdoDormParentYes.TabIndex = 0;
            this.rdoDormParentYes.TabStop = true;
            this.rdoDormParentYes.Text = "是";
            this.rdoDormParentYes.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.rdoTowerParentNo);
            this.panel3.Controls.Add(this.rdoTowerParentYes);
            this.panel3.Location = new System.Drawing.Point(155, 289);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(136, 28);
            this.panel3.TabIndex = 66;
            // 
            // rdoTowerParentNo
            // 
            this.rdoTowerParentNo.AutoSize = true;
            this.rdoTowerParentNo.Location = new System.Drawing.Point(50, 8);
            this.rdoTowerParentNo.Name = "rdoTowerParentNo";
            this.rdoTowerParentNo.Size = new System.Drawing.Size(43, 19);
            this.rdoTowerParentNo.TabIndex = 1;
            this.rdoTowerParentNo.Text = "否";
            this.rdoTowerParentNo.UseVisualStyleBackColor = true;
            // 
            // rdoTowerParentYes
            // 
            this.rdoTowerParentYes.AutoSize = true;
            this.rdoTowerParentYes.Checked = true;
            this.rdoTowerParentYes.Location = new System.Drawing.Point(1, 8);
            this.rdoTowerParentYes.Name = "rdoTowerParentYes";
            this.rdoTowerParentYes.Size = new System.Drawing.Size(43, 19);
            this.rdoTowerParentYes.TabIndex = 0;
            this.rdoTowerParentYes.TabStop = true;
            this.rdoTowerParentYes.Text = "是";
            this.rdoTowerParentYes.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rdoAccessNo);
            this.panel2.Controls.Add(this.rdoAccessYes);
            this.panel2.Location = new System.Drawing.Point(460, 221);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(136, 28);
            this.panel2.TabIndex = 65;
            // 
            // rdoAccessNo
            // 
            this.rdoAccessNo.AutoSize = true;
            this.rdoAccessNo.Location = new System.Drawing.Point(50, 8);
            this.rdoAccessNo.Name = "rdoAccessNo";
            this.rdoAccessNo.Size = new System.Drawing.Size(43, 19);
            this.rdoAccessNo.TabIndex = 1;
            this.rdoAccessNo.Text = "否";
            this.rdoAccessNo.UseVisualStyleBackColor = true;
            // 
            // rdoAccessYes
            // 
            this.rdoAccessYes.AutoSize = true;
            this.rdoAccessYes.Checked = true;
            this.rdoAccessYes.Location = new System.Drawing.Point(1, 8);
            this.rdoAccessYes.Name = "rdoAccessYes";
            this.rdoAccessYes.Size = new System.Drawing.Size(43, 19);
            this.rdoAccessYes.TabIndex = 0;
            this.rdoAccessYes.TabStop = true;
            this.rdoAccessYes.Text = "是";
            this.rdoAccessYes.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rdoTreatyNo);
            this.panel1.Controls.Add(this.rdoTreatyYes);
            this.panel1.Location = new System.Drawing.Point(155, 221);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(136, 28);
            this.panel1.TabIndex = 64;
            // 
            // rdoTreatyNo
            // 
            this.rdoTreatyNo.AutoSize = true;
            this.rdoTreatyNo.Location = new System.Drawing.Point(50, 8);
            this.rdoTreatyNo.Name = "rdoTreatyNo";
            this.rdoTreatyNo.Size = new System.Drawing.Size(43, 19);
            this.rdoTreatyNo.TabIndex = 1;
            this.rdoTreatyNo.Text = "否";
            this.rdoTreatyNo.UseVisualStyleBackColor = true;
            // 
            // rdoTreatyYes
            // 
            this.rdoTreatyYes.AutoSize = true;
            this.rdoTreatyYes.Checked = true;
            this.rdoTreatyYes.Location = new System.Drawing.Point(1, 8);
            this.rdoTreatyYes.Name = "rdoTreatyYes";
            this.rdoTreatyYes.Size = new System.Drawing.Size(43, 19);
            this.rdoTreatyYes.TabIndex = 0;
            this.rdoTreatyYes.TabStop = true;
            this.rdoTreatyYes.Text = "是";
            this.rdoTreatyYes.UseVisualStyleBackColor = true;
            // 
            // cmbMoney
            // 
            this.cmbMoney.FormattingEnabled = true;
            this.cmbMoney.Items.AddRange(new object[] {
            "0",
            "100",
            "200"});
            this.cmbMoney.Location = new System.Drawing.Point(156, 191);
            this.cmbMoney.Name = "cmbMoney";
            this.cmbMoney.Size = new System.Drawing.Size(135, 23);
            this.cmbMoney.TabIndex = 63;
            this.cmbMoney.Text = "0";
            // 
            // lblEmergencyMobile
            // 
            this.lblEmergencyMobile.AutoSize = true;
            this.lblEmergencyMobile.Location = new System.Drawing.Point(463, 199);
            this.lblEmergencyMobile.Name = "lblEmergencyMobile";
            this.lblEmergencyMobile.Size = new System.Drawing.Size(0, 15);
            this.lblEmergencyMobile.TabIndex = 62;
            // 
            // lblEmergencyName
            // 
            this.lblEmergencyName.AutoSize = true;
            this.lblEmergencyName.Location = new System.Drawing.Point(463, 165);
            this.lblEmergencyName.Name = "lblEmergencyName";
            this.lblEmergencyName.Size = new System.Drawing.Size(0, 15);
            this.lblEmergencyName.TabIndex = 61;
            // 
            // lblMobile
            // 
            this.lblMobile.AutoSize = true;
            this.lblMobile.Location = new System.Drawing.Point(156, 165);
            this.lblMobile.Name = "lblMobile";
            this.lblMobile.Size = new System.Drawing.Size(0, 15);
            this.lblMobile.TabIndex = 60;
            // 
            // lblStation
            // 
            this.lblStation.AutoSize = true;
            this.lblStation.Location = new System.Drawing.Point(466, 130);
            this.lblStation.Name = "lblStation";
            this.lblStation.Size = new System.Drawing.Size(0, 15);
            this.lblStation.TabIndex = 59;
            // 
            // lblDepartment
            // 
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.Location = new System.Drawing.Point(155, 131);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(0, 15);
            this.lblDepartment.TabIndex = 58;
            // 
            // lblEmpNo
            // 
            this.lblEmpNo.AutoSize = true;
            this.lblEmpNo.Location = new System.Drawing.Point(463, 63);
            this.lblEmpNo.Name = "lblEmpNo";
            this.lblEmpNo.Size = new System.Drawing.Size(0, 15);
            this.lblEmpNo.TabIndex = 57;
            // 
            // lblSex
            // 
            this.lblSex.AutoSize = true;
            this.lblSex.Location = new System.Drawing.Point(156, 97);
            this.lblSex.Name = "lblSex";
            this.lblSex.Size = new System.Drawing.Size(0, 15);
            this.lblSex.TabIndex = 56;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(67, 336);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(82, 15);
            this.label18.TabIndex = 55;
            this.label18.Text = "入住时间：";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(359, 302);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(97, 15);
            this.label17.TabIndex = 54;
            this.label17.Text = "是否宿舍长：";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(67, 302);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(82, 15);
            this.label16.TabIndex = 53;
            this.label16.Text = "是否楼长：";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(389, 268);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(67, 15);
            this.label15.TabIndex = 52;
            this.label15.Text = "床位号：";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(82, 268);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(67, 15);
            this.label14.TabIndex = 51;
            this.label14.Text = "宿舍号：";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(314, 234);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(142, 15);
            this.label13.TabIndex = 50;
            this.label13.Text = "门禁权限开通情况：";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(7, 234);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(142, 15);
            this.label12.TabIndex = 49;
            this.label12.Text = "签订住宿安全协议：";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(67, 200);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(82, 15);
            this.label11.TabIndex = 48;
            this.label11.Text = "住宿金额：";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(314, 200);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(142, 15);
            this.label10.TabIndex = 47;
            this.label10.Text = "紧急联系人手机号：";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(359, 166);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 15);
            this.label9.TabIndex = 46;
            this.label9.Text = "紧急联系人：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(82, 166);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 15);
            this.label8.TabIndex = 45;
            this.label8.Text = "手机号：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(374, 132);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 15);
            this.label7.TabIndex = 44;
            this.label7.Text = "二级部门：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(67, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 15);
            this.label6.TabIndex = 43;
            this.label6.Text = "一级部门：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(404, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 15);
            this.label5.TabIndex = 42;
            this.label5.Text = "类别：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(404, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 15);
            this.label4.TabIndex = 41;
            this.label4.Text = "工号：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(97, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 40;
            this.label3.Text = "性别：";
            // 
            // cmbName
            // 
            this.cmbName.FormattingEnabled = true;
            this.cmbName.Location = new System.Drawing.Point(155, 56);
            this.cmbName.Name = "cmbName";
            this.cmbName.Size = new System.Drawing.Size(136, 23);
            this.cmbName.TabIndex = 39;
            this.cmbName.SelectionChangeCommitted += new System.EventHandler(this.cmbName_SelectionChangeCommitted);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(97, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 38;
            this.label2.Text = "姓名：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(259, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 37;
            this.label1.Text = "员工入住";
            // 
            // StaffCheckInAddFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 470);
            this.Controls.Add(this.cmbBunk);
            this.Controls.Add(this.cmbDormitory);
            this.Controls.Add(this.lblTypeId);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dateCheckIn);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cmbMoney);
            this.Controls.Add(this.lblEmergencyMobile);
            this.Controls.Add(this.lblEmergencyName);
            this.Controls.Add(this.lblMobile);
            this.Controls.Add(this.lblStation);
            this.Controls.Add(this.lblDepartment);
            this.Controls.Add(this.lblEmpNo);
            this.Controls.Add(this.lblSex);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "StaffCheckInAddFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "添加员工入住信息";
            this.Load += new System.EventHandler(this.FrmAddStaffCheckIn_Load);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbBunk;
        private System.Windows.Forms.ComboBox cmbDormitory;
        private System.Windows.Forms.Label lblTypeId;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DateTimePicker dateCheckIn;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.RadioButton rdoDormParentNo;
        private System.Windows.Forms.RadioButton rdoDormParentYes;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton rdoTowerParentNo;
        private System.Windows.Forms.RadioButton rdoTowerParentYes;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rdoAccessNo;
        private System.Windows.Forms.RadioButton rdoAccessYes;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rdoTreatyNo;
        private System.Windows.Forms.RadioButton rdoTreatyYes;
        private System.Windows.Forms.ComboBox cmbMoney;
        private System.Windows.Forms.Label lblEmergencyMobile;
        private System.Windows.Forms.Label lblEmergencyName;
        private System.Windows.Forms.Label lblMobile;
        private System.Windows.Forms.Label lblStation;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.Label lblEmpNo;
        private System.Windows.Forms.Label lblSex;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}