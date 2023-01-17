using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using DormManage.Model;
using DormManage.BLL.StayManage;

namespace DormManage.UI.StayManage
{
    /// <summary>
    /// 员工入住列表窗体
    /// </summary>
    public partial class StaffCheckInFrm : Form
    {
        private StaffCheckInBll staffCheckInBll = new StaffCheckInBll();

        //定义分页变量
        private int pageIndex = 1;

        //当前页
        private int pageSize = 5;

        //页容量
        private int pageCount = 0;

        /// <summary>
        /// 构造函数 初始化
        /// </summary>
        public StaffCheckInFrm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 将获取到的数据绑定给表格
        /// </summary>
        public void GetStaffCheckInList()
        {
            //获取控件的值
            string name = txtName.Text.Trim();
            //int BookTypeId = (int)cmbBookType.SelectedValue;
            PageResultDto<StaffCheckInDto> pageResult = staffCheckInBll.GetStaffCheckInList(name, pageIndex, pageSize);
            //计算总页数
            pageCount = Convert.ToInt32(Math.Ceiling(pageResult.ItemCount * 1.0 / pageSize));
            labelFenye.Text = $"共 {pageResult.ItemCount} 条数据，每页显示 {pageSize} 条，共 {pageCount} 页，当前第 {pageIndex} 页";
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = pageResult.Items;
        }

        /// <summary>
        /// 实例化 业务逻辑层
        /// </summary>
        /// <summary>
        /// 窗体加载事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmStaffCheckIn_Load(object sender, EventArgs e)
        {
            GetStaffCheckInList();
        }

        //总页数
        /// <summary>
        /// 查询按钮点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnQuery_Click(object sender, EventArgs e)
        {
            pageIndex = 1;
            GetStaffCheckInList();
        }

        /// <summary>
        /// 添加按钮点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            StaffCheckInAddFrm frmAddStaffCheckIn = new StaffCheckInAddFrm();
            if (frmAddStaffCheckIn.ShowDialog() == DialogResult.OK)
            {
                GetStaffCheckInList();
            }
        }

        /// <summary>
        /// 首页
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pageIndex = 1;
            GetStaffCheckInList();
        }

        /// <summary>
        /// 上一页
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (pageIndex > 1)
            {
                pageIndex--;
                GetStaffCheckInList();
            }
        }

        /// <summary>
        /// 下一页
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (pageIndex < pageCount)
            {
                pageIndex++;
                GetStaffCheckInList();
            }
        }

        /// <summary>
        /// 尾页
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pageIndex = pageCount;
            GetStaffCheckInList();
        }

        /// <summary>
        /// 单元格点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string title = dataGridView1.Columns[e.ColumnIndex].HeaderText;
            int id = (int)dataGridView1.Rows[e.RowIndex].Cells[0].Value;
            if (title == "编辑")
            {
                StaffCheckInUpdateFrm updateStaffCheckIn = new StaffCheckInUpdateFrm(id);
                if (updateStaffCheckIn.ShowDialog() == DialogResult.OK)
                {
                    GetStaffCheckInList();
                }
            }
        }

        /// <summary>
        /// 判断单元格的内容
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
            if (e.ColumnIndex == 5 || e.ColumnIndex == 6 || e.ColumnIndex == 9 || e.ColumnIndex == 10)
            {
                if (e.Value.ToString() == "True")
                    e.Value = "是";
                else
                    e.Value = "否";
            }
        }
    }
}