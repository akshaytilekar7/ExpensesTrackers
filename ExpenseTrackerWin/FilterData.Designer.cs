namespace ExpenseTrackerWin
{
    partial class FilterData
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
            this.dgvFilter = new System.Windows.Forms.DataGridView();
            this.expenseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblError = new System.Windows.Forms.Label();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CategoryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExpenseType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFilter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.expenseBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(161, 41);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(35, 15);
            this.lblDate.TabIndex = 0;
            this.lblDate.Text = "From";
            // 
            // dateStart
            // 
            this.dateStart.Location = new System.Drawing.Point(219, 35);
            this.dateStart.Name = "dateStart";
            this.dateStart.Size = new System.Drawing.Size(200, 23);
            this.dateStart.TabIndex = 1;
            // 
            // dateEnd
            // 
            this.dateEnd.Location = new System.Drawing.Point(572, 35);
            this.dateEnd.Name = "dateEnd";
            this.dateEnd.Size = new System.Drawing.Size(200, 23);
            this.dateEnd.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(481, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "To";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(161, 95);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(55, 15);
            this.lblCategory.TabIndex = 4;
            this.lblCategory.Text = "Category";
            // 
            // cmbCategory
            // 
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(227, 92);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(121, 23);
            this.cmbCategory.TabIndex = 5;
            // 
            // cmbExpensesType
            // 
            this.cmbExpensesType.FormattingEnabled = true;
            this.cmbExpensesType.Location = new System.Drawing.Point(572, 92);
            this.cmbExpensesType.Name = "cmbExpensesType";
            this.cmbExpensesType.Size = new System.Drawing.Size(121, 23);
            this.cmbExpensesType.TabIndex = 7;
            // 
            // lblExpensesType
            // 
            this.lblExpensesType.AutoSize = true;
            this.lblExpensesType.Location = new System.Drawing.Point(473, 98);
            this.lblExpensesType.Name = "lblExpensesType";
            this.lblExpensesType.Size = new System.Drawing.Size(82, 15);
            this.lblExpensesType.TabIndex = 6;
            this.lblExpensesType.Text = "Expenses Type";
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(161, 148);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(51, 15);
            this.lblAmount.TabIndex = 8;
            this.lblAmount.Text = "Amount";
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(226, 147);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(100, 23);
            this.txtAmount.TabIndex = 9;
            // 
            // txtComment
            // 
            this.txtComment.Location = new System.Drawing.Point(572, 146);
            this.txtComment.Name = "txtComment";
            this.txtComment.Size = new System.Drawing.Size(100, 23);
            this.txtComment.TabIndex = 11;
            // 
            // lblComment
            // 
            this.lblComment.AutoSize = true;
            this.lblComment.Location = new System.Drawing.Point(474, 149);
            this.lblComment.Name = "lblComment";
            this.lblComment.Size = new System.Drawing.Size(61, 15);
            this.lblComment.TabIndex = 10;
            this.lblComment.Text = "Comment";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(344, 213);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 12;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(462, 213);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 13;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // dgvFilter
            // 
            this.dgvFilter.AutoGenerateColumns = false;
            this.dgvFilter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFilter.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Date,
            this.CategoryName,
            this.ExpenseType,
            this.amountDataGridViewTextBoxColumn,
            this.commentDataGridViewTextBoxColumn});
            this.dgvFilter.DataSource = this.expenseBindingSource;
            this.dgvFilter.Location = new System.Drawing.Point(161, 266);
            this.dgvFilter.Name = "dgvFilter";
            this.dgvFilter.RowTemplate.Height = 25;
            this.dgvFilter.Size = new System.Drawing.Size(684, 293);
            this.dgvFilter.TabIndex = 14;
            // 
            // expenseBindingSource
            // 
            this.expenseBindingSource.DataSource = typeof(PatternForCore.Models.Expense);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Location = new System.Drawing.Point(164, 5);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 15);
            this.lblError.TabIndex = 15;
            // 
            // Date
            // 
            this.Date.DataPropertyName = "Date";
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            // 
            // CategoryName
            // 
            this.CategoryName.DataPropertyName = "CategoryName";
            this.CategoryName.HeaderText = "CategoryName";
            this.CategoryName.Name = "CategoryName";
            // 
            // ExpenseType
            // 
            this.ExpenseType.DataPropertyName = "ExpenseType";
            this.ExpenseType.HeaderText = "ExpenseType";
            this.ExpenseType.Name = "ExpenseType";
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
            this.amountDataGridViewTextBoxColumn.HeaderText = "Amount";
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            // 
            // commentDataGridViewTextBoxColumn
            // 
            this.commentDataGridViewTextBoxColumn.DataPropertyName = "Comment";
            this.commentDataGridViewTextBoxColumn.HeaderText = "Comment";
            this.commentDataGridViewTextBoxColumn.Name = "commentDataGridViewTextBoxColumn";
            // 
            // FilterData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1086, 599);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.dgvFilter);
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
            this.Name = "FilterData";
            this.Text = "FilterData";
            this.Load += new System.EventHandler(this.FilterData_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFilter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.expenseBindingSource)).EndInit();
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
        private DataGridView dgvFilter;
        private DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private BindingSource expenseBindingSource;
        private DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
        private Label lblError;
        private DataGridViewTextBoxColumn Category;
        private DataGridViewTextBoxColumn Date;
        private DataGridViewTextBoxColumn CategoryName;
        private DataGridViewTextBoxColumn ExpenseType;
        private DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn commentDataGridViewTextBoxColumn;
    }
}