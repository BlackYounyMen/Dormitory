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
    /// 二级部门维护 窗体
    /// </summary>
    public partial class SecondDepartFrm : Form
    {
        public SecondDepartFrm()
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
        private void SecondDepartFrm_Load(object sender, EventArgs e)
        {
            StationList();
        }

        /// <summary>
        /// 获取部门信息 并绑定数据源
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void StationList()
        {
            //一级部门信息
            List<StationDto> station = bll.GetStationList();
            //不让自动生成列
            this.dataGridView1.AutoGenerateColumns = false;
            //绑定信息
            this.dataGridView1.DataSource = station;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string title = dataGridView1.Columns[e.ColumnIndex].HeaderText;
            int id = (int)dataGridView1.Rows[e.RowIndex].Cells[0].Value;
            if (title == "编辑")
            {
                SecondDepartUpdateFrm secondDepartUpdateFrm = new SecondDepartUpdateFrm(id);
                if (secondDepartUpdateFrm.ShowDialog() == DialogResult.OK)
                {
                    StationList();
                }
            }
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 3)
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
        /// 添加按钮点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddDepart_Click(object sender, EventArgs e)
        {
            SecondDepartAddFrm secondDepartAddFrm = new SecondDepartAddFrm();
            if (secondDepartAddFrm.ShowDialog() == DialogResult.OK)
            {
                StationList();
            }
        }
    }
}
