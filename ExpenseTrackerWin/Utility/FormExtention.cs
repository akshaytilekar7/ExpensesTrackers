namespace ExpenseTrackerWin.Utility
{
    public static class FormExtention
    {
        public static void SetGridToFit(this DataGridView dataGridView)
        {
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
        }

    }
}
