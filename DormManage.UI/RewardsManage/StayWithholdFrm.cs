using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using DormManage.Model;
using DormManage.BLL.StayManage;
using NPOI.HSSF.UserModel;
using NPOI.SS.Formula.Functions;
using System.IO;

namespace DormManage.UI.RewardsManage
{
    public partial class StayWithholdFrm : Form
    {
        private StayWithholdBll stayWithholdBll = new StayWithholdBll();

        //定义分页变量
        private int pageIndex = 1;

        //当前页
        private int pageSize = 5;

        //页容量
        private int totalCount = 0;

        //总条数
        private int pageCount = 0;

        public StayWithholdFrm()
        {
            InitializeComponent();
            dateStartTime.Value = Convert.ToDateTime("1900-01-01");
            dateEndTime.Value = Convert.ToDateTime("2200-01-01");
        }

        //总页数
        /// <summary>
        /// 将获取到的值给表格
        /// </summary>
        public void Bind()
        {
            //获取控件的值
            string entryTime = dateStartTime.Value.ToString("yyyy-MM-dd");
            string checkInTime = dateEndTime.Value.ToString("yyyy-MM-dd");

            List<StaffStaffStayOutDto> dorlist = stayWithholdBll.GetStaffs(entryTime, checkInTime, out totalCount, pageIndex, pageSize);
            //计算总页数
            pageCount = Convert.ToInt32(Math.Ceiling(totalCount * 1.0 / pageSize));
            labe.Text = $"共 {totalCount} 条数据，每页显示 {pageSize} 条，共 {pageCount} 页，当前第 {pageIndex} 页";

            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = dorlist;
        }

        private List<StaffStaffStayOutDto> GetAll(string entryTime = "1999-12-31", string checkInTime = "2550-9-18")
        {
            List<StaffStaffStayOutDto> data = new List<StaffStaffStayOutDto>();
            data = stayWithholdBll.GetStaffs(entryTime, checkInTime, out totalCount, pageIndex, pageSize);
            return data;
        }

        private void RewardsWithholdFrm_Load(object sender, EventArgs e)
        {
            Bind();
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                if (e.Value.ToString() == "True")
                    e.Value = "男";
                else
                    e.Value = "女";
            }
            if (e.ColumnIndex == 4)
            {
                if (e.Value.ToString() == "True")
                    e.Value = "工人";
                else
                    e.Value = "员工";
            }
        }

        /// <summary>
        /// 表格导出
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void derive_Click(object sender, EventArgs e)
        {
            //定义工作簿
            HSSFWorkbook workbook = new HSSFWorkbook();
            //创建Sheet表单
            var title = "退宿管理";
            HSSFSheet sheet = (HSSFSheet)workbook.CreateSheet(title);
            //设置表单列的宽度
            sheet.DefaultColumnWidth = 20;

            var rewards = GetAll();
            //标题行
            HSSFRow dataRowTitle = (HSSFRow)sheet.CreateRow(0);
            dataRowTitle.CreateCell(0).SetCellStyle(workbook, title, ConfigNpoiCell.ConfigStyle.Head);

            //合并列 CellRangeAddress()该方法的参数次序是：开始行号，结束行号，开始列号，结束列号。
            sheet.AddMergedRegion(new NPOI.SS.Util.CellRangeAddress(0, 0, 0, 7));

            //新建标题行
            HSSFRow dataRow = (HSSFRow)sheet.CreateRow(1);
            dataRow.CreateCell(0).SetCellStyle(workbook, "工号", ConfigNpoiCell.ConfigStyle.Xxd);
            dataRow.CreateCell(1).SetCellStyle(workbook, "姓名", ConfigNpoiCell.ConfigStyle.Xxd);
            dataRow.CreateCell(2).SetCellStyle(workbook, "性别", ConfigNpoiCell.ConfigStyle.Xxd);
            dataRow.CreateCell(3).SetCellStyle(workbook, "类别", ConfigNpoiCell.ConfigStyle.Xxd);
            dataRow.CreateCell(4).SetCellStyle(workbook, "一级部门", ConfigNpoiCell.ConfigStyle.Xxd);
            dataRow.CreateCell(5).SetCellStyle(workbook, "二级部门", ConfigNpoiCell.ConfigStyle.Xxd);
            dataRow.CreateCell(6).SetCellStyle(workbook, "入职日期", ConfigNpoiCell.ConfigStyle.Xxd);
            dataRow.CreateCell(7).SetCellStyle(workbook, "住宿日期", ConfigNpoiCell.ConfigStyle.Xxd);
            dataRow.CreateCell(8).SetCellStyle(workbook, "扣款", ConfigNpoiCell.ConfigStyle.Xxd);
            var row = 2;
            rewards.ForEach(m =>
            {
                dataRow = (HSSFRow)sheet.CreateRow(row);//新建数据行
                dataRow.CreateCell(0).SetCellStyle(workbook, m.Name);//新建单元格，并赋值
                dataRow.CreateCell(1).SetCellStyle(workbook, m.Sex.ToString() == "True" ? "男" : "女");

                dataRow.CreateCell(2).SetCellStyle(workbook, m.TypeId.ToString() == "True" ? "工人" : "员工");
                dataRow.CreateCell(3).SetCellStyle(workbook, m.EmpNo);
                dataRow.CreateCell(4).SetCellStyle(workbook, m.EntryTime);
                dataRow.CreateCell(5).SetCellStyle(workbook, m.StairName);
                dataRow.CreateCell(6).SetCellStyle(workbook, m.SecondName);
                dataRow.CreateCell(7).SetCellStyle(workbook, m.CheckInTime);
                dataRow.CreateCell(8).SetCellStyle(workbook, m.StayOutTime);
                row++;
            });

            var path = "d:/" + title + "—" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".xls";
            using (FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write))
            {
                workbook.Write(fs);
                MessageBox.Show("导出成功！导出文件位置：" + path, "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pageIndex = 1;
            Bind();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (pageIndex > 1)
            {
                pageIndex--;
                Bind();
            }
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (pageIndex < pageCount)
            {
                pageIndex++;
                Bind();
            }
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pageIndex = pageCount;
            Bind();
        }
    }
}