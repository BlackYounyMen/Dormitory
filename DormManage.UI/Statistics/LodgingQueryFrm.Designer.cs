namespace DormManage.UI.Statistics
{
    partial class LodgingQueryFrm
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
            System.Windows.Forms.Label label6;
            this.DGV = new System.Windows.Forms.DataGridView();
            this.全部 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.一床 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.二创 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.本周退宿 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rs = new System.Windows.Forms.Label();
            this.fj = new System.Windows.Forms.Label();
            this.nv = new System.Windows.Forms.Label();
            this.nan = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.qb = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnInput = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            label6.Location = new System.Drawing.Point(317, 74);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(47, 23);
            label6.TabIndex = 10;
            label6.Text = "女:";
            // 
            // DGV
            // 
            this.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.全部,
            this.一床,
            this.二创,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10,
            this.本周退宿,
            this.Column11,
            this.Column12});
            this.DGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGV.Location = new System.Drawing.Point(0, 116);
            this.DGV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DGV.Name = "DGV";
            this.DGV.RowHeadersWidth = 51;
            this.DGV.RowTemplate.Height = 27;
            this.DGV.Size = new System.Drawing.Size(1067, 446);
            this.DGV.TabIndex = 5;
            this.DGV.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DGV_CellFormatting_1);
            // 
            // 全部
            // 
            this.全部.DataPropertyName = "DormitoryNum";
            this.全部.HeaderText = "全部";
            this.全部.MinimumWidth = 6;
            this.全部.Name = "全部";
            this.全部.Width = 75;
            // 
            // 一床
            // 
            this.一床.DataPropertyName = "Bed1";
            this.一床.HeaderText = "1床";
            this.一床.MinimumWidth = 6;
            this.一床.Name = "一床";
            this.一床.Width = 80;
            // 
            // 二创
            // 
            this.二创.DataPropertyName = "Bed2";
            this.二创.HeaderText = "2床";
            this.二创.MinimumWidth = 6;
            this.二创.Name = "二创";
            this.二创.Width = 80;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Bed3";
            this.Column1.HeaderText = "3床";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 80;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Bed4";
            this.Column2.HeaderText = "4床";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 80;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Bed5";
            this.Column3.HeaderText = "5床";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 80;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Bed6";
            this.Column4.HeaderText = "6床";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 80;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Bed7";
            this.Column5.HeaderText = "7床";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 80;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "Bed8";
            this.Column6.HeaderText = "8床";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Width = 80;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "Bed9";
            this.Column7.HeaderText = "9床";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.Width = 80;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "Bed10";
            this.Column8.HeaderText = "10床";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.Width = 80;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "TotalPerson";
            this.Column9.HeaderText = "房间总人数";
            this.Column9.MinimumWidth = 6;
            this.Column9.Name = "Column9";
            this.Column9.Width = 115;
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "WeekCheckIn";
            this.Column10.HeaderText = "本周入住";
            this.Column10.MinimumWidth = 6;
            this.Column10.Name = "Column10";
            this.Column10.Width = 125;
            // 
            // 本周退宿
            // 
            this.本周退宿.DataPropertyName = "WeekCheckOut";
            this.本周退宿.HeaderText = "本周退宿";
            this.本周退宿.MinimumWidth = 6;
            this.本周退宿.Name = "本周退宿";
            this.本周退宿.Width = 125;
            // 
            // Column11
            // 
            this.Column11.DataPropertyName = "DormitoryManager";
            this.Column11.HeaderText = "宿舍长";
            this.Column11.MinimumWidth = 6;
            this.Column11.Name = "Column11";
            this.Column11.Width = 85;
            // 
            // Column12
            // 
            this.Column12.DataPropertyName = "FreeBedNum";
            this.Column12.HeaderText = "空余床位";
            this.Column12.MinimumWidth = 6;
            this.Column12.Name = "Column12";
            this.Column12.Width = 125;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rs);
            this.panel1.Controls.Add(this.fj);
            this.panel1.Controls.Add(this.nv);
            this.panel1.Controls.Add(label6);
            this.panel1.Controls.Add(this.nan);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.qb);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnInput);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1067, 116);
            this.panel1.TabIndex = 4;
            // 
            // rs
            // 
            this.rs.AutoSize = true;
            this.rs.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rs.Location = new System.Drawing.Point(939, 74);
            this.rs.Name = "rs";
            this.rs.Size = new System.Drawing.Size(23, 23);
            this.rs.TabIndex = 13;
            this.rs.Text = "1";
            // 
            // fj
            // 
            this.fj.AutoSize = true;
            this.fj.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.fj.Location = new System.Drawing.Point(499, 74);
            this.fj.Name = "fj";
            this.fj.Size = new System.Drawing.Size(23, 23);
            this.fj.TabIndex = 12;
            this.fj.Text = "1";
            // 
            // nv
            // 
            this.nv.AutoSize = true;
            this.nv.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.nv.Location = new System.Drawing.Point(369, 74);
            this.nv.Name = "nv";
            this.nv.Size = new System.Drawing.Size(23, 23);
            this.nv.TabIndex = 11;
            this.nv.Text = "1";
            // 
            // nan
            // 
            this.nan.AutoSize = true;
            this.nan.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.nan.Location = new System.Drawing.Point(225, 74);
            this.nan.Name = "nan";
            this.nan.Size = new System.Drawing.Size(23, 23);
            this.nan.TabIndex = 9;
            this.nan.Text = "1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(171, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 23);
            this.label4.TabIndex = 8;
            this.label4.Text = "男:";
            // 
            // qb
            // 
            this.qb.AutoSize = true;
            this.qb.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.qb.Location = new System.Drawing.Point(92, 74);
            this.qb.Name = "qb";
            this.qb.Size = new System.Drawing.Size(23, 23);
            this.qb.TabIndex = 7;
            this.qb.Text = "1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(13, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "全部:";
            // 
            // btnInput
            // 
            this.btnInput.Location = new System.Drawing.Point(845, 12);
            this.btnInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnInput.Name = "btnInput";
            this.btnInput.Size = new System.Drawing.Size(87, 42);
            this.btnInput.TabIndex = 2;
            this.btnInput.Text = "导出";
            this.btnInput.UseVisualStyleBackColor = true;
            this.btnInput.Click += new System.EventHandler(this.btnInput_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 25F);
            this.label1.Location = new System.Drawing.Point(469, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(312, 42);
            this.label1.TabIndex = 1;
            this.label1.Text = "宿舍住宿一览表";
            // 
            // LodgingQueryFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 562);
            this.Controls.Add(this.DGV);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "LodgingQueryFrm";
            this.Text = "LodgingQueryFrm";
            this.Load += new System.EventHandler(this.LodgingQueryFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn 全部;
        private System.Windows.Forms.DataGridViewTextBoxColumn 一床;
        private System.Windows.Forms.DataGridViewTextBoxColumn 二创;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn 本周退宿;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label rs;
        private System.Windows.Forms.Label fj;
        private System.Windows.Forms.Label nv;
        private System.Windows.Forms.Label nan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label qb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnInput;
        private System.Windows.Forms.Label label1;

    }
}