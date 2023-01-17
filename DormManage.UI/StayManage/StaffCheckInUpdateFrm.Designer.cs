
namespace DormManage.UI.StayManage
{
    partial class StaffCheckInUpdateFrm
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
            this.lblName = new System.Windows.Forms.Label();
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(161, 65);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(0, 15);
            this.lblName.TabIndex = 111;
            // 
            // cmbBunk
            // 
            this.cmbBunk.FormattingEnabled = true;
            this.cmbBunk.Location = new System.Drawing.Point(466, 261);
            this.cmbBunk.Name = "cmbBunk";
            this.cmbBunk.Size = new System.Drawing.Size(136, 23);
            this.cmbBunk.TabIndex = 110;
            // 
            // cmbDormitory
            // 
            this.cmbDormitory.FormattingEnabled = true;
            this.cmbDormitory.Location = new System.Drawing.Point(161, 261);
            this.cmbDormitory.Name = "cmbDormitory";
            this.cmbDormitory.Size = new System.Drawing.Size(136, 23);
            this.cmbDormitory.TabIndex = 109;
            this.cmbDormitory.SelectionChangeCommitted += new System.EventHandler(this.cmbDormitory_SelectionChangeCommitted);
            // 
            // lblTypeId
            // 
            this.lblTypeId.AutoSize = true;
            this.lblTypeId.Location = new System.Drawing.Point(469, 98);
            this.lblTypeId.Name = "lblTypeId";
            this.lblTypeId.Size = new System.Drawing.Size(0, 15);
            this.lblTypeId.TabIndex = 108;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(352, 398);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 28);
            this.btnClose.TabIndex = 107;
            this.btnClose.Text = "取消";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(161, 398);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 28);
            this.btnSave.TabIndex = 106;
            this.btnSave.Text = "修改";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dateCheckIn
            // 
            this.dateCheckIn.Location = new System.Drawing.Point(161, 328);
            this.dateCheckIn.Name = "dateCheckIn";
            this.dateCheckIn.Size = new System.Drawing.Size(136, 25);
            this.dateCheckIn.TabIndex = 105;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.rdoDormParentNo);
            this.panel4.Controls.Add(this.rdoDormParentYes);
            this.panel4.Location = new System.Drawing.Point(466, 290);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(136, 28);
            this.panel4.TabIndex = 104;
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
            this.rdoDormParentYes.Location = new System.Drawing.Point(1, 8);
            this.rdoDormParentYes.Name = "rdoDormParentYes";
            this.rdoDormParentYes.Size = new System.Drawing.Size(43, 19);
            this.rdoDormParentYes.TabIndex = 0;
            this.rdoDormParentYes.Text = "是";
            this.rdoDormParentYes.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.rdoTowerParentNo);
            this.panel3.Controls.Add(this.rdoTowerParentYes);
            this.panel3.Location = new System.Drawing.Point(161, 291);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(136, 28);
            this.panel3.TabIndex = 103;
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
            this.rdoTowerParentYes.Location = new System.Drawing.Point(1, 8);
            this.rdoTowerParentYes.Name = "rdoTowerParentYes";
            this.rdoTowerParentYes.Size = new System.Drawing.Size(43, 19);
            this.rdoTowerParentYes.TabIndex = 0;
            this.rdoTowerParentYes.Text = "是";
            this.rdoTowerParentYes.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rdoAccessNo);
            this.panel2.Controls.Add(this.rdoAccessYes);
            this.panel2.Location = new System.Drawing.Point(466, 223);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(136, 28);
            this.panel2.TabIndex = 102;
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
            this.rdoAccessYes.Location = new System.Drawing.Point(1, 8);
            this.rdoAccessYes.Name = "rdoAccessYes";
            this.rdoAccessYes.Size = new System.Drawing.Size(43, 19);
            this.rdoAccessYes.TabIndex = 0;
            this.rdoAccessYes.Text = "是";
            this.rdoAccessYes.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rdoTreatyNo);
            this.panel1.Controls.Add(this.rdoTreatyYes);
            this.panel1.Location = new System.Drawing.Point(161, 223);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(136, 28);
            this.panel1.TabIndex = 101;
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
            this.rdoTreatyYes.Location = new System.Drawing.Point(1, 8);
            this.rdoTreatyYes.Name = "rdoTreatyYes";
            this.rdoTreatyYes.Size = new System.Drawing.Size(43, 19);
            this.rdoTreatyYes.TabIndex = 0;
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
            this.cmbMoney.Location = new System.Drawing.Point(162, 193);
            this.cmbMoney.Name = "cmbMoney";
            this.cmbMoney.Size = new System.Drawing.Size(135, 23);
            this.cmbMoney.TabIndex = 100;
            this.cmbMoney.Text = "0";
            // 
            // lblEmergencyMobile
            // 
            this.lblEmergencyMobile.AutoSize = true;
            this.lblEmergencyMobile.Location = new System.Drawing.Point(469, 201);
            this.lblEmergencyMobile.Name = "lblEmergencyMobile";
            this.lblEmergencyMobile.Size = new System.Drawing.Size(0, 15);
            this.lblEmergencyMobile.TabIndex = 99;
            // 
            // lblEmergencyName
            // 
            this.lblEmergencyName.AutoSize = true;
            this.lblEmergencyName.Location = new System.Drawing.Point(469, 167);
            this.lblEmergencyName.Name = "lblEmergencyName";
            this.lblEmergencyName.Size = new System.Drawing.Size(0, 15);
            this.lblEmergencyName.TabIndex = 98;
            // 
            // lblMobile
            // 
            this.lblMobile.AutoSize = true;
            this.lblMobile.Location = new System.Drawing.Point(162, 167);
            this.lblMobile.Name = "lblMobile";
            this.lblMobile.Size = new System.Drawing.Size(0, 15);
            this.lblMobile.TabIndex = 97;
            // 
            // lblStation
            // 
            this.lblStation.AutoSize = true;
            this.lblStation.Location = new System.Drawing.Point(472, 132);
            this.lblStation.Name = "lblStation";
            this.lblStation.Size = new System.Drawing.Size(0, 15);
            this.lblStation.TabIndex = 96;
            // 
            // lblDepartment
            // 
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.Location = new System.Drawing.Point(161, 133);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(0, 15);
            this.lblDepartment.TabIndex = 95;
            // 
            // lblEmpNo
            // 
            this.lblEmpNo.AutoSize = true;
            this.lblEmpNo.Location = new System.Drawing.Point(469, 65);
            this.lblEmpNo.Name = "lblEmpNo";
            this.lblEmpNo.Size = new System.Drawing.Size(0, 15);
            this.lblEmpNo.TabIndex = 94;
            // 
            // lblSex
            // 
            this.lblSex.AutoSize = true;
            this.lblSex.Location = new System.Drawing.Point(162, 99);
            this.lblSex.Name = "lblSex";
            this.lblSex.Size = new System.Drawing.Size(0, 15);
            this.lblSex.TabIndex = 93;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(73, 338);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(82, 15);
            this.label18.TabIndex = 92;
            this.label18.Text = "入住时间：";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(365, 304);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(97, 15);
            this.label17.TabIndex = 91;
            this.label17.Text = "是否宿舍长：";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(73, 304);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(82, 15);
            this.label16.TabIndex = 90;
            this.label16.Text = "是否楼长：";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(395, 270);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(67, 15);
            this.label15.TabIndex = 89;
            this.label15.Text = "床位号：";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(88, 270);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(67, 15);
            this.label14.TabIndex = 88;
            this.label14.Text = "宿舍号：";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(320, 236);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(142, 15);
            this.label13.TabIndex = 87;
            this.label13.Text = "门禁权限开通情况：";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(13, 236);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(142, 15);
            this.label12.TabIndex = 86;
            this.label12.Text = "签订住宿安全协议：";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(73, 202);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(82, 15);
            this.label11.TabIndex = 85;
            this.label11.Text = "住宿金额：";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(320, 202);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(142, 15);
            this.label10.TabIndex = 84;
            this.label10.Text = "紧急联系人手机号：";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(365, 168);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 15);
            this.label9.TabIndex = 83;
            this.label9.Text = "紧急联系人：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(88, 168);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 15);
            this.label8.TabIndex = 82;
            this.label8.Text = "手机号：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(380, 134);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 15);
            this.label7.TabIndex = 81;
            this.label7.Text = "二级部门：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(73, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 15);
            this.label6.TabIndex = 80;
            this.label6.Text = "一级部门：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(410, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 15);
            this.label5.TabIndex = 79;
            this.label5.Text = "类别：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(410, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 15);
            this.label4.TabIndex = 78;
            this.label4.Text = "工号：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(103, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 77;
            this.label3.Text = "性别：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(103, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 76;
            this.label2.Text = "姓名：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(265, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 20);
            this.label1.TabIndex = 75;
            this.label1.Text = "编辑入住信息";
            // 
            // FrmUpdateStaffCheckIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 470);
            this.Controls.Add(this.lblName);
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
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmUpdateStaffCheckIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "编辑员工入住信息";
            this.Load += new System.EventHandler(this.FrmUpdateStaffCheckIn_Load);
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

        private System.Windows.Forms.Label lblName;
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}