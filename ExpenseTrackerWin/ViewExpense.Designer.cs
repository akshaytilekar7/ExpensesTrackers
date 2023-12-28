using ExpenseTracker.Models;

namespace ExpenseTrackerWin
{
    partial class ViewExpense
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblDate = new System.Windows.Forms.Label();
            this.dateStart = new System.Windows.Forms.DateTimePicker();
            this.dateEnd = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSubCategory = new System.Windows.Forms.Label();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.cmbExpensesType = new System.Windows.Forms.ComboBox();
            this.lblCategoryMain = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.txtComment = new System.Windows.Forms.TextBox();
            this.lblComment = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.expenseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblError = new System.Windows.Forms.Label();
            this.btnExcel = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dgvFilter = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SrNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CategoryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Comment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.User = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BankName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Balance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtoExpenseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgvExpenseOverview = new System.Windows.Forms.DataGridView();
            this.dgvIncome = new System.Windows.Forms.DataGridView();
            this.cmbUsers = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbBank = new System.Windows.Forms.ComboBox();
            this.lblBank = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.expenseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFilter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtoExpenseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExpenseOverview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIncome)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(31, 31);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(35, 15);
            this.lblDate.TabIndex = 0;
            this.lblDate.Text = "From";
            // 
            // dateStart
            // 
            this.dateStart.Location = new System.Drawing.Point(128, 25);
            this.dateStart.Name = "dateStart";
            this.dateStart.Size = new System.Drawing.Size(200, 23);
            this.dateStart.TabIndex = 1;
            // 
            // dateEnd
            // 
            this.dateEnd.Location = new System.Drawing.Point(493, 19);
            this.dateEnd.Name = "dateEnd";
            this.dateEnd.Size = new System.Drawing.Size(200, 23);
            this.dateEnd.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(391, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "To";
            // 
            // lblSubCategory
            // 
            this.lblSubCategory.AutoSize = true;
            this.lblSubCategory.Location = new System.Drawing.Point(394, 82);
            this.lblSubCategory.Name = "lblSubCategory";
            this.lblSubCategory.Size = new System.Drawing.Size(75, 15);
            this.lblSubCategory.TabIndex = 4;
            this.lblSubCategory.Text = "SubCategory";
            // 
            // cmbCategory
            // 
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(493, 77);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(200, 23);
            this.cmbCategory.TabIndex = 5;
            // 
            // cmbExpensesType
            // 
            this.cmbExpensesType.FormattingEnabled = true;
            this.cmbExpensesType.Location = new System.Drawing.Point(128, 79);
            this.cmbExpensesType.Name = "cmbExpensesType";
            this.cmbExpensesType.Size = new System.Drawing.Size(200, 23);
            this.cmbExpensesType.TabIndex = 7;
            this.cmbExpensesType.SelectionChangeCommitted += new System.EventHandler(this.cmbExpensesType_SelectionChangeCommitted);
            // 
            // lblCategoryMain
            // 
            this.lblCategoryMain.AutoSize = true;
            this.lblCategoryMain.Location = new System.Drawing.Point(29, 85);
            this.lblCategoryMain.Name = "lblCategoryMain";
            this.lblCategoryMain.Size = new System.Drawing.Size(55, 15);
            this.lblCategoryMain.TabIndex = 6;
            this.lblCategoryMain.Text = "Category";
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(31, 138);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(51, 15);
            this.lblAmount.TabIndex = 8;
            this.lblAmount.Text = "Amount";
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(128, 130);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(200, 23);
            this.txtAmount.TabIndex = 9;
            // 
            // txtComment
            // 
            this.txtComment.Location = new System.Drawing.Point(493, 130);
            this.txtComment.Name = "txtComment";
            this.txtComment.Size = new System.Drawing.Size(200, 23);
            this.txtComment.TabIndex = 11;
            // 
            // lblComment
            // 
            this.lblComment.AutoSize = true;
            this.lblComment.Location = new System.Drawing.Point(394, 130);
            this.lblComment.Name = "lblComment";
            this.lblComment.Size = new System.Drawing.Size(61, 15);
            this.lblComment.TabIndex = 10;
            this.lblComment.Text = "Comment";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(31, 185);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 12;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(112, 185);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 13;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // expenseBindingSource
            // 
            this.expenseBindingSource.DataSource = typeof(ExpenseTracker.Models.Transaction);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Location = new System.Drawing.Point(858, -48);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 15);
            this.lblError.TabIndex = 15;
            // 
            // btnExcel
            // 
            this.btnExcel.Location = new System.Drawing.Point(192, 185);
            this.btnExcel.Margin = new System.Windows.Forms.Padding(2);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(75, 23);
            this.btnExcel.TabIndex = 18;
            this.btnExcel.Text = "Export";
            this.btnExcel.UseVisualStyleBackColor = true;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(283, 185);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 25;
            this.btnDelete.Text = "Delete Selected";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dgvFilter
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dgvFilter.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvFilter.AutoGenerateColumns = false;
            this.dgvFilter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFilter.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.SrNo,
            this.Date,
            this.CategoryName,
            this.Amount,
            this.Comment,
            this.User,
            this.BankName,
            this.Balance});
            this.dgvFilter.DataSource = this.dtoExpenseBindingSource;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.NullValue = null;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvFilter.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvFilter.Location = new System.Drawing.Point(12, 239);
            this.dgvFilter.Name = "dgvFilter";
            this.dgvFilter.RowHeadersWidth = 62;
            this.dgvFilter.RowTemplate.Height = 25;
            this.dgvFilter.Size = new System.Drawing.Size(1293, 668);
            this.dgvFilter.TabIndex = 26;
            this.dgvFilter.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFilter_CellContentClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 8;
            this.Id.Name = "Id";
            this.Id.Width = 150;
            // 
            // SrNo
            // 
            this.SrNo.DataPropertyName = "SrNo";
            this.SrNo.HeaderText = "SrNo";
            this.SrNo.MinimumWidth = 8;
            this.SrNo.Name = "SrNo";
            this.SrNo.Width = 150;
            // 
            // Date
            // 
            this.Date.DataPropertyName = "Date";
            this.Date.HeaderText = "Date";
            this.Date.MinimumWidth = 8;
            this.Date.Name = "Date";
            this.Date.Width = 150;
            // 
            // CategoryName
            // 
            this.CategoryName.DataPropertyName = "CategoryName";
            this.CategoryName.HeaderText = "CategoryName";
            this.CategoryName.MinimumWidth = 8;
            this.CategoryName.Name = "CategoryName";
            this.CategoryName.Width = 150;
            // 
            // Amount
            // 
            this.Amount.DataPropertyName = "Amount";
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = null;
            this.Amount.DefaultCellStyle = dataGridViewCellStyle2;
            this.Amount.HeaderText = "Amount";
            this.Amount.MinimumWidth = 8;
            this.Amount.Name = "Amount";
            this.Amount.Width = 150;
            // 
            // Comment
            // 
            this.Comment.DataPropertyName = "Comment";
            this.Comment.HeaderText = "Comment";
            this.Comment.MinimumWidth = 8;
            this.Comment.Name = "Comment";
            this.Comment.Width = 150;
            // 
            // User
            // 
            this.User.DataPropertyName = "User";
            this.User.HeaderText = "User";
            this.User.MinimumWidth = 8;
            this.User.Name = "User";
            this.User.Width = 150;
            // 
            // BankName
            // 
            this.BankName.DataPropertyName = "BankName";
            this.BankName.HeaderText = "BankName";
            this.BankName.MinimumWidth = 8;
            this.BankName.Name = "BankName";
            this.BankName.Width = 150;
            // 
            // Balance
            // 
            this.Balance.DataPropertyName = "Balance";
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = null;
            this.Balance.DefaultCellStyle = dataGridViewCellStyle3;
            this.Balance.HeaderText = "Balance";
            this.Balance.Name = "Balance";
            // 
            // dtoExpenseBindingSource
            // 
            this.dtoExpenseBindingSource.DataSource = typeof(ExpenseTracker.Models.Dto.DtoTransaction);
            // 
            // dgvExpenseOverview
            // 
            this.dgvExpenseOverview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.NullValue = null;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvExpenseOverview.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvExpenseOverview.Location = new System.Drawing.Point(1311, 4);
            this.dgvExpenseOverview.Name = "dgvExpenseOverview";
            this.dgvExpenseOverview.RowHeadersWidth = 62;
            this.dgvExpenseOverview.Size = new System.Drawing.Size(474, 326);
            this.dgvExpenseOverview.TabIndex = 27;
            // 
            // dgvIncome
            // 
            this.dgvIncome.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.NullValue = null;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvIncome.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvIncome.Location = new System.Drawing.Point(1311, 336);
            this.dgvIncome.Name = "dgvIncome";
            this.dgvIncome.RowHeadersWidth = 62;
            this.dgvIncome.Size = new System.Drawing.Size(474, 537);
            this.dgvIncome.TabIndex = 28;
            // 
            // cmbUsers
            // 
            this.cmbUsers.FormattingEnabled = true;
            this.cmbUsers.Location = new System.Drawing.Point(786, 77);
            this.cmbUsers.Name = "cmbUsers";
            this.cmbUsers.Size = new System.Drawing.Size(160, 23);
            this.cmbUsers.TabIndex = 32;
            this.cmbUsers.SelectionChangeCommitted += new System.EventHandler(this.cmbUsers_SelectionChangeCommitted);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(719, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 15);
            this.label2.TabIndex = 31;
            this.label2.Text = "User";
            // 
            // cmbBank
            // 
            this.cmbBank.FormattingEnabled = true;
            this.cmbBank.Location = new System.Drawing.Point(786, 124);
            this.cmbBank.Name = "cmbBank";
            this.cmbBank.Size = new System.Drawing.Size(160, 23);
            this.cmbBank.TabIndex = 35;
            // 
            // lblBank
            // 
            this.lblBank.AutoSize = true;
            this.lblBank.Location = new System.Drawing.Point(719, 132);
            this.lblBank.Name = "lblBank";
            this.lblBank.Size = new System.Drawing.Size(33, 15);
            this.lblBank.TabIndex = 34;
            this.lblBank.Text = "Bank";
            // 
            // ViewExpense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1811, 919);
            this.Controls.Add(this.cmbBank);
            this.Controls.Add(this.lblBank);
            this.Controls.Add(this.cmbUsers);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvIncome);
            this.Controls.Add(this.dgvExpenseOverview);
            this.Controls.Add(this.dgvFilter);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnExcel);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtComment);
            this.Controls.Add(this.lblComment);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.cmbExpensesType);
            this.Controls.Add(this.lblCategoryMain);
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(this.lblSubCategory);
            this.Controls.Add(this.dateEnd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateStart);
            this.Controls.Add(this.lblDate);
            this.Name = "ViewExpense";
            this.Text = "View Expense";
            this.Load += new System.EventHandler(this.FilterData_Load);
            ((System.ComponentModel.ISupportInitialize)(this.expenseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFilter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtoExpenseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExpenseOverview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIncome)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblDate;
        private DateTimePicker dateStart;
        private DateTimePicker dateEnd;
        private Label label1;
        private Label lblSubCategory;
        private ComboBox cmbCategory;
        private ComboBox cmbExpensesType;
        private Label lblCategoryMain;
        private Label lblAmount;
        private TextBox txtAmount;
        private TextBox txtComment;
        private Label lblComment;
        private Button btnSearch;
        private Button btnClear;
        private BindingSource expenseBindingSource;
        private DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
        private Label lblError;
        private DataGridViewTextBoxColumn Category;
        private Button btnExcel;
        private Button button1;
        private Button btnDelete;
        private DataGridView dgvFilter;
        private BindingSource dtoExpenseBindingSource;
        private DataGridView dgvExpenseOverview;
        private DataGridView dgvIncome;
        private ComboBox cmbUsers;
        private Label label2;
        private ComboBox cmbBank;
        private Label lblBank;
        private Button button2;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn SrNo;
        private DataGridViewTextBoxColumn Date;
        private DataGridViewTextBoxColumn CategoryName;
        private DataGridViewTextBoxColumn ExpenseType;
        private DataGridViewTextBoxColumn Amount;
        private DataGridViewTextBoxColumn Comment;
        private DataGridViewTextBoxColumn User;
        private DataGridViewTextBoxColumn BankName;
        private DataGridViewTextBoxColumn Balance;
    }
}