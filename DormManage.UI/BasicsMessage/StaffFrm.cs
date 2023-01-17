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
    public partial class StaffFrm : Form
    {
        /// <summary>
        /// 实例化
        /// </summary>
        private StaffBll staffBll = new StaffBll();

        //定义分页变量
        private int pageIndex = 1;

        //当前页
        private int pageSize = 5;

        //页容量
        private int pageCount = 0;

        public StaffFrm()
        {
            InitializeComponent();
        }

        private void StaffFrm_Load(object sender, EventArgs e)
        {
            BindStaff();
        }

        //总页数

        /// <summary>
        /// 获取所有数据 绑定到数据源
        /// </summary>
        private void BindStaff()
        {
            var name = this.txtName.Text.Trim();
            PageResultDto<StaffDto> pageResult = staffBll.GetStaffList(name, pageIndex, pageSize);
            //计算总页数
            pageCount = Convert.ToInt32(Math.Ceiling(pageResult.ItemCount * 1.0 / pageSize));
            labelFenye.Text = $"共 {pageResult.ItemCount} 条数据，每页显示 {pageSize} 条，共 {pageCount} 页，当前第 {pageIndex} 页";
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.DataSource = pageResult.Items;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string title = dataGridView1.Columns[e.ColumnIndex].HeaderText;
            int id = (int)dataGridView1.Rows[e.RowIndex].Cells[0].Value;
            if (title == "编辑")
            {
                StaffUpdateFrm staffUpdateFrm = new StaffUpdateFrm(id);
                if (staffUpdateFrm.ShowDialog() == DialogResult.OK)
                {
                    BindStaff();
                }
            }
            if (title == "查看")
            {
                StaffExamineFrm staffExamineFrm = new StaffExamineFrm(id);
                if (staffExamineFrm.ShowDialog() == DialogResult.OK)
                {
                    BindStaff();
                }
            }
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
                if (e.Value.ToString() == "True")
                    e.Value = "男";
                else
                    e.Value = "女";
            }
            if (e.ColumnIndex == 3)
            {
                if (e.Value.ToString() == "True")
                    e.Value = "工人";
                else
                    e.Value = "员工";
            }
            if (e.ColumnIndex == 8)
            {
                if (e.Value.ToString() == "True")
                    e.Value = "启用";
                else
                    e.Value = "禁用";
            }
        }

        /// <summary>
        /// 查询按钮点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnQuery_Click(object sender, EventArgs e)
        {
            pageIndex = 1;
            BindStaff();
        }

        /// <summary>
        /// 点击按钮点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddStaff_Click(object sender, EventArgs e)
        {
            StaffAddFrm staffAddFrm = new StaffAddFrm();
            if (staffAddFrm.ShowDialog() == DialogResult.OK)
            {
                BindStaff();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pageIndex = 1;
            BindStaff();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (pageIndex > 1)
            {
                pageIndex--;
                BindStaff();
            }
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (pageIndex < pageCount)
            {
                pageIndex++;
                BindStaff();
            }
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pageIndex = pageCount;
            BindStaff();
        }
    }
}