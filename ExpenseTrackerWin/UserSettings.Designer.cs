using ExpenseTracker.Models;

namespace ExpenseTrackerWin
{
    partial class UserSettings
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
            this.dgvExpenseType = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExpenseTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblMainCategory = new System.Windows.Forms.Label();
            this.lblSubCategory = new System.Windows.Forms.Label();
            this.dgvCategory = new System.Windows.Forms.DataGridView();
            this.ctId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ctExpenseType = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ctName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSaveExpense = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnSaveCategory = new System.Windows.Forms.Button();
            this.CategoryTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnHome = new System.Windows.Forms.Button();
            this.cmbExpeseType = new System.Windows.Forms.ComboBox();
            this.txtCategory = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.btnEditSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExpenseType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExpenseTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CategoryTypeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvExpenseType
            // 
            this.dgvExpenseType.AllowDrop = true;
            this.dgvExpenseType.AllowUserToOrderColumns = true;
            this.dgvExpenseType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExpenseType.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Name});
            this.dgvExpenseType.Location = new System.Drawing.Point(17, 63);
            this.dgvExpenseType.Name = "dgvExpenseType";
            this.dgvExpenseType.RowTemplate.Height = 25;
            this.dgvExpenseType.Size = new System.Drawing.Size(505, 677);
            this.dgvExpenseType.TabIndex = 0;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "EtId";
            this.Id.HeaderText = "EtId";
            this.Id.Name = "Id";
            // 
            // Name
            // 
            this.Name.DataPropertyName = "EtName";
            this.Name.HeaderText = "EtName";
            this.Name.Name = "Name";
            // 
            // lblMainCategory
            // 
            this.lblMainCategory.AutoSize = true;
            this.lblMainCategory.Location = new System.Drawing.Point(18, 39);
            this.lblMainCategory.Name = "lblMainCategory";
            this.lblMainCategory.Size = new System.Drawing.Size(80, 15);
            this.lblMainCategory.TabIndex = 1;
            this.lblMainCategory.Text = "Add Category";
            // 
            // lblSubCategory
            // 
            this.lblSubCategory.AutoSize = true;
            this.lblSubCategory.Location = new System.Drawing.Point(623, 16);
            this.lblSubCategory.Name = "lblSubCategory";
            this.lblSubCategory.Size = new System.Drawing.Size(103, 15);
            this.lblSubCategory.TabIndex = 3;
            this.lblSubCategory.Text = "Add Sub Category";
            // 
            // dgvCategory
            // 
            this.dgvCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ctId,
            this.ctExpenseType,
            this.ctName});
            this.dgvCategory.Location = new System.Drawing.Point(624, 140);
            this.dgvCategory.Name = "dgvCategory";
            this.dgvCategory.RowTemplate.Height = 25;
            this.dgvCategory.Size = new System.Drawing.Size(487, 665);
            this.dgvCategory.TabIndex = 2;
            // 
            // ctId
            // 
            this.ctId.DataPropertyName = "ctId";
            this.ctId.HeaderText = "ctId";
            this.ctId.Name = "ctId";
            // 
            // ctExpenseType
            // 
            this.ctExpenseType.DataPropertyName = "ctExpenseType";
            this.ctExpenseType.HeaderText = "ExpenseType";
            this.ctExpenseType.Name = "ctExpenseType";
            this.ctExpenseType.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ctExpenseType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // ctName
            // 
            this.ctName.DataPropertyName = "ctName";
            this.ctName.HeaderText = "Name";
            this.ctName.Name = "ctName";
            // 
            // btnSaveExpense
            // 
            this.btnSaveExpense.Location = new System.Drawing.Point(18, 746);
            this.btnSaveExpense.Name = "btnSaveExpense";
            this.btnSaveExpense.Size = new System.Drawing.Size(75, 23);
            this.btnSaveExpense.TabIndex = 4;
            this.btnSaveExpense.Text = "Save Expense";
            this.btnSaveExpense.UseVisualStyleBackColor = true;
            this.btnSaveExpense.Click += new System.EventHandler(this.btnSaveExpense_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(18, 12);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 5;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnSaveCategory
            // 
            this.btnSaveCategory.Location = new System.Drawing.Point(624, 101);
            this.btnSaveCategory.Name = "btnSaveCategory";
            this.btnSaveCategory.Size = new System.Drawing.Size(75, 23);
            this.btnSaveCategory.TabIndex = 6;
            this.btnSaveCategory.Text = "Save Category";
            this.btnSaveCategory.UseVisualStyleBackColor = true;
            this.btnSaveCategory.Click += new System.EventHandler(this.btnSaveCategory_Click);
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(99, 12);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(75, 23);
            this.btnHome.TabIndex = 7;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // cmbExpeseType
            // 
            this.cmbExpeseType.FormattingEnabled = true;
            this.cmbExpeseType.Location = new System.Drawing.Point(624, 63);
            this.cmbExpeseType.Name = "cmbExpeseType";
            this.cmbExpeseType.Size = new System.Drawing.Size(121, 23);
            this.cmbExpeseType.TabIndex = 8;
            // 
            // txtCategory
            // 
            this.txtCategory.Location = new System.Drawing.Point(775, 63);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Size = new System.Drawing.Size(100, 23);
            this.txtCategory.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(624, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "Category";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(775, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "Sub Category Name";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(898, 63);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(100, 23);
            this.txtId.TabIndex = 12;
            // 
            // btnEditSave
            // 
            this.btnEditSave.Location = new System.Drawing.Point(623, 811);
            this.btnEditSave.Name = "btnEditSave";
            this.btnEditSave.Size = new System.Drawing.Size(75, 23);
            this.btnEditSave.TabIndex = 13;
            this.btnEditSave.Text = "Save Edited";
            this.btnEditSave.UseVisualStyleBackColor = true;
            this.btnEditSave.Click += new System.EventHandler(this.btnEditSave_Click);
            // 
            // UserSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1145, 834);
            this.Controls.Add(this.btnEditSave);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCategory);
            this.Controls.Add(this.cmbExpeseType);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.btnSaveCategory);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnSaveExpense);
            this.Controls.Add(this.lblSubCategory);
            this.Controls.Add(this.dgvCategory);
            this.Controls.Add(this.lblMainCategory);
            this.Controls.Add(this.dgvExpenseType);
            this.Text = "UserSettings";
            this.Load += new System.EventHandler(this.UserSettings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvExpenseType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExpenseTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CategoryTypeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgvExpenseType;
        private Label lblMainCategory;
        private Label lblSubCategory;
        private DataGridView dgvCategory;
        private Button btnSaveExpense;
        private Button btnRefresh;
        private Button btnSaveCategory;
        private BindingSource ExpenseTypeBindingSource;
        private BindingSource CategoryTypeBindingSource;
        private Button btnHome;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Name;
        private ComboBox cmbExpeseType;
        private TextBox txtCategory;
        private Label label1;
        private Label label2;
        private TextBox txtId;
        private DataGridViewTextBoxColumn ctId;
        private DataGridViewComboBoxColumn ctExpenseType;
        private DataGridViewTextBoxColumn ctName;
        private Button btnEditSave;
    }
}