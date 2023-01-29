using DormManage.BLL.StatisticsAnalyse;
using DormManage.Model;
using NPOI.HSSF.UserModel;
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


using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using System.Reflection;

namespace DormManage.UI.Statistics
{
    public partial class LodgingQueryFrm : Form
    {
        TotalRoomAndBedBll totalRoomAndBedBll = new TotalRoomAndBedBll();
        public LodgingQueryFrm()
        {
            InitializeComponent();
        }

        private void btnInput_Click(object sender, EventArgs e)
        {
            var roomBed = totalRoomAndBedBll.DormitoryDetailDTOs();

            //将男女宿舍进行分类
            var manBend = roomBed.Where(a => a.FlagManAndWoMen == "1").ToList();
            var womanBend = roomBed.Where(a => a.FlagManAndWoMen == "0").ToList();

            //宿舍人数信息
            TotalRoomDto totalRoomDTOs = totalRoomAndBedBll.totalRoomDTO();

            //定义工作簿
            HSSFWorkbook workbook = new HSSFWorkbook();

            //创建Sheet表单
            var title = "住宿一览表(" + DateTime.Now.Year + "-" + DateTime.Now.Month + ")";
            HSSFSheet sheet = (HSSFSheet)workbook.CreateSheet(title);

            //设置表单列的宽度
            sheet.DefaultColumnWidth = 12;
            SetCellWidth(sheet);

            //标题行
            HSSFRow dataRowTitle = (HSSFRow)sheet.CreateRow(0);
            dataRowTitle.CreateCell(0).SetCellStyle(workbook, title, ConfigNpoiCell.ConfigStyle.NewHead);

            //合并列 CellRangeAddress()该方法的参数次序是：开始行号，结束行号，开始列号，结束列号。
            sheet.AddMergedRegion(new NPOI.SS.Util.CellRangeAddress(0, 0, 0, 15));
            sheet.AddMergedRegion(new NPOI.SS.Util.CellRangeAddress(1, 1, 6, 14));

            //新建标题行
            HSSFRow dataRow1 = (HSSFRow)sheet.CreateRow(1);
            dataRow1.CreateCell(0).SetCellStyle(workbook, "全部", ConfigNpoiCell.ConfigStyle.NewFont);
            dataRow1.CreateCell(1).SetCellStyle(workbook, totalRoomDTOs.totalperson.ToString() + "人", ConfigNpoiCell.ConfigStyle.NewFont);
            dataRow1.CreateCell(2).SetCellStyle(workbook, "男", ConfigNpoiCell.ConfigStyle.NewFont);
            dataRow1.CreateCell(3).SetCellStyle(workbook, totalRoomDTOs.totalman.ToString() + "人", ConfigNpoiCell.ConfigStyle.NewFont);
            dataRow1.CreateCell(4).SetCellStyle(workbook, "女", ConfigNpoiCell.ConfigStyle.NewFont);
            dataRow1.CreateCell(5).SetCellStyle(workbook, totalRoomDTOs.totalwoman.ToString() + "人", ConfigNpoiCell.ConfigStyle.NewFont);
            dataRow1.CreateCell(6).SetCellStyle(workbook, totalRoomDTOs.roomnum, ConfigNpoiCell.ConfigStyle.NewFont);
            dataRow1.CreateCell(7).SetCellStyle(workbook, totalRoomDTOs.bednum, ConfigNpoiCell.ConfigStyle.NewFont);

            //新建标题行
            HSSFRow dataRow2 = CreateTitleRow(workbook, sheet, 2);
            var row = 3;
            int manFreeBedNum = 0;
            int totalWeekCheckIn = 0;
            int totalWeekCheckOut = 0;
            manBend.ForEach(m =>
            {
                dataRow2 = (HSSFRow)sheet.CreateRow(row);//新建数据行
                SetCellText(workbook, dataRow2, m);
                manFreeBedNum = m.FreeBedNum + manFreeBedNum;

                totalWeekCheckIn += m.WeekCheckIn;
                totalWeekCheckOut += m.WeekCheckOut;
                row++;
            });

            HSSFRow dataRowMan = (HSSFRow)sheet.CreateRow(row);
            sheet.AddMergedRegion(new NPOI.SS.Util.CellRangeAddress(row, row, 0, 9));
            SetEmptyRowStyle(workbook, dataRowMan);
            dataRowMan.CreateCell(10).SetCellStyle(workbook, "男生统计", ConfigNpoiCell.ConfigStyle.NewFont);
            dataRowMan.CreateCell(11).SetCellStyle(workbook, totalRoomDTOs.totalman.ToString() + "人", ConfigNpoiCell.ConfigStyle.NewFont);
            dataRowMan.CreateCell(12).SetCellStyle(workbook, totalWeekCheckIn, ConfigNpoiCell.ConfigStyle.NewFont);
            dataRowMan.CreateCell(13).SetCellStyle(workbook, totalWeekCheckOut, ConfigNpoiCell.ConfigStyle.NewFont);
            dataRowMan.CreateCell(14).SetCellStyle(workbook, "男生剩余", ConfigNpoiCell.ConfigStyle.NewFont);
            dataRowMan.CreateCell(15).SetCellStyle(workbook, manFreeBedNum, ConfigNpoiCell.ConfigStyle.NewFont);
            row++;

            //女生宿舍
            HSSFRow dataRow3 = CreateTitleRow(workbook, sheet, row);

            row++;
            int woManFreeBedNum = 0;
            totalWeekCheckIn = 0;
            totalWeekCheckOut = 0;
            womanBend.ForEach(m =>
            {
                dataRow2 = (HSSFRow)sheet.CreateRow(row);//新建数据行
                SetCellText(workbook, dataRow2, m);
                woManFreeBedNum = m.FreeBedNum + woManFreeBedNum;

                totalWeekCheckIn += m.WeekCheckIn;
                totalWeekCheckOut += m.WeekCheckOut;
                row++;
            });

            HSSFRow dataRowWoman = (HSSFRow)sheet.CreateRow(row);
            sheet.AddMergedRegion(new NPOI.SS.Util.CellRangeAddress(row, row, 0, 9));
            SetEmptyRowStyle(workbook, dataRowWoman);
            dataRowWoman.CreateCell(10).SetCellStyle(workbook, "女生统计", ConfigNpoiCell.ConfigStyle.NewFont);
            dataRowWoman.CreateCell(11).SetCellStyle(workbook, totalRoomDTOs.totalwoman.ToString() + "人", ConfigNpoiCell.ConfigStyle.NewFont);
            dataRowWoman.CreateCell(12).SetCellStyle(workbook, totalWeekCheckIn, ConfigNpoiCell.ConfigStyle.NewFont);
            dataRowWoman.CreateCell(13).SetCellStyle(workbook, totalWeekCheckOut, ConfigNpoiCell.ConfigStyle.NewFont);
            dataRowWoman.CreateCell(14).SetCellStyle(workbook, "女生剩余", ConfigNpoiCell.ConfigStyle.NewFont);
            dataRowWoman.CreateCell(15).SetCellStyle(workbook, woManFreeBedNum, ConfigNpoiCell.ConfigStyle.NewFont);
            row++;

            //生成备注行
            HSSFRow remark = (HSSFRow)sheet.CreateRow(row);
            sheet.AddMergedRegion(new NPOI.SS.Util.CellRangeAddress(row, row, 0, 4));
            remark.CreateCell(0).SetCellValue("注：本周入住的人员，背景颜色为红色");

            var path = "d:/" + title + "—" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".xls";
            using (FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write))
            {
                workbook.Write(fs);
            }
            MessageBox.Show("导出成功！导出文件位置：" + path, "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void SetCellWidth(HSSFSheet sheet)
        {
            for (var i = 1; i <= 10; i++)
            {
                sheet.SetColumnWidth(i, 2500);
            }
        }

        /// <summary>
        /// 设定空单元格样式
        /// </summary>
        /// <param name="workbook"></param>
        /// <param name="row"></param>
        private void SetEmptyRowStyle(HSSFWorkbook workbook, HSSFRow row)
        {
            for (var i = 0; i <= 9; i++)
            {
                row.CreateCell(i).SetCellStyle(workbook, string.Empty, ConfigNpoiCell.ConfigStyle.NewFont);
            }
        }

        /// <summary>
        /// 创建标题行(男宿舍标题行、女宿舍标题行)
        /// </summary>
        /// <param name="workbook"></param>
        /// <param name="sheet"></param>
        /// <param name="row"></param>
        private HSSFRow CreateTitleRow(HSSFWorkbook workbook, HSSFSheet sheet, int row)
        {
            HSSFRow dataRow = (HSSFRow)sheet.CreateRow(row);
            dataRow.CreateCell(0).SetCellStyle(workbook, "房间", ConfigNpoiCell.ConfigStyle.NewFont);
            dataRow.CreateCell(1).SetCellStyle(workbook, "1床", ConfigNpoiCell.ConfigStyle.NewFont);
            dataRow.CreateCell(2).SetCellStyle(workbook, "2床", ConfigNpoiCell.ConfigStyle.NewFont);
            dataRow.CreateCell(3).SetCellStyle(workbook, "3床", ConfigNpoiCell.ConfigStyle.NewFont);
            dataRow.CreateCell(4).SetCellStyle(workbook, "4床", ConfigNpoiCell.ConfigStyle.NewFont);
            dataRow.CreateCell(5).SetCellStyle(workbook, "5床", ConfigNpoiCell.ConfigStyle.NewFont);
            dataRow.CreateCell(6).SetCellStyle(workbook, "6床", ConfigNpoiCell.ConfigStyle.NewFont);
            dataRow.CreateCell(7).SetCellStyle(workbook, "7床", ConfigNpoiCell.ConfigStyle.NewFont);
            dataRow.CreateCell(8).SetCellStyle(workbook, "8床", ConfigNpoiCell.ConfigStyle.NewFont);
            dataRow.CreateCell(9).SetCellStyle(workbook, "9床", ConfigNpoiCell.ConfigStyle.NewFont);
            dataRow.CreateCell(10).SetCellStyle(workbook, "10床", ConfigNpoiCell.ConfigStyle.NewFont);
            dataRow.CreateCell(11).SetCellStyle(workbook, "房间总人数", ConfigNpoiCell.ConfigStyle.NewFont);
            dataRow.CreateCell(12).SetCellStyle(workbook, "本周入住", ConfigNpoiCell.ConfigStyle.NewFont);
            dataRow.CreateCell(13).SetCellStyle(workbook, "本周退宿", ConfigNpoiCell.ConfigStyle.NewFont);
            dataRow.CreateCell(14).SetCellStyle(workbook, "宿舍长", ConfigNpoiCell.ConfigStyle.NewFont);
            dataRow.CreateCell(15).SetCellStyle(workbook, "空余床位", ConfigNpoiCell.ConfigStyle.NewFont);
            return dataRow;
        }

        /// <summary>
        /// 通过循环给每行的10个床位赋值
        /// </summary>
        private void SetCellText(HSSFWorkbook workbook, HSSFRow dataRow, DormitoryDetailDTO m)
        {
            dataRow.CreateCell(0).SetCellStyle(workbook, m.DormitoryNum + "", ConfigNpoiCell.ConfigStyle.NewFont);//新建单元格，并赋值
            for (int i = 1; i <= 10; i++)
            {
                PropertyInfo[] properties = m.GetType().GetProperties();
                foreach (PropertyInfo p in properties)
                {
                    if (p.Name == "Bed" + i)
                    {
                        if (p.GetValue(m, null) != null)
                        {
                            var textArr = p.GetValue(m, null).ToString().Split('/');
                            var checkInDay = Convert.ToDateTime(textArr[1]);
                            var isWeek = IsWeek(checkInDay);
                            if (isWeek)
                                dataRow.CreateCell(i).SetCellStyle(workbook, textArr[0], ConfigNpoiCell.ConfigStyle.NewCell);
                            else
                                dataRow.CreateCell(i).SetCellStyle(workbook, textArr[0]);
                        }
                        else
                        {
                            dataRow.CreateCell(i).SetCellStyle(workbook, "");
                        }
                    }
                }
            }
            dataRow.CreateCell(11).SetCellStyle(workbook, m.TotalPerson + "");
            dataRow.CreateCell(12).SetCellStyle(workbook, m.WeekCheckIn + "");
            dataRow.CreateCell(13).SetCellStyle(workbook, m.WeekCheckOut + "");
            dataRow.CreateCell(14).SetCellStyle(workbook, m.DormitoryManager + "", ConfigNpoiCell.ConfigStyle.NewFont);
            dataRow.CreateCell(15).SetCellStyle(workbook, m.FreeBedNum + "", ConfigNpoiCell.ConfigStyle.NewFont);
        }

     

        /// <summary>
        /// 绑定表格数据
        /// </summary>
        private void BindDepartment()
        {
            List<DormitoryDetailDTO> staffs = totalRoomAndBedBll.DormitoryDetailDTOs();
            this.DGV.AutoGenerateColumns = false;
            this.DGV.DataSource = staffs;
        }

        /// <summary>
        /// 表头人数
        /// </summary>
        private void Get()
        {
            TotalRoomDto totalRoomDTOs = totalRoomAndBedBll.totalRoomDTO();
            qb.Text = totalRoomDTOs.totalperson.ToString();
            nan.Text = totalRoomDTOs.totalman.ToString();
            nv.Text = totalRoomDTOs.totalwoman.ToString();
            fj.Text = totalRoomDTOs.roomnum;
            rs.Text = totalRoomDTOs.bednum;
        }

        private void DGV_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            var arrIndex = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var num = arrIndex.Count(m => m == e.ColumnIndex);
            if (num > 0)
            {
                if (e.Value != null)
                {
                    var textArr = e.Value.ToString().Split('/');
                    if (textArr.Length >= 2)
                    {
                        DateTime date = Convert.ToDateTime(textArr[1]);
                        if (IsWeek(date))
                        {
                            e.CellStyle.BackColor = Color.Red;
                        }
                    }
                    e.Value = textArr[0];
                }
            }
        }

        /// <summary>
        /// 判断日期是否在本周
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        public bool IsWeek(DateTime date)
        {
            DateTime nowTime = DateTime.Now;
            //星期一为第一天  
            int weeknow = Convert.ToInt32(nowTime.DayOfWeek);

            //因为是以星期一为第一天，所以要判断weeknow等于0时，要向前推6天。  
            weeknow = (weeknow == 0 ? (7 - 1) : (weeknow - 1));
            int daydiff = (-1) * weeknow;

            //本周第一天  
            DateTime FirstDay = nowTime.AddDays(daydiff);
            FirstDay = Convert.ToDateTime(FirstDay.Year + "-" + FirstDay.Month + "-" + FirstDay.Day);
            //星期天为最后一天  
            int lastWeekDay = Convert.ToInt32(nowTime.DayOfWeek);
            lastWeekDay = lastWeekDay == 0 ? (7 - lastWeekDay) : lastWeekDay;
            int lastWeekDiff = (7 - lastWeekDay);

            //本周最后一天  
            DateTime LastDay = nowTime.AddDays(lastWeekDiff);
            LastDay = Convert.ToDateTime(LastDay.Year + "-" + LastDay.Month + "-" + LastDay.Day);

            var result = date <= LastDay && date >= FirstDay;
            return result;
        }

        private void LodgingQueryFrm_Load(object sender, EventArgs e)
        {
            BindDepartment();
            Get();
        }
    }

}
