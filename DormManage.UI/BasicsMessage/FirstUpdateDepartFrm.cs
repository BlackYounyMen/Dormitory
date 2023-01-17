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
    /// 编辑一级部门窗体
    /// </summary>
    public partial class FirstUpdateDepartFrm : Form
    {
        /// <summary>
        /// 定义变量
        /// </summary>
        private int departmentId;

        public FirstUpdateDepartFrm(int id)
        {
            departmentId = id;
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
        private void FirstUpdateDepartFrm_Load(object sender, EventArgs e)
        {
            var department = bll.GetDepartmentById(departmentId);
            this.txtStairName.Text = department.StairName;
            if (department.IsEnable)
                rdoYIsEnable.Checked = true;
            else
                rdoNIsEnable.Checked = true;
        }

        /// <summary>
        /// 修改点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpadteDepart_Click(object sender, EventArgs e)
        {
            //获取值
            //名称
            var stairName = this.txtStairName.Text.Trim();
            //是否启用
            var IsEnable = rdoYIsEnable.Checked ? true : false;
            //判断非空
            if (string.IsNullOrEmpty(stairName))
            {
                txtStairName.Focus();
                return;
            }
            //修改一级部门信息
            Department department = new Department
            {
                StairName = stairName,
                IsEnable = IsEnable,
                Id = departmentId
            };
            var i = bll.UpdateDepartment(department);
            if (i > 0)
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("修改失败");
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
