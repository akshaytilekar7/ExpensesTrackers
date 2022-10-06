using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using System.Data;
using BorderStyle = NPOI.SS.UserModel.BorderStyle;

namespace ExpenseTrackerWin.Utility
{
    public class ExcelDto
    {
        public DataTable DataTable { get; set; }
        public string SheetName { get; set; }
    }
    public class GridExcel
    {
        public static void ExportToExcel(List<ExcelDto> excelDtos, string path)
        {
            using (var fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write))
            {
                IWorkbook workbook = new XSSFWorkbook();
                foreach (var item in excelDtos)
                {
                    var dataTable = item.DataTable;
                    ISheet excelSheet = workbook.CreateSheet(item.SheetName);
                    var myFont = (XSSFFont)workbook.CreateFont();

                    myFont.FontHeightInPoints = 15;
                    myFont.FontName = "Calibri Light";
                    XSSFCellStyle borderedCellStyle = GetBorderedCellStyle(workbook, myFont, IndexedColors.Yellow.Index, BorderStyle.Thick);

                    var row = excelSheet.CreateRow(0);
                    for (int j = 0; j < dataTable.Columns.Count; ++j)
                    {
                        //row.CreateCell(j).SetCellValue(dataTable.Columns[j].ColumnName);
                        ICell Cell = row.CreateCell(j);
                        Cell.SetCellValue(dataTable.Columns[j].ColumnName);
                        Cell.CellStyle = borderedCellStyle;
                        excelSheet.AutoSizeColumn(0);
                    }

                    int columnIndex = 1;
                    borderedCellStyle = GetBorderedCellStyle(workbook, myFont, IndexedColors.White.Index, BorderStyle.Medium);
                    for (int i = 0; i < dataTable.Rows.Count; ++i)
                    {
                        row = excelSheet.CreateRow(columnIndex);
                        for (int j = 0; j < dataTable.Columns.Count; ++j)
                        {
                            // row.CreateCell(j).SetCellValue(dataTable.Rows[i][j].ToString());
                            ICell Cell = row.CreateCell(j);
                            Cell.SetCellValue(dataTable.Rows[i][j].ToString());
                            Cell.CellStyle = borderedCellStyle;

                        }
                        excelSheet.AutoSizeColumn(columnIndex);
                        ++columnIndex;
                    }
                }
                workbook.Write(fs);
            }

        }

        private static XSSFCellStyle GetBorderedCellStyle(IWorkbook workbook, XSSFFont myFont, short fillForegroundColor, BorderStyle border = BorderStyle.Medium)
        {
            var borderedCellStyle = (XSSFCellStyle)workbook.CreateCellStyle();
            borderedCellStyle.SetFont(myFont);
            borderedCellStyle.FillForegroundColor = fillForegroundColor;
            borderedCellStyle.FillPattern = FillPattern.SolidForeground;
            borderedCellStyle.VerticalAlignment = VerticalAlignment.Center;
            borderedCellStyle.BorderBottom = borderedCellStyle.BorderTop =
                borderedCellStyle.BorderRight = borderedCellStyle.BorderLeft = border;
            return borderedCellStyle;
        }

    }
}
