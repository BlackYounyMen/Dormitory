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
    /// 编辑床位窗体
    /// </summary>
    public partial class BunkUpdateFrm : Form
    {
        /// <summary>
        /// 实例化
        /// </summary>
        BunkBll bll = new BunkBll();

        /// <summary>
        /// 定义变量 接收id
        /// </summary>
        private int BunkId;


        public BunkUpdateFrm(int id)
        {
            BunkId = id;
            InitializeComponent();
        }

        /// <summary>
        /// 窗体加载事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmUpdateBunk_Load(object sender, EventArgs e)
        {
            BindDormitoryType();
            var bunkbyid = bll.GetBunkById(BunkId);
            //var IsEnable = true;
            if (bunkbyid != null)
            {
                this.comboBox1.SelectedValue = bunkbyid.DormitoryId;
                this.txtName.Text = bunkbyid.BunkNo;
                if (bunkbyid.IsEnable)
                    rbtnYes.Checked = true;
                else
                    rbtnNo.Checked = true;
            }
        }

        /// <summary>
        /// 绑定下拉
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
        /// 保存按钮点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            var IsEnable = rbtnYes.Checked ? true : false;
            string BunkNo = txtName.Text;
            Bunk bunk = new Bunk()
            {
                Id = BunkId,
                BunkNo = BunkNo,
                IsEnable = IsEnable,
                DormitoryId = (int)comboBox1.SelectedValue
            };
            int i = bll.UpdateBunk(bunk);
            if (i > 0)
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("修改床位失败！", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
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
