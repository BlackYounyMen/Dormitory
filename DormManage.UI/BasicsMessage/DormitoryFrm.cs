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
    /// 宿舍维护窗体
    /// </summary>
    public partial class DormitoryFrm : Form
    {
        /// <summary>
        /// 构造函数初始化
        /// </summary>
        public DormitoryFrm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 实例化业务逻辑层
        /// </summary>
        DormitoryBll dormitoryBll = new DormitoryBll();

        /// <summary>
        /// 窗体加载事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DormitoryFrm_Load(object sender, EventArgs e)
        {
            BindDormitory();
        }

        /// <summary>
        /// 获取宿舍信息 绑定到dataGridView
        /// </summary>
        private void BindDormitory()
        {
            List<Dormitory> dormitoryList = dormitoryBll.GetDormList();
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = dormitoryList;
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
                DormitoryUpdateFrm dormitoryUpdateFrm = new DormitoryUpdateFrm(id);
                if (dormitoryUpdateFrm.ShowDialog() == DialogResult.OK)
                {
                    BindDormitory();
                }
            }
        }

        /// <summary>
        /// 表格初始化单元格事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
                if (e.Value.ToString() == "True")
                {
                    e.Value = "启用";
                }
                else
                {
                    e.Value = "禁用";
                }
            }
        }

        /// <summary>
        /// 添加按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddDorm_Click(object sender, EventArgs e)
        {
            DormitoryAddFrm dormitoryAddFrm = new DormitoryAddFrm();
            if (dormitoryAddFrm.ShowDialog() == DialogResult.OK)
            {
                BindDormitory();
            }
        }
    }
}
