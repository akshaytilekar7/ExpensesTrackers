using ExpenseTracker.Models.Dto;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;

namespace ExpenseTrackerWin.Utility
{
    public static class Extentions
    {
        public static void SetGridToFit(this DataGridView dataGridView)
        {
            // Common design settings
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView.BorderStyle = BorderStyle.None; // Remove default border
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // Set background colors
            dataGridView.BackgroundColor = Color.White;
            dataGridView.RowsDefaultCellStyle.BackColor = Color.White; // Set default row background color

            // Set border color
            dataGridView.GridColor = Color.FromArgb(200, 200, 200); // Light Gray
            dataGridView.BorderStyle = BorderStyle.None;

            // Set column header style
            DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle();
            columnHeaderStyle.BackColor = Color.FromArgb(50, 50, 50); // Dark Gray
            columnHeaderStyle.ForeColor = Color.White;
            columnHeaderStyle.Font = new Font(dataGridView.Font, FontStyle.Bold);
            dataGridView.ColumnHeadersDefaultCellStyle = columnHeaderStyle;

            // Set cell style
            DataGridViewCellStyle cellStyle = new DataGridViewCellStyle();
            cellStyle.Padding = new Padding(5); // Add padding for better spacing
            dataGridView.DefaultCellStyle = cellStyle;

            // Set row height for a more elegant look
            dataGridView.RowTemplate.Height = 30;

            // Add more design settings as needed.
            dataGridView.AlternatingRowsDefaultCellStyle = cellStyle;

        }

        public static SortableBindingList<T> MakeSortable<T>(this List<T> lst)
        {
            SortableBindingList<T> sortableBindingList = new(lst);
            return sortableBindingList;
        }

        public static List<DtoTransaction> GenereateSrNo(this List<DtoTransaction> dtoExpenses)
        {
            int index = 1;
            for (int i = 0; i < dtoExpenses.Count; i++)
            {
                var x = index++;
                dtoExpenses[i].SrNo = x;
            }
            return dtoExpenses;
        }

    }
}
