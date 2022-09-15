using PatternForCore.Models;
using PatternForCore.Services;
using PatternForCore.Services.Base.Contracts;

namespace ExpenseTrackerWin
{
    public partial class Form1 : Form
    {
        public ICategoryServices CategoryServices { get; }

        public Form1(ICategoryServices categoryServices)
        {
            InitializeComponent();
            CategoryServices = categoryServices;
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void DatePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var data = CategoryServices.GetAll();
            var ddl =  (DataGridViewComboBoxColumn)dataGridView1.Columns["Category"];
            ddl.DisplayMember = "Name";
            ddl.ValueMember = "Id";
            dataGridView1.DataSource = data;
        }
    }
}