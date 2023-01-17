using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using DormManage.BLL.StayManage;
using DormManage.Model;
using NPOI.HSSF.UserModel;
using NPOI.XSSF.UserModel;

namespace DormManage.UI.StayManage
{
    public partial class StaffStaffStayOutFrm : Form
    {
        /// <summary>
        /// 实例化业务逻辑层
        /// </summary>
        private StayoutBll stayoutbll = new StayoutBll();

        private int PageIndex = 1;

        private int PageSize = 5;

        private int PageCount = 0;

        public StaffStaffStayOutFrm()
        {
            InitializeComponent();
            dateTimePicker1.Value = Convert.ToDateTime("1900-01-01");
            dateTimePicker2.Value = Convert.ToDateTime("2200-01-01");
            GetStaffCheckInList();
        }

        public void GetStaffCheckInList()
        {
            var starttime = dateTimePicker1.Value.Year + "-" + dateTimePicker1.Value.Month + "-" + dateTimePicker1.Value.Day;
            var finishtime = dateTimePicker2.Value.Year + "-" + dateTimePicker2.Value.Month + "-" + dateTimePicker2.Value.Day;
            PageResultDto<StaffStaffStayOutDto> staffstaffStayout = stayoutbll.GetStaffStaffStayOutDto(starttime, finishtime, PageIndex, PageSize);

            PageCount = Convert.ToInt32(Math.Ceiling(staffstaffStayout.ItemCount * 1.0 / PageSize));

            label3.Text = $"共{staffstaffStayout.ItemCount}条数据，每页显示{PageSize}条，共{PageCount}页,当前第{PageIndex}页";

            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = staffstaffStayout.Items;
        }

        private void StaffStaffStayOutFrm_Load(object sender, EventArgs e)
        {
            GetStaffCheckInList();
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                if (e.Value.ToString() == "true")
                    e.Value = "男";
                else
                    e.Value = "女";
            }
            if (e.ColumnIndex == 4)
            {
                if (e.Value.ToString() == "true")
                    e.Value = "员工";
                else
                    e.Value = "工人";
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PageIndex = 1;
            GetStaffCheckInList();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (PageIndex > 1)
            {
                PageIndex--;
                GetStaffCheckInList();
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (PageIndex < PageCount)
            {
                PageIndex++;
                GetStaffCheckInList();
            }
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PageIndex = PageCount;
            GetStaffCheckInList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var departs = GetExportData();
            if (departs.Count <= 0) return;
            //定义工作簿
            HSSFWorkbook workbook = new HSSFWorkbook();
            //创建Sheet表单
            var title = "宿舍后台管理";
            HSSFSheet sheet = (HSSFSheet)workbook.CreateSheet(title);
            //设置表单列的宽度
            sheet.DefaultColumnWidth = 20;
            //新建标题行
            HSSFRow dataRow = (HSSFRow)sheet.CreateRow(0);
            dataRow.CreateCell(0).SetCellStyle(workbook, "ID");
            dataRow.CreateCell(1).SetCellStyle(workbook, "工号");
            dataRow.CreateCell(2).SetCellStyle(workbook, "姓名");
            dataRow.CreateCell(3).SetCellStyle(workbook, "性别");
            dataRow.CreateCell(4).SetCellStyle(workbook, "类别");
            dataRow.CreateCell(5).SetCellStyle(workbook, "一级部门");
            dataRow.CreateCell(6).SetCellStyle(workbook, "二级部门");
            dataRow.CreateCell(7).SetCellStyle(workbook, "住宿日期");
            dataRow.CreateCell(8).SetCellStyle(workbook, "退宿日期");
            dataRow.CreateCell(9).SetCellStyle(workbook, "住宿金额");
            dataRow.CreateCell(10).SetCellStyle(workbook, "退款");
            var row = 1;
            departs.ForEach(m =>
            {
                dataRow = (HSSFRow)sheet.CreateRow(row); //创建数据行
                dataRow.CreateCell(0).SetCellStyle(workbook, m.Id);
                dataRow.CreateCell(1).SetCellStyle(workbook, m.EmpNo);
                dataRow.CreateCell(2).SetCellStyle(workbook, m.Name);
                var sex = m.Sex ? "男" : "女";
                dataRow.CreateCell(3).SetCellStyle(workbook, sex);
                var typeid = m.TypeId ? "员工" : "工人";
                dataRow.CreateCell(4).SetCellStyle(workbook, typeid);
                dataRow.CreateCell(5).SetCellStyle(workbook, m.StairName);
                dataRow.CreateCell(6).SetCellStyle(workbook, m.SecondName);
                dataRow.CreateCell(7).SetCellStyle(workbook, m.CheckInTime);
                dataRow.CreateCell(8).SetCellStyle(workbook, m.StayOutTime);
                dataRow.CreateCell(9).SetCellStyle(workbook, m.Money);
                dataRow.CreateCell(10).SetCellStyle(workbook, m.Deduction);
                row++;
            });
            var path = "d:/" + title + DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss") + ".xls";

            using (FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write))
            {
                workbook.Write(fs);
                MessageBox.Show("导出数据成功！导出文件位置：" + path, "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// 获取需要导出的数据
        /// </summary>
        /// <returns></returns>
        private List<StaffStaffStayOutDto> GetExportData()
        {
            GetStaffCheckInList();
            var starttime = dateTimePicker1.Value.ToString();
            var finishtime = dateTimePicker2.Value.ToString();
            var departs = stayoutbll.GetStaffStaffStayOutList(starttime, finishtime);
            return departs;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PageIndex = 1;
            GetStaffCheckInList();
        }
    }
}