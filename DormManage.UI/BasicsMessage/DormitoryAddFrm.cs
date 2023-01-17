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
    /// 添加宿舍 窗体
    /// </summary>
    public partial class DormitoryAddFrm : Form
    {
        public DormitoryAddFrm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 实例化
        /// </summary>
        DormitoryBll dormitoryBll = new DormitoryBll();

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text.Trim()))
            {
                txtName.Focus();
                return;
            }
            Dormitory dormitory = new Dormitory()
            {
                DormitoryNo = txtName.Text.Trim(),
                IsEnable = rbtnYes.Checked ? true : false
            };
            var i = dormitoryBll.Add(dormitory);
            if (i > 0)
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("添加失败！", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
