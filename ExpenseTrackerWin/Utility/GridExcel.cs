using System.Text.RegularExpressions;

namespace ExpenseTrackerWin.Utility
{
    public class GridExcel
    {
        public static void ExportToExcel(DataGridView dataGridView, string projectDirectory)
        {
            try
            {
                if (dataGridView.Rows.Count > 0)
                {
                    StreamWriter wr = new StreamWriter(projectDirectory, append: true);
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
