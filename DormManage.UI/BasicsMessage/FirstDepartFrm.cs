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
    /// <summary>
    /// 一级部门维护 窗体
    /// </summary>
    public partial class FirstDepartFrm : Form
    {
        public FirstDepartFrm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 实例化
        /// </summary>
        DepartmentBll bll = new DepartmentBll();

        /// <summary>
        /// 窗体加载事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FirstDepartFrm_Load(object sender, EventArgs e)
        {
            DepartmentList();
        }

        /// <summary>
        /// 显示一级部门信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void DepartmentList()
        {
            //一级部门信息
            List<Department> departments = bll.GetStairDepartmentList();
            //不让自动生成列
            this.dataGridView1.AutoGenerateColumns = false;
            //绑定信息
            this.dataGridView1.DataSource = departments;
        }

        /// <summary>
        /// 点击单元格事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string title = dataGridView1.Columns[e.ColumnIndex].HeaderText;
            int id = (int)dataGridView1.Rows[e.RowIndex].Cells[0].Value;
            if (title == "编辑")
            {
                FirstUpdateDepartFrm firstUpdateDepartFrm = new FirstUpdateDepartFrm(id);
                if (firstUpdateDepartFrm.ShowDialog() == DialogResult.OK)
                {
                    DepartmentList();
                }
            }
        }

        /// <summary>
        /// 初始化化单元格事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
                if (e.Value.ToString() == "True")
                {
                    e.Value = "是";
                }
                else
                {
                    e.Value = "否";
                }
            }
        }

        /// <summary>
        /// 添加部门点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddDepart_Click(object sender, EventArgs e)
        {
            FirstDepartAddFrm firstDepartAddFrm = new FirstDepartAddFrm();
            if (firstDepartAddFrm.ShowDialog() == DialogResult.OK)
            {
                DepartmentList();
            }
        }
    }
}
