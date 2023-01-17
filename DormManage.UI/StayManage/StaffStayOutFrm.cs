using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using DormManage.BLL.StayManage;
using DormManage.Model;

namespace DormManage.UI.StayManage
{
    public partial class StaffStayOutFrm : Form
    {
        public StaffStayOutFrm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 实例化 业务逻辑层
        /// </summary>
        StaffStayOutBll staffStayOutBll = new StaffStayOutBll();

        //定义分页变量
        int pageIndex = 1;//当前页
        int pageSize = 5;//页容量
        int pageCount = 0;//总页数

        private void StaffStayOutFrm_Load(object sender, EventArgs e)
        {
            GetStaffStayOutList();
        }

        /// <summary>
        /// 将获取到的数据绑定给表格
        /// </summary>
        public void GetStaffStayOutList()
        {
            //获取控件的值
            string name = txtName.Text.Trim();
            //int BookTypeId = (int)cmbBookType.SelectedValue;
            PageResultDto<StaffStayOutDto> pageResult = staffStayOutBll.GetStaffStayOutList(name, pageIndex, pageSize);
            //计算总页数
            pageCount = Convert.ToInt32(Math.Ceiling(pageResult.ItemCount * 1.0 / pageSize));
            lblPageInfo.Text = $"共 {pageResult.ItemCount} 条数据，每页显示 {pageSize} 条，共 {pageCount} 页，当前第 {pageIndex} 页";
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = pageResult.Items;
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
                    e.Value = "员工";
                else
                    e.Value = "工人";
            }
            if (e.ColumnIndex == 7 || e.ColumnIndex == 8 || e.ColumnIndex == 12 || e.ColumnIndex == 13)
            {
                if (e.Value.ToString() == "True")
                    e.Value = "是";
                else
                    e.Value = "否";
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string title = dataGridView1.Columns[e.ColumnIndex].HeaderText;
            int id = (int)dataGridView1.Rows[e.RowIndex].Cells[0].Value;
            if (title == "编辑")
            {
                StaffStayOutUpdateFrm StaffStayOutUpdatefrm = new StaffStayOutUpdateFrm(id);
                if (StaffStayOutUpdatefrm.ShowDialog() == DialogResult.OK)
                {
                    GetStaffStayOutList();
                }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pageIndex = 1;
            GetStaffStayOutList();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (pageIndex > 1)
            {
                pageIndex--;
                GetStaffStayOutList();
            }
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (pageIndex < pageCount)
            {
                pageIndex++;
                GetStaffStayOutList();
            }
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pageIndex = pageCount;
            GetStaffStayOutList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            StaffStayOutAddFrm frmStaffStayOutAdd = new StaffStayOutAddFrm();
            if (frmStaffStayOutAdd.ShowDialog() == DialogResult.OK)
            {
                GetStaffStayOutList();
            }
        }
    }
}
