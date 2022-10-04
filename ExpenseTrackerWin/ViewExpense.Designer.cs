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
            this.lblDate = new System.Windows.Forms.Label();
            this.dateStart = new System.Windows.Forms.DateTimePicker();
            this.dateEnd = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.cmbExpensesType = new System.Windows.Forms.ComboBox();
            this.lblExpensesType = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.txtComment = new System.Windows.Forms.TextBox();
            this.lblComment = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.expenseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblError = new System.Windows.Forms.Label();
            this.btnExcel = new System.Windows.Forms.Button();
            this.btnForm1 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dgvFilter = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SrNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CategoryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExpenseType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Comment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.User = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtoExpenseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgvExpenseOverview = new System.Windows.Forms.DataGridView();
            this.dgvIncome = new System.Windows.Forms.DataGridView();
            this.lblExpenseOverview = new System.Windows.Forms.Label();
            this.lblIncome = new System.Windows.Forms.Label();
            this.cmbUsers = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
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
            this.dateStart.Location = new System.Drawing.Point(89, 25);
            this.dateStart.Name = "dateStart";
            this.dateStart.Size = new System.Drawing.Size(200, 23);
            this.dateStart.TabIndex = 1;
            // 
            // dateEnd
            // 
            this.dateEnd.Location = new System.Drawing.Point(425, 25);
            this.dateEnd.Name = "dateEnd";
            this.dateEnd.Size = new System.Drawing.Size(200, 23);
            this.dateEnd.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(334, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "To";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(31, 85);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(55, 15);
            this.lblCategory.TabIndex = 4;
            this.lblCategory.Text = "Category";
            // 
            // cmbCategory
            // 
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(96, 82);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(121, 23);
            this.cmbCategory.TabIndex = 5;
            // 
            // cmbExpensesType
            // 
            this.cmbExpensesType.FormattingEnabled = true;
            this.cmbExpensesType.Location = new System.Drawing.Point(425, 82);
            this.cmbExpensesType.Name = "cmbExpensesType";
            this.cmbExpensesType.Size = new System.Drawing.Size(121, 23);
            this.cmbExpensesType.TabIndex = 7;
            // 
            // lblExpensesType
            // 
            this.lblExpensesType.AutoSize = true;
            this.lblExpensesType.Location = new System.Drawing.Point(326, 88);
            this.lblExpensesType.Name = "lblExpensesType";
            this.lblExpensesType.Size = new System.Drawing.Size(82, 15);
            this.lblExpensesType.TabIndex = 6;
            this.lblExpensesType.Text = "Expenses Type";
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
            this.txtAmount.Location = new System.Drawing.Point(96, 137);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(100, 23);
            this.txtAmount.TabIndex = 9;
            // 
            // txtComment
            // 
            this.txtComment.Location = new System.Drawing.Point(425, 136);
            this.txtComment.Name = "txtComment";
            this.txtComment.Size = new System.Drawing.Size(100, 23);
            this.txtComment.TabIndex = 11;
            // 
            // lblComment
            // 
            this.lblComment.AutoSize = true;
            this.lblComment.Location = new System.Drawing.Point(327, 139);
            this.lblComment.Name = "lblComment";
            this.lblComment.Size = new System.Drawing.Size(61, 15);
            this.lblComment.TabIndex = 10;
            this.lblComment.Text = "Comment";
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSearch.Location = new System.Drawing.Point(31, 185);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(101, 48);
            this.btnSearch.TabIndex = 12;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnClear.Location = new System.Drawing.Point(143, 185);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(88, 48);
            this.btnClear.TabIndex = 13;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // expenseBindingSource
            // 
            this.expenseBindingSource.DataSource = typeof(PatternForCore.Models.Expense);
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
            this.btnExcel.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnExcel.Location = new System.Drawing.Point(236, 185);
            this.btnExcel.Margin = new System.Windows.Forms.Padding(2);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(132, 48);
            this.btnExcel.TabIndex = 18;
            this.btnExcel.Text = "Export";
            this.btnExcel.UseVisualStyleBackColor = true;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // btnForm1
            // 
            this.btnForm1.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnForm1.Location = new System.Drawing.Point(372, 185);
            this.btnForm1.Margin = new System.Windows.Forms.Padding(2);
            this.btnForm1.Name = "btnForm1";
            this.btnForm1.Size = new System.Drawing.Size(102, 48);
            this.btnForm1.TabIndex = 19;
            this.btnForm1.Text = "Home";
            this.btnForm1.UseVisualStyleBackColor = true;
            this.btnForm1.Click += new System.EventHandler(this.btnForm1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(718, 97);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(6, 5);
            this.button1.TabIndex = 20;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDelete.Location = new System.Drawing.Point(485, 185);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(204, 48);
            this.btnDelete.TabIndex = 25;
            this.btnDelete.Text = "Delete Selected";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dgvFilter
            // 
            this.dgvFilter.AutoGenerateColumns = false;
            this.dgvFilter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFilter.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.SrNo,
            this.Date,
            this.CategoryName,
            this.ExpenseType,
            this.Amount,
            this.Comment,
            this.User});
            this.dgvFilter.DataSource = this.dtoExpenseBindingSource;
            this.dgvFilter.Location = new System.Drawing.Point(31, 264);
            this.dgvFilter.Name = "dgvFilter";
            this.dgvFilter.RowHeadersWidth = 62;
            this.dgvFilter.RowTemplate.Height = 25;
            this.dgvFilter.Size = new System.Drawing.Size(824, 567);
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
            // ExpenseType
            // 
            this.ExpenseType.DataPropertyName = "ExpenseType";
            this.ExpenseType.HeaderText = "ExpenseType";
            this.ExpenseType.MinimumWidth = 8;
            this.ExpenseType.Name = "ExpenseType";
            this.ExpenseType.Width = 150;
            // 
            // Amount
            // 
            this.Amount.DataPropertyName = "Amount";
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
            this.User.Name = "User";
            // 
            // dtoExpenseBindingSource
            // 
            this.dtoExpenseBindingSource.DataSource = typeof(PatternForCore.Models.Dto.DtoExpense);
            // 
            // dgvExpenseOverview
            // 
            this.dgvExpenseOverview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExpenseOverview.Location = new System.Drawing.Point(873, 261);
            this.dgvExpenseOverview.Name = "dgvExpenseOverview";
            this.dgvExpenseOverview.RowHeadersWidth = 62;
            this.dgvExpenseOverview.Size = new System.Drawing.Size(370, 266);
            this.dgvExpenseOverview.TabIndex = 27;
            // 
            // dgvIncome
            // 
            this.dgvIncome.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIncome.Location = new System.Drawing.Point(873, 553);
            this.dgvIncome.Name = "dgvIncome";
            this.dgvIncome.RowHeadersWidth = 62;
            this.dgvIncome.Size = new System.Drawing.Size(370, 266);
            this.dgvIncome.TabIndex = 28;
            // 
            // lblExpenseOverview
            // 
            this.lblExpenseOverview.AutoSize = true;
            this.lblExpenseOverview.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblExpenseOverview.Location = new System.Drawing.Point(873, 235);
            this.lblExpenseOverview.Name = "lblExpenseOverview";
            this.lblExpenseOverview.Size = new System.Drawing.Size(151, 23);
            this.lblExpenseOverview.TabIndex = 29;
            this.lblExpenseOverview.Text = "Expense Overview";
            // 
            // lblIncome
            // 
            this.lblIncome.AutoSize = true;
            this.lblIncome.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblIncome.Location = new System.Drawing.Point(873, 527);
            this.lblIncome.Name = "lblIncome";
            this.lblIncome.Size = new System.Drawing.Size(68, 23);
            this.lblIncome.TabIndex = 30;
            this.lblIncome.Text = "Income";
            // 
            // cmbUsers
            // 
            this.cmbUsers.FormattingEnabled = true;
            this.cmbUsers.Location = new System.Drawing.Point(685, 82);
            this.cmbUsers.Name = "cmbUsers";
            this.cmbUsers.Size = new System.Drawing.Size(121, 23);
            this.cmbUsers.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(586, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 31;
            this.label2.Text = "Expenses Type";
            // 
            // ViewExpense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1272, 709);
            this.Controls.Add(this.cmbUsers);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblIncome);
            this.Controls.Add(this.lblExpenseOverview);
            this.Controls.Add(this.dgvIncome);
            this.Controls.Add(this.dgvExpenseOverview);
            this.Controls.Add(this.dgvFilter);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnForm1);
            this.Controls.Add(this.btnExcel);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtComment);
            this.Controls.Add(this.lblComment);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.cmbExpensesType);
            this.Controls.Add(this.lblExpensesType);
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(this.lblCategory);
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
        private Label lblCategory;
        private ComboBox cmbCategory;
        private ComboBox cmbExpensesType;
        private Label lblExpensesType;
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
        private Button btnForm1;
        private Button button1;
        private Button btnDelete;
        private DataGridView dgvFilter;
        private BindingSource dtoExpenseBindingSource;
        private DataGridView dgvExpenseOverview;
        private DataGridView dgvIncome;
        private Label lblExpenseOverview;
        private Label lblIncome;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn SrNo;
        private DataGridViewTextBoxColumn Date;
        private DataGridViewTextBoxColumn CategoryName;
        private DataGridViewTextBoxColumn ExpenseType;
        private DataGridViewTextBoxColumn Amount;
        private DataGridViewTextBoxColumn Comment;
        private DataGridViewTextBoxColumn User;
        private ComboBox cmbUsers;
        private Label label2;
    }
}