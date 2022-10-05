using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using PatternForCore.Services;
using System.Data;
using System.Text.RegularExpressions;
using BorderStyle = NPOI.SS.UserModel.BorderStyle;

namespace ExpenseTrackerWin.Utility
{
    public class ExcelDto
    {
        public DataGridView DataGridView { get; set; }
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
                    var dataGridView = item.DataGridView;
                    ISheet excelSheet = workbook.CreateSheet(item.SheetName);
                    List<string> columns = new List<string>();
                    IRow row = excelSheet.CreateRow(0);
                    int columnIndex = 0;

                    var myFont = (XSSFFont)workbook.CreateFont();

                    myFont.FontHeightInPoints = 15;
                    myFont.FontName = "Calibri Light";
                    XSSFCellStyle borderedCellStyle = GetBorderedCellStyle(workbook, myFont, IndexedColors.Yellow.Index, BorderStyle.Thick);

                    DataTable dt = new DataTable();
                    foreach (DataGridViewColumn col in dataGridView.Columns)
                        dt.Columns.Add(col.Name);

                    foreach (DataGridViewRow row1 in dataGridView.Rows)
                    {
                        DataRow dRow = dt.NewRow();
                        foreach (DataGridViewCell cell in row1.Cells)
                            dRow[cell.ColumnIndex] = cell.Value;
                        dt.Rows.Add(dRow);
                    }

                    foreach (DataColumn column in dt.Columns)
                    {
                        ICell Cell = row.CreateCell(columnIndex);
                        Cell.SetCellValue(column.ColumnName);
                        Cell.CellStyle = borderedCellStyle;

                        columns.Add(column.ColumnName);
                        row.Cells.Add(Cell);
                        columnIndex++;
                    }
                    excelSheet.AutoSizeColumn(columnIndex);

                    int rowIndex = 1;
                    borderedCellStyle = GetBorderedCellStyle(workbook, myFont, IndexedColors.White.Index, BorderStyle.Medium);
                    foreach (DataRow dsrow in dt.Rows)
                    {
                        row = excelSheet.CreateRow(rowIndex);
                        int cellIndex = 0;
                        foreach (String col in columns)
                        {
                            row.CreateCell(cellIndex).SetCellValue(dsrow[col].ToString());

                            ICell Cell = row.CreateCell(cellIndex);
                            Cell.SetCellValue(dsrow[col].ToString());
                            Cell.CellStyle = borderedCellStyle;

                            cellIndex++;
                        }
                        rowIndex++;
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

        public static void ExportToExcelOld1(DataGridView dataGridView, string path)
        {
            ExcelInteropService excelInteropService = new ExcelInteropService();
            try
            {
                //DataTable dt = new DataTable();
                //dt = (DataTable)dataGridView.DataSource;

                DataTable dt = new DataTable();
                foreach (DataGridViewColumn col in dataGridView.Columns)
                    dt.Columns.Add(col.Name);

                foreach (DataGridViewRow row in dataGridView.Rows)
                {
                    DataRow dRow = dt.NewRow();
                    foreach (DataGridViewCell cell in row.Cells)
                        dRow[cell.ColumnIndex] = cell.Value;
                    dt.Rows.Add(dRow);
                }

                excelInteropService.CreateExcel(path, "Akshay", dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }
        public static void ExportToExcelOld(DataGridView dataGridView, string path)
        {
            try
            {
                if (dataGridView.Rows.Count > 0)
                {
                    StreamWriter wr = new StreamWriter(path, append: true);
                    for (int i = 0; i < dataGridView.Columns.Count; i++)
                    {
                        wr.Write(dataGridView.Columns[i].Name.ToString().ToUpper() + "\t");
                    }

                    wr.WriteLine();

                    foreach (DataGridViewRow row in dataGridView.Rows)
                    {
                        foreach (DataGridViewCell cell in row.Cells)
                        {
                            if (cell != null)
                            {
                                var val = Convert.ToString(cell.Value);
                                if (!string.IsNullOrEmpty(val))
                                {
                                    val = Regex.Replace(val, @"\t|\n|\r", "");
                                }
                                wr.Write(val + "\t");
                            }
                            else
                                wr.Write("\t");

                        }
                        wr.WriteLine();
                    }

                    wr.WriteLine();
                    wr.Close();
                }
                else
                {
                    MessageBox.Show("Zero record to export , perform a operation first" + "Can't export file");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }
    }
}
