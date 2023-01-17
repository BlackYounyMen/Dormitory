
namespace DormManage.UI.BasicsMessage
{
    partial class SecondDepartUpdateFrm
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
            this.txtSecondName = new System.Windows.Forms.TextBox();
            this.Lable4 = new System.Windows.Forms.Label();
            this.cmbParentId = new System.Windows.Forms.ComboBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnUpdateDepartment = new System.Windows.Forms.Button();
            this.rdoNIsEnable = new System.Windows.Forms.RadioButton();
            this.rdoYIsEnable = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtSecondName
            // 
            this.txtSecondName.Location = new System.Drawing.Point(171, 128);
            this.txtSecondName.Margin = new System.Windows.Forms.Padding(4);
            this.txtSecondName.Name = "txtSecondName";
            this.txtSecondName.Size = new System.Drawing.Size(190, 25);
            this.txtSecondName.TabIndex = 29;
            // 
            // Lable4
            // 
            this.Lable4.AutoSize = true;
            this.Lable4.Location = new System.Drawing.Point(81, 138);
            this.Lable4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lable4.Name = "Lable4";
            this.Lable4.Size = new System.Drawing.Size(82, 15);
            this.Lable4.TabIndex = 28;
            this.Lable4.Text = "部门名称：";
            // 
            // cmbParentId
            // 
            this.cmbParentId.FormattingEnabled = true;
            this.cmbParentId.Location = new System.Drawing.Point(171, 62);
            this.cmbParentId.Margin = new System.Windows.Forms.Padding(4);
            this.cmbParentId.Name = "cmbParentId";
            this.cmbParentId.Size = new System.Drawing.Size(190, 23);
            this.cmbParentId.TabIndex = 27;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(249, 286);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 29);
            this.btnCancel.TabIndex = 26;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnUpdateDepartment
            // 
            this.btnUpdateDepartment.Location = new System.Drawing.Point(98, 286);
            this.btnUpdateDepartment.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdateDepartment.Name = "btnUpdateDepartment";
            this.btnUpdateDepartment.Size = new System.Drawing.Size(100, 29);
            this.btnUpdateDepartment.TabIndex = 25;
            this.btnUpdateDepartment.Text = "修改";
            this.btnUpdateDepartment.UseVisualStyleBackColor = true;
            this.btnUpdateDepartment.Click += new System.EventHandler(this.btnUpdateDepartment_Click);
            // 
            // rdoNIsEnable
            // 
            this.rdoNIsEnable.AutoSize = true;
            this.rdoNIsEnable.Location = new System.Drawing.Point(293, 190);
            this.rdoNIsEnable.Margin = new System.Windows.Forms.Padding(4);
            this.rdoNIsEnable.Name = "rdoNIsEnable";
            this.rdoNIsEnable.Size = new System.Drawing.Size(43, 19);
            this.rdoNIsEnable.TabIndex = 24;
            this.rdoNIsEnable.Text = "否";
            this.rdoNIsEnable.UseVisualStyleBackColor = true;
            // 
            // rdoYIsEnable
            // 
            this.rdoYIsEnable.AutoSize = true;
            this.rdoYIsEnable.Location = new System.Drawing.Point(181, 190);
            this.rdoYIsEnable.Margin = new System.Windows.Forms.Padding(4);
            this.rdoYIsEnable.Name = "rdoYIsEnable";
            this.rdoYIsEnable.Size = new System.Drawing.Size(43, 19);
            this.rdoYIsEnable.TabIndex = 23;
            this.rdoYIsEnable.Text = "是";
            this.rdoYIsEnable.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(81, 194);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 15);
            this.label3.TabIndex = 22;
            this.label3.Text = "是否启用：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 70);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 21;
            this.label2.Text = "一级部门：";
            // 
            // SecondDepartUpdateFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 422);
            this.Controls.Add(this.txtSecondName);
            this.Controls.Add(this.Lable4);
            this.Controls.Add(this.cmbParentId);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnUpdateDepartment);
            this.Controls.Add(this.rdoNIsEnable);
            this.Controls.Add(this.rdoYIsEnable);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "SecondDepartUpdateFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "编辑二级部门";
            this.Load += new System.EventHandler(this.SecondDepartUpdateFrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSecondName;
        private System.Windows.Forms.Label Lable4;
        private System.Windows.Forms.ComboBox cmbParentId;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnUpdateDepartment;
        private System.Windows.Forms.RadioButton rdoNIsEnable;
        private System.Windows.Forms.RadioButton rdoYIsEnable;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}