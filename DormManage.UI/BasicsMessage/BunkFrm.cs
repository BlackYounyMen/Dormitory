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
    /// 床位信息窗体
    /// </summary>
    public partial class BunkFrm : Form
    {
        /// <summary>
        /// 构造函数初始化
        /// </summary>
        public BunkFrm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 实例化业务逻辑层
        /// </summary>
        BunkBll bll = new BunkBll();

        /// <summary>
        /// 窗体加载事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmBunk_Load(object sender, EventArgs e)
        {
            BindBunk();
        }

        /// <summary>
        /// 获取床位信息 绑定到dataGridView
        /// </summary>
        private void BindBunk()
        {
            List<DormitoryBunkDto> dormitorybunkdto = bll.GetBunkList();
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = dormitorybunkdto;
        }

        /// <summary>
        /// 初始化化单元格事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 3)
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
                BunkUpdateFrm frmUpdatebunk = new BunkUpdateFrm(id);
                if (frmUpdatebunk.ShowDialog() == DialogResult.OK)
                {
                    BindBunk();
                }
            }
        }

        /// <summary>
        /// 添加床位按钮点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddBunk_Click(object sender, EventArgs e)
        {
            BunkAddFrm frmAddbunk = new BunkAddFrm();
            if (frmAddbunk.ShowDialog() == DialogResult.OK)
            {
                BindBunk();
            }
        }
    }
}
