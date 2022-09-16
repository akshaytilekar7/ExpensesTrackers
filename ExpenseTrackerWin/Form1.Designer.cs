namespace ExpenseTrackerWin
{
    partial class Form1
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
            this.Date = new System.Windows.Forms.Label();
            this.DatePicker = new System.Windows.Forms.DateTimePicker();
            this.dgvExpenses = new System.Windows.Forms.DataGridView();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.DayOne = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CategoryCombo = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExpenses)).BeginInit();
            this.SuspendLayout();
            // 
            // Date
            // 
            this.Date.AutoSize = true;
            this.Date.Location = new System.Drawing.Point(72, 42);
            this.Date.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(31, 15);
            this.Date.TabIndex = 0;
            this.Date.Text = "Date";
            // 
            // DatePicker
            // 
            this.DatePicker.Location = new System.Drawing.Point(140, 39);
            this.DatePicker.Margin = new System.Windows.Forms.Padding(2);
            this.DatePicker.Name = "DatePicker";
            this.DatePicker.Size = new System.Drawing.Size(211, 23);
            this.DatePicker.TabIndex = 1;
            this.DatePicker.ValueChanged += new System.EventHandler(this.DatePicker_ValueChanged);
            // 
            // dgvExpenses
            // 
            this.dgvExpenses.AllowUserToOrderColumns = true;
            this.dgvExpenses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExpenses.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DayOne,
            this.CategoryCombo,
            this.amountDataGridViewTextBoxColumn});
            this.dgvExpenses.Location = new System.Drawing.Point(72, 115);
            this.dgvExpenses.Name = "dgvExpenses";
            this.dgvExpenses.RowTemplate.Height = 25;
            this.dgvExpenses.Size = new System.Drawing.Size(340, 120);
            this.dgvExpenses.TabIndex = 2;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(72, 290);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(181, 290);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // DayOne
            // 
            this.DayOne.DataPropertyName = "Day";
            this.DayOne.HeaderText = "DayOne";
            this.DayOne.Name = "DayOne";
            // 
            // CategoryCombo
            // 
            this.CategoryCombo.DataPropertyName = "Category";
            this.CategoryCombo.HeaderText = "Category";
            this.CategoryCombo.Name = "CategoryCombo";
            this.CategoryCombo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CategoryCombo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
            this.amountDataGridViewTextBoxColumn.HeaderText = "Amount";
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1579, 860);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dgvExpenses);
            this.Controls.Add(this.DatePicker);
            this.Controls.Add(this.Date);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvExpenses)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label Date;
        private DateTimePicker DatePicker;
        private DataGridView dgvExpenses;
        private Button btnSave;
        private Button btnClear;
        private DataGridViewTextBoxColumn dayDataGridViewTextBoxColumn;
        private DataGridViewComboBoxColumn CategoryCombo;
        private DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn Day;
        private DataGridViewTextBoxColumn DayOne;
    }
}