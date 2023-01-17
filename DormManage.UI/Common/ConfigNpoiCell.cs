using NPOI.HSSF.UserModel;
using NPOI.HSSF.Util;
using NPOI.SS.UserModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DormManage.UI
{
    /// <summary>
    /// 重写Npoi单元格样式
    /// </summary>
    static class ConfigNpoiCell
    {
        #region 定义单元格常用到样式
        public static void SetCellStyle(this ICell cell, IWorkbook wb, object val, ConfigStyle str = ConfigStyle.Default)
        {
            ICellStyle cellStyle = wb.CreateCellStyle();

            //定义标题行的字体  
            IFont fontHead = wb.CreateFont();
            fontHead.FontHeightInPoints = 16;
            fontHead.FontName = "微软雅黑";
            fontHead.Boldweight = (short)FontBoldWeight.Bold;
            fontHead.Color = HSSFColor.Red.Index;

            //熊向东自定义 表头
            IFont fontXxd = wb.CreateFont();
            fontXxd.FontHeightInPoints = 10;
            fontXxd.FontName = "微软雅黑";
            fontXxd.Boldweight = (short)FontBoldWeight.Bold;
            fontXxd.Color = HSSFColor.Red.Index;

            //熊向东自定义 黑色标题
            IFont fontNewHead = wb.CreateFont();
            fontNewHead.FontHeightInPoints = 14;
            fontNewHead.FontName = "微软雅黑";
            fontNewHead.Boldweight = (short)FontBoldWeight.Bold;

            //熊向东自定义  加粗字体
            IFont fontNewFont = wb.CreateFont();
            fontNewFont.FontHeightInPoints = 11;
            fontNewFont.FontName = "微软雅黑";
            fontNewFont.Boldweight = (short)FontBoldWeight.Bold;

            //熊向东自定义  加粗字体改变背景颜色
            IFont fontNewCell = wb.CreateFont();
            fontNewFont.FontHeightInPoints = 11;
            fontNewFont.FontName = "微软雅黑";
            fontNewFont.Boldweight = (short)FontBoldWeight.Bold;


            IFont font = wb.CreateFont();
            font.FontName = "微软雅黑";
            //font.Underline = 1;下划线  

            IFont fontcolorblue = wb.CreateFont();
            fontcolorblue.Color = HSSFColor.OliveGreen.Blue.Index;
            fontcolorblue.IsItalic = true;//下划线  
            fontcolorblue.FontName = "微软雅黑";

            //边框  
            cellStyle.BorderBottom = NPOI.SS.UserModel.BorderStyle.Thin;
            cellStyle.BorderLeft = NPOI.SS.UserModel.BorderStyle.Thin;
            cellStyle.BorderRight = NPOI.SS.UserModel.BorderStyle.Thin;
            cellStyle.BorderTop = NPOI.SS.UserModel.BorderStyle.Thin;

            //边框颜色  默认为黑色,可以手动设置
            cellStyle.BottomBorderColor = HSSFColor.OliveGreen.Black.Index; ;
            cellStyle.TopBorderColor = HSSFColor.OliveGreen.Black.Index;

            //背景图形  
            //cellStyle.FillBackgroundColor = HSSFColor.OLIVE_GREEN.BLUE.index;  
            //cellStyle.FillForegroundColor = HSSFColor.OLIVE_GREEN.BLUE.index;  
            cellStyle.FillForegroundColor = HSSFColor.White.Index;
            // cellStyle.FillPattern = FillPatternType.NO_FILL;  
            cellStyle.FillBackgroundColor = HSSFColor.Blue.Index;

            //水平对齐  
            cellStyle.Alignment = NPOI.SS.UserModel.HorizontalAlignment.Center;

            //垂直对齐  
            cellStyle.VerticalAlignment = VerticalAlignment.Center;

            //自动换行  
            cellStyle.WrapText = true;

            //缩进;当设置为1时 
            cellStyle.Indention = 0;

            //上面基本都是设共公的设置  
            //下面列出了常用的字段类型  
            switch (str)
            {
                case ConfigStyle.Head:
                    // cellStyle.FillPattern = FillPatternType.LEAST_DOTS;  
                    cellStyle.SetFont(fontHead);
                    break;
                case ConfigStyle.Date:
                    IDataFormat datastyle = wb.CreateDataFormat();
                    cellStyle.DataFormat = datastyle.GetFormat("yyyy/mm/dd");
                    cellStyle.SetFont(font);
                    break;
                case ConfigStyle.Number:
                    cellStyle.DataFormat = HSSFDataFormat.GetBuiltinFormat("0.00");
                    cellStyle.SetFont(font);
                    break;
                case ConfigStyle.Money:
                    IDataFormat format = wb.CreateDataFormat();
                    cellStyle.DataFormat = format.GetFormat("￥#,##0");
                    cellStyle.SetFont(font);
                    break;
                case ConfigStyle.Url:
                    fontcolorblue.Underline = NPOI.SS.UserModel.FontUnderlineType.Single;
                    cellStyle.SetFont(fontcolorblue);
                    break;
                case ConfigStyle.Percentage:
                    cellStyle.DataFormat = HSSFDataFormat.GetBuiltinFormat("0.00%");
                    cellStyle.SetFont(font);
                    break;
                case ConfigStyle.ChineseCapitals:
                    IDataFormat format1 = wb.CreateDataFormat();
                    cellStyle.DataFormat = format1.GetFormat("[DbNum2][$-804]0");
                    cellStyle.SetFont(font);
                    break;
                case ConfigStyle.Default:
                    cellStyle.SetFont(font);
                    break;
                case ConfigStyle.Xxd:
                    cellStyle.SetFont(fontXxd);
                    break;
                case ConfigStyle.NewHead:
                    cellStyle.SetFont(fontNewHead);
                    cellStyle.FillPattern = FillPattern.SolidForeground;
                    cellStyle.FillForegroundColor = 22;
                    break;
                case ConfigStyle.NewFont:
                    cellStyle.SetFont(fontNewFont);
                    break;
                case ConfigStyle.NewCell:
                    cellStyle.SetFont(fontNewCell);
                    cellStyle.FillPattern = FillPattern.SolidForeground;
                    cellStyle.FillForegroundColor = 10;
                    break;
            }

            cell.SetCellValue(val.ToString());
            cell.CellStyle = cellStyle;
        }

        #endregion

        #region 定义单元格常用到样式的枚举
        public enum ConfigStyle
        {
            Head,
            Url,
            Date,
            Number,
            Money,
            Percentage,
            ChineseCapitals,
            Default,
            Xxd,
            NewHead,
            NewFont,
            NewCell
        }
        #endregion
    }
}
