
namespace DormManage.UI.BasicsMessage
{
    partial class FirstDepartAddFrm
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
            this.btnClose = new System.Windows.Forms.Button();
            this.btnAddDepart = new System.Windows.Forms.Button();
            this.rdoNIsEnable = new System.Windows.Forms.RadioButton();
            this.rdoYIsEnable = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.txtStairName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(254, 268);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 29);
            this.btnClose.TabIndex = 15;
            this.btnClose.Text = "取消";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnAddDepart
            // 
            this.btnAddDepart.Location = new System.Drawing.Point(95, 268);
            this.btnAddDepart.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddDepart.Name = "btnAddDepart";
            this.btnAddDepart.Size = new System.Drawing.Size(100, 29);
            this.btnAddDepart.TabIndex = 14;
            this.btnAddDepart.Text = "保存";
            this.btnAddDepart.UseVisualStyleBackColor = true;
            this.btnAddDepart.Click += new System.EventHandler(this.btnAddDepart_Click);
            // 
            // rdoNIsEnable
            // 
            this.rdoNIsEnable.AutoSize = true;
            this.rdoNIsEnable.Location = new System.Drawing.Point(254, 160);
            this.rdoNIsEnable.Margin = new System.Windows.Forms.Padding(4);
            this.rdoNIsEnable.Name = "rdoNIsEnable";
            this.rdoNIsEnable.Size = new System.Drawing.Size(43, 19);
            this.rdoNIsEnable.TabIndex = 13;
            this.rdoNIsEnable.Text = "否";
            this.rdoNIsEnable.UseVisualStyleBackColor = true;
            // 
            // rdoYIsEnable
            // 
            this.rdoYIsEnable.AutoSize = true;
            this.rdoYIsEnable.Checked = true;
            this.rdoYIsEnable.Location = new System.Drawing.Point(174, 160);
            this.rdoYIsEnable.Margin = new System.Windows.Forms.Padding(4);
            this.rdoYIsEnable.Name = "rdoYIsEnable";
            this.rdoYIsEnable.Size = new System.Drawing.Size(43, 19);
            this.rdoYIsEnable.TabIndex = 12;
            this.rdoYIsEnable.TabStop = true;
            this.rdoYIsEnable.Text = "是";
            this.rdoYIsEnable.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(74, 162);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "是否启用：";
            // 
            // txtStairName
            // 
            this.txtStairName.Location = new System.Drawing.Point(174, 66);
            this.txtStairName.Margin = new System.Windows.Forms.Padding(4);
            this.txtStairName.Name = "txtStairName";
            this.txtStairName.Size = new System.Drawing.Size(190, 25);
            this.txtStairName.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 76);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "一级部门名称：";
            // 
            // FirstDepartAddFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 422);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAddDepart);
            this.Controls.Add(this.rdoNIsEnable);
            this.Controls.Add(this.rdoYIsEnable);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtStairName);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FirstDepartAddFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "添加一级部门";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnAddDepart;
        private System.Windows.Forms.RadioButton rdoNIsEnable;
        private System.Windows.Forms.RadioButton rdoYIsEnable;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtStairName;
        private System.Windows.Forms.Label label2;
    }
}