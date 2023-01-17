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
    /// 添加床位 窗体
    /// </summary>
    public partial class BunkAddFrm : Form
    {
        /// <summary>
        /// 实例化业务逻辑层
        /// </summary>
        private BunkBll bll = new BunkBll();

        /// <summary>
        /// 构造函数  初始化
        /// </summary>
        public BunkAddFrm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 窗体加载事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmAddBunk_Load(object sender, EventArgs e)
        {
            BindDormitoryType();
        }

        /// <summary>
        /// 获取所有宿舍信息 绑定到下拉框
        /// </summary>
        private void BindDormitoryType()
        {
            List<Dormitory> dormitoryList = bll.GetDormitoryList();
            dormitoryList.Insert(0, new Dormitory { Id = 0, DormitoryNo = "全部" });
            comboBox1.DisplayMember = "DormitoryNo";
            comboBox1.ValueMember = "Id";
            comboBox1.DataSource = dormitoryList;
        }

        /// <summary>
        /// 保存点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            var IsEnable = true;
            if (rbtnYes.Checked)
            {
                IsEnable = false;
            }
            string BunkNo = txtName.Text;
            Bunk bunk = new Bunk()
            {
                BunkNo = BunkNo,
                IsEnable = IsEnable,
                DormitoryId = (int)comboBox1.SelectedValue
            };
            int i = bll.AddBunk(bunk);
            if (i > 0)
            {
                MessageBox.Show("添加床位成功！", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("添加床位失败！", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// 关闭窗体
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}