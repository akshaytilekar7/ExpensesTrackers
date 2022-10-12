using ExpenseTracker.Models.Dto;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;

namespace ExpenseTrackerWin.Utility
{
    public static class Extentions
    {
        public static void SetGridToFit(this DataGridView dataGridView)
        {
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        public static SortableBindingList<T> MakeSortable<T>(this List<T> lst)
        {
            SortableBindingList<T> sortableBindingList = new(lst);
            return sortableBindingList;
        }

        public static List<DtoExpense> GenereateSrNo(this List<DtoExpense> dtoExpenses)
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
