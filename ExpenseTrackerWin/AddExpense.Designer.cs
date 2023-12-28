namespace ExpenseTrackerWin
{
    partial class AddExpense
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Date = new System.Windows.Forms.Label();
            this.DatePicker = new System.Windows.Forms.DateTimePicker();
            this.dgvExpenses = new System.Windows.Forms.DataGridView();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.btnUpload = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnGeData = new System.Windows.Forms.Button();
            this.dgvOldData = new System.Windows.Forms.DataGridView();
            this.dpDate = new System.Windows.Forms.DateTimePicker();
            this.brnOldDataCleat = new System.Windows.Forms.Button();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbNames = new System.Windows.Forms.ComboBox();
            this.lblName = new System.Windows.Forms.Label();
            this.cmbBank = new System.Windows.Forms.ComboBox();
            this.lblBank = new System.Windows.Forms.Label();
            this.btnUploadFromBackup = new System.Windows.Forms.Button();
            this.Day = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Comment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExpenses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOldData)).BeginInit();
            this.SuspendLayout();
            // 
            // Date
            // 
            this.Date.AutoSize = true;
            this.Date.Location = new System.Drawing.Point(34, 52);
            this.Date.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(31, 15);
            this.Date.TabIndex = 0;
            this.Date.Text = "Date";
            // 
            // DatePicker
            // 
            this.DatePicker.Location = new System.Drawing.Point(114, 50);
            this.DatePicker.Margin = new System.Windows.Forms.Padding(2);
            this.DatePicker.Name = "DatePicker";
            this.DatePicker.Size = new System.Drawing.Size(281, 23);
            this.DatePicker.TabIndex = 1;
            this.DatePicker.ValueChanged += new System.EventHandler(this.DatePicker_ValueChanged);
            // 
            // dgvExpenses
            // 
            this.dgvExpenses.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvExpenses.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvExpenses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvExpenses.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvExpenses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExpenses.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Day,
            this.Category,
            this.Amount,
            this.Comment});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.Format = "N0";
            dataGridViewCellStyle6.NullValue = null;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvExpenses.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvExpenses.Location = new System.Drawing.Point(34, 116);
            this.dgvExpenses.Name = "dgvExpenses";
            this.dgvExpenses.RowHeadersWidth = 62;
            this.dgvExpenses.RowTemplate.Height = 25;
            this.dgvExpenses.Size = new System.Drawing.Size(979, 767);
            this.dgvExpenses.TabIndex = 2;
            this.dgvExpenses.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvExpenses_CellContentClick);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(37, 889);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(114, 889);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(89, 8);
            this.lblError.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 15);
            this.lblError.TabIndex = 5;
            // 
            // btnUpload
            // 
            this.btnUpload.Location = new System.Drawing.Point(194, 889);
            this.btnUpload.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(108, 24);
            this.btnUpload.TabIndex = 8;
            this.btnUpload.Text = "Upload Data";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(306, 889);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(76, 23);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnGeData
            // 
            this.btnGeData.Location = new System.Drawing.Point(1301, 133);
            this.btnGeData.Name = "btnGeData";
            this.btnGeData.Size = new System.Drawing.Size(75, 23);
            this.btnGeData.TabIndex = 22;
            this.btnGeData.Text = "Get Data";
            this.btnGeData.UseVisualStyleBackColor = true;
            this.btnGeData.Click += new System.EventHandler(this.btnGeData_Click);
            this.btnGeData.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnGeData_KeyDown);
            // 
            // dgvOldData
            // 
            this.dgvOldData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOldData.Location = new System.Drawing.Point(1030, 172);
            this.dgvOldData.Name = "dgvOldData";
            this.dgvOldData.RowTemplate.Height = 25;
            this.dgvOldData.Size = new System.Drawing.Size(553, 346);
            this.dgvOldData.TabIndex = 23;
            // 
            // dpDate
            // 
            this.dpDate.Location = new System.Drawing.Point(1095, 133);
            this.dpDate.Name = "dpDate";
            this.dpDate.Size = new System.Drawing.Size(200, 23);
            this.dpDate.TabIndex = 24;
            // 
            // brnOldDataCleat
            // 
            this.brnOldDataCleat.Location = new System.Drawing.Point(1030, 524);
            this.brnOldDataCleat.Name = "brnOldDataCleat";
            this.brnOldDataCleat.Size = new System.Drawing.Size(75, 23);
            this.brnOldDataCleat.TabIndex = 25;
            this.brnOldDataCleat.Text = "Clear";
            this.brnOldDataCleat.UseVisualStyleBackColor = true;
            this.brnOldDataCleat.Click += new System.EventHandler(this.brnOldDataCleat_Click);
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(1095, 104);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(100, 23);
            this.txtAmount.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1030, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 15);
            this.label1.TabIndex = 27;
            this.label1.Text = "Amount";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1030, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 15);
            this.label2.TabIndex = 28;
            this.label2.Text = "Date";
            // 
            // cmbNames
            // 
            this.cmbNames.FormattingEnabled = true;
            this.cmbNames.Location = new System.Drawing.Point(494, 49);
            this.cmbNames.Name = "cmbNames";
            this.cmbNames.Size = new System.Drawing.Size(142, 23);
            this.cmbNames.TabIndex = 31;
            this.cmbNames.SelectedIndexChanged += new System.EventHandler(this.cmbNames_SelectedIndexChanged);
            this.cmbNames.SelectionChangeCommitted += new System.EventHandler(this.cmbNames_SelectionChangeCommitted);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(409, 52);
            this.lblName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(39, 15);
            this.lblName.TabIndex = 29;
            this.lblName.Text = "Name";
            // 
            // cmbBank
            // 
            this.cmbBank.FormattingEnabled = true;
            this.cmbBank.Location = new System.Drawing.Point(744, 51);
            this.cmbBank.Name = "cmbBank";
            this.cmbBank.Size = new System.Drawing.Size(142, 23);
            this.cmbBank.TabIndex = 33;
            // 
            // lblBank
            // 
            this.lblBank.AutoSize = true;
            this.lblBank.Location = new System.Drawing.Point(661, 56);
            this.lblBank.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBank.Name = "lblBank";
            this.lblBank.Size = new System.Drawing.Size(33, 15);
            this.lblBank.TabIndex = 32;
            this.lblBank.Text = "Bank";
            // 
            // btnUploadFromBackup
            // 
            this.btnUploadFromBackup.Location = new System.Drawing.Point(386, 889);
            this.btnUploadFromBackup.Margin = new System.Windows.Forms.Padding(2);
            this.btnUploadFromBackup.Name = "btnUploadFromBackup";
            this.btnUploadFromBackup.Size = new System.Drawing.Size(204, 23);
            this.btnUploadFromBackup.TabIndex = 34;
            this.btnUploadFromBackup.Text = "Upload from backup";
            this.btnUploadFromBackup.UseVisualStyleBackColor = true;
            this.btnUploadFromBackup.Click += new System.EventHandler(this.btnUploadFromBackup_Click);
            // 
            // Day
            // 
            this.Day.DataPropertyName = "Day";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Day.DefaultCellStyle = dataGridViewCellStyle2;
            this.Day.HeaderText = "Day";
            this.Day.MinimumWidth = 8;
            this.Day.Name = "Day";
            this.Day.Width = 52;
            // 
            // Category
            // 
            this.Category.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Category.DataPropertyName = "Category";
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Category.DefaultCellStyle = dataGridViewCellStyle3;
            this.Category.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.Category.HeaderText = "Category";
            this.Category.MaxDropDownItems = 5;
            this.Category.MinimumWidth = 100;
            this.Category.Name = "Category";
            this.Category.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Category.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Amount
            // 
            this.Amount.DataPropertyName = "Amount";
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Amount.DefaultCellStyle = dataGridViewCellStyle4;
            this.Amount.HeaderText = "Amount";
            this.Amount.MinimumWidth = 8;
            this.Amount.Name = "Amount";
            this.Amount.Width = 76;
            // 
            // Comment
            // 
            this.Comment.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Comment.DefaultCellStyle = dataGridViewCellStyle5;
            this.Comment.HeaderText = "Comment";
            this.Comment.MinimumWidth = 8;
            this.Comment.Name = "Comment";
            this.Comment.Width = 86;
            // 
            // AddExpense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1595, 957);
            this.Controls.Add(this.btnUploadFromBackup);
            this.Controls.Add(this.cmbBank);
            this.Controls.Add(this.lblBank);
            this.Controls.Add(this.cmbNames);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.brnOldDataCleat);
            this.Controls.Add(this.dpDate);
            this.Controls.Add(this.dgvOldData);
            this.Controls.Add(this.btnGeData);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dgvExpenses);
            this.Controls.Add(this.DatePicker);
            this.Controls.Add(this.Date);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AddExpense";
            this.Text = "Add Expense";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvExpenses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOldData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label Date;
        private DateTimePicker DatePicker;
        private DataGridView dgvExpenses;
        private Button btnSave;
        private Button btnClear;
        private Label lblError;
        private Button btnFilterPage;
        private Button btnUpload;
        private Button btnDelete;
        private Button btnGeData;
        private DataGridView dgvOldData;
        private DateTimePicker dpDate;
        private Button brnOldDataCleat;
        private TextBox txtAmount;
        private Label label1;
        private Label label2;
        private ComboBox cmbNames;
        private Label lblName;
        private ComboBox cmbBank;
        private Label lblBank;
        private Button btnUploadFromBackup;
        private DataGridViewTextBoxColumn Day;
        private DataGridViewComboBoxColumn Category;
        private DataGridViewTextBoxColumn Amount;
        private DataGridViewTextBoxColumn Comment;
    }
}