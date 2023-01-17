using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using DormManage.BLL.RewardsManage;
using DormManage.Model;
using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;

namespace DormManage.UI.RewardsManage
{
    public partial class FineManageFrm : Form
    {
        /// <summary>
        /// 实例化
        /// </summary>
        private FineManageBll fineManageBll = new FineManageBll();

        //定义分页变量
        private int pageIndex = 1;

        //当前页
        private int pageSize = 5;

        //页容量
        private int pageCount = 0;

        public FineManageFrm()
        {
            InitializeComponent();
            //int year = dateStartTime.Value.Year;
            //int month = dateStartTime.Value.Month;
            //dateStartTime.Value = Convert.ToDateTime(year + "-" + month + "-26");
            //if (month == 12)
            //{
            //    dateEndTime.Value = Convert.ToDateTime(year + 1 + "-01-25");
            //    return;
            //}
            //dateEndTime.Value = Convert.ToDateTime(year + "-" + (month + 1) + "-25");
        }

        /// <summary>
        /// 将获取到的数据绑定给表格
        /// </summary>
        public void GetFineList()
        {
            DateTime startTime = dateStartTime.Value;
            DateTime endTime = dateEndTime.Value;
            PageResultDto<FineDto> pageResult = fineManageBll.GetFineList(startTime, endTime, pageIndex, pageSize);
            //计算总页数
            pageCount = Convert.ToInt32(Math.Ceiling(pageResult.ItemCount * 1.0 / pageSize));
            labelFenye.Text = $"共 {pageResult.ItemCount} 条数据，每页显示 {pageSize} 条，共 {pageCount} 页，当前第 {pageIndex} 页";
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = pageResult.Items;
        }

        /// <summary>
        /// 窗体加载事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FineManageFrm_Load(object sender, EventArgs e)
        {
            GetFineList();
        }

        //总页数
        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                if (e.Value.ToString() == "True")
                    e.Value = "男";
                else
                    e.Value = "女";
            }
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            pageIndex = 1;
            GetFineList();
        }

        private void btnAddAward_Click(object sender, EventArgs e)
        {
            FineManageAddFrm fineManageAddFrm = new FineManageAddFrm();
            if (fineManageAddFrm.ShowDialog() == DialogResult.OK)
            {
                GetFineList();
            }
        }

        private void btnInPut_Click(object sender, EventArgs e)
        {
            DateTime startTime = dateStartTime.Value;
            DateTime endTime = dateEndTime.Value;
            var fines = fineManageBll.GetFines(startTime, endTime);
            if (fines.Count <= 0) return;
            int year = dateEndTime.Value.Year;
            int month = dateEndTime.Value.Month;
            //定义工作簿
            HSSFWorkbook workbook = new HSSFWorkbook();
            //创建Sheet表单
            var title = year.ToString() + "年" + month.ToString() + "月份住宿违规名单(" + dateStartTime.Value.Month.ToString() + "月26-" + dateEndTime.Value.Month.ToString() + "月25)";
            HSSFSheet sheet = (HSSFSheet)workbook.CreateSheet(title);
            //设置表单列的宽度
            sheet.DefaultColumnWidth = 20;

            //标题行
            HSSFRow dataRowTitle = (HSSFRow)sheet.CreateRow(0);
            dataRowTitle.CreateCell(0).SetCellStyle(workbook, title, ConfigNpoiCell.ConfigStyle.Head);

            //合并列 CellRangeAddress()该方法的参数次序是：开始行号，结束行号，开始列号，结束列号。
            sheet.AddMergedRegion(new NPOI.SS.Util.CellRangeAddress(0, 0, 0, 7));

            //新建标题行
            HSSFRow dataRow = (HSSFRow)sheet.CreateRow(1);
            dataRow.CreateCell(0).SetCellStyle(workbook, "工号", ConfigNpoiCell.ConfigStyle.Xxd);
            dataRow.CreateCell(1).SetCellStyle(workbook, "姓名", ConfigNpoiCell.ConfigStyle.Xxd);
            dataRow.CreateCell(2).SetCellStyle(workbook, "一级部门", ConfigNpoiCell.ConfigStyle.Xxd);
            dataRow.CreateCell(3).SetCellStyle(workbook, "二级部门", ConfigNpoiCell.ConfigStyle.Xxd);
            dataRow.CreateCell(4).SetCellStyle(workbook, "处罚事项", ConfigNpoiCell.ConfigStyle.Xxd);
            dataRow.CreateCell(5).SetCellStyle(workbook, "处罚依据", ConfigNpoiCell.ConfigStyle.Xxd);
            dataRow.CreateCell(6).SetCellStyle(workbook, "金额", ConfigNpoiCell.ConfigStyle.Xxd);
            dataRow.CreateCell(7).SetCellStyle(workbook, "备注", ConfigNpoiCell.ConfigStyle.Xxd);

            var row = 2;
            fines.ForEach(m =>
            {
                dataRow = (HSSFRow)sheet.CreateRow(row);//新建数据行
                dataRow.CreateCell(0).SetCellStyle(workbook, m.EmpNo);//新建单元格，并赋值
                dataRow.CreateCell(1).SetCellStyle(workbook, m.Name);
                dataRow.CreateCell(2).SetCellStyle(workbook, m.StairName);
                dataRow.CreateCell(3).SetCellStyle(workbook, m.SecondName);
                dataRow.CreateCell(4).SetCellStyle(workbook, m.Matter);
                dataRow.CreateCell(5).SetCellStyle(workbook, m.Pursuant);
                dataRow.CreateCell(6).SetCellStyle(workbook, m.Money);
                dataRow.CreateCell(7).SetCellStyle(workbook, m.Remark);
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
            GetFineList();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (pageIndex > 1)
            {
                pageIndex--;
                GetFineList();
            }
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (pageIndex < pageCount)
            {
                pageIndex++;
                GetFineList();
            }
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pageIndex = pageCount;
            GetFineList();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string title = dataGridView1.Columns[e.ColumnIndex].HeaderText;
            int id = (int)dataGridView1.Rows[e.RowIndex].Cells[0].Value;
            if (title == "编辑")
            {
                FineManageUpdateFrm fineManageUpdateFrm = new FineManageUpdateFrm(id);
                if (fineManageUpdateFrm.ShowDialog() == DialogResult.OK)
                {
                    GetFineList();
                }
            }
        }

        private void dateStartTime_ValueChanged(object sender, EventArgs e)
        {
            //int year = dateStartTime.Value.Year;
            //int month = dateStartTime.Value.Month;
            //dateStartTime.Value = Convert.ToDateTime(year + "-" + month + "-26");
            //if (month == 12)
            //{
            //    dateEndTime.Value = Convert.ToDateTime(year + 1 + "-01-25");
            //    return;
            //}
            //dateEndTime.Value = Convert.ToDateTime(year + "-" + (month + 1) + "-25");
            GetFineList();
        }

        private void dateEndTime_ValueChanged(object sender, EventArgs e)
        {
            //int year = dateEndTime.Value.Year;
            //int month = dateEndTime.Value.Month;
            //dateEndTime.Value = Convert.ToDateTime(year + "-" + month + "-25");
            //if (month == 1)
            //{
            //    dateStartTime.Value = Convert.ToDateTime(year - 1 + "-12-25");
            //    return;
            //}
            //dateStartTime.Value = Convert.ToDateTime(year + "-" + (month - 1) + "-25");
            GetFineList();
        }
    }
}