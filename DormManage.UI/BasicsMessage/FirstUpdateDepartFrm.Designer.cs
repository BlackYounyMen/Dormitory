
namespace DormManage.UI.BasicsMessage
{
    partial class FirstUpdateDepartFrm
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
            this.btnUpadteDepart = new System.Windows.Forms.Button();
            this.rdoNIsEnable = new System.Windows.Forms.RadioButton();
            this.rdoYIsEnable = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.txtStairName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(256, 274);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 29);
            this.btnClose.TabIndex = 22;
            this.btnClose.Text = "取消";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnUpadteDepart
            // 
            this.btnUpadteDepart.Location = new System.Drawing.Point(97, 274);
            this.btnUpadteDepart.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpadteDepart.Name = "btnUpadteDepart";
            this.btnUpadteDepart.Size = new System.Drawing.Size(100, 29);
            this.btnUpadteDepart.TabIndex = 21;
            this.btnUpadteDepart.Text = "修改";
            this.btnUpadteDepart.UseVisualStyleBackColor = true;
            this.btnUpadteDepart.Click += new System.EventHandler(this.btnUpadteDepart_Click);
            // 
            // rdoNIsEnable
            // 
            this.rdoNIsEnable.AutoSize = true;
            this.rdoNIsEnable.Location = new System.Drawing.Point(256, 166);
            this.rdoNIsEnable.Margin = new System.Windows.Forms.Padding(4);
            this.rdoNIsEnable.Name = "rdoNIsEnable";
            this.rdoNIsEnable.Size = new System.Drawing.Size(43, 19);
            this.rdoNIsEnable.TabIndex = 20;
            this.rdoNIsEnable.Text = "否";
            this.rdoNIsEnable.UseVisualStyleBackColor = true;
            // 
            // rdoYIsEnable
            // 
            this.rdoYIsEnable.AutoSize = true;
            this.rdoYIsEnable.Checked = true;
            this.rdoYIsEnable.Location = new System.Drawing.Point(176, 166);
            this.rdoYIsEnable.Margin = new System.Windows.Forms.Padding(4);
            this.rdoYIsEnable.Name = "rdoYIsEnable";
            this.rdoYIsEnable.Size = new System.Drawing.Size(43, 19);
            this.rdoYIsEnable.TabIndex = 19;
            this.rdoYIsEnable.TabStop = true;
            this.rdoYIsEnable.Text = "是";
            this.rdoYIsEnable.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(76, 168);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 15);
            this.label3.TabIndex = 18;
            this.label3.Text = "是否启用：";
            // 
            // txtStairName
            // 
            this.txtStairName.Location = new System.Drawing.Point(176, 72);
            this.txtStairName.Margin = new System.Windows.Forms.Padding(4);
            this.txtStairName.Name = "txtStairName";
            this.txtStairName.Size = new System.Drawing.Size(190, 25);
            this.txtStairName.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 82);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 15);
            this.label2.TabIndex = 16;
            this.label2.Text = "一级部门名称：";
            // 
            // FirstUpdateDepartFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 422);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnUpadteDepart);
            this.Controls.Add(this.rdoNIsEnable);
            this.Controls.Add(this.rdoYIsEnable);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtStairName);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FirstUpdateDepartFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "编辑一级部门信息";
            this.Load += new System.EventHandler(this.FirstUpdateDepartFrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnUpadteDepart;
        private System.Windows.Forms.RadioButton rdoNIsEnable;
        private System.Windows.Forms.RadioButton rdoYIsEnable;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtStairName;
        private System.Windows.Forms.Label label2;
    }
}