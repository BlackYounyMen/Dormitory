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
    public partial class DormitoryUpdateFrm : Form
    {
        /// <summary>
        /// 实例化
        /// </summary>
        DormitoryBll dormitoryBll = new DormitoryBll();

        /// <summary>
        /// 宿舍id
        /// </summary>
        private int dormId;

        public DormitoryUpdateFrm(int id)
        {
            dormId = id;
            InitializeComponent();
        }

        /// <summary>
        /// 窗体加载事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DormitoryUpdateFrm_Load(object sender, EventArgs e)
        {
            var dorm = dormitoryBll.GetDormById(dormId);
            txtName.Text = dorm.DormitoryNo;
            if (dorm.IsEnable)
                rbtnYes.Checked = true;
            else
                rbtnNo.Checked = true;
        }

        /// <summary>
        /// 修改按钮点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text.Trim()))
            {
                txtName.Focus();
                return;
            }
            Dormitory dormitory = new Dormitory()
            {
                Id = dormId,
                DormitoryNo = txtName.Text.Trim(),
                IsEnable = rbtnYes.Checked ? true : false
            };
            var i = dormitoryBll.Update(dormitory);
            if (i > 0)
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("修改失败！", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
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
