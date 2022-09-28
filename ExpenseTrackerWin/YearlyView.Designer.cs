namespace ExpenseTrackerWin
{
    partial class YearlyView
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
        private async void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.datePickerYearly = new System.Windows.Forms.DateTimePicker();
            this.dgvYealy = new System.Windows.Forms.DataGridView();
            this.dtoYealryBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dtoYealryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnHome = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.dtoExpenseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgvTooltip = new System.Windows.Forms.DataGridView();
            this.dgvExpenseOverview = new System.Windows.Forms.DataGridView();
            this.btnExport = new System.Windows.Forms.Button();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Jan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Feb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.March = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.April = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.May = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.June = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.July = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.August = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.September = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.October = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.November = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.December = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CatogoryTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvYealy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtoYealryBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtoYealryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtoExpenseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTooltip)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExpenseOverview)).BeginInit();
            this.SuspendLayout();
            // 
            // datePickerYearly
            // 
            this.datePickerYearly.Location = new System.Drawing.Point(28, 27);
            this.datePickerYearly.Name = "datePickerYearly";
            this.datePickerYearly.Size = new System.Drawing.Size(200, 23);
            this.datePickerYearly.TabIndex = 0;
            this.datePickerYearly.ValueChanged += new System.EventHandler(this.datePickerYearly_ValueChanged);
            // 
            // dgvYealy
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.MenuBar;
            dataGridViewCellStyle1.Format = "N0";
            dataGridViewCellStyle1.NullValue = null;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvYealy.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvYealy.AutoGenerateColumns = false;
            this.dgvYealy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvYealy.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Category,
            this.Jan,
            this.Feb,
            this.March,
            this.April,
            this.May,
            this.June,
            this.July,
            this.August,
            this.September,
            this.October,
            this.November,
            this.December,
            this.CatogoryTotal});
            this.dgvYealy.DataSource = this.dtoYealryBindingSource1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.Format = "N0";
            dataGridViewCellStyle2.NullValue = null;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvYealy.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvYealy.Location = new System.Drawing.Point(3, 56);
            this.dgvYealy.Name = "dgvYealy";
            this.dgvYealy.RowHeadersWidth = 62;
            this.dgvYealy.RowTemplate.Height = 25;
            this.dgvYealy.Size = new System.Drawing.Size(1186, 932);
            this.dgvYealy.TabIndex = 1;
            this.dgvYealy.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dgvYealy.CellMouseMove += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvYealy_CellMouseMove);
            // 
            // dtoYealryBindingSource1
            // 
            this.dtoYealryBindingSource1.DataSource = typeof(PatternForCore.Models.Dto.DtoYealry);
            // 
            // dtoYealryBindingSource
            // 
            this.dtoYealryBindingSource.DataSource = typeof(PatternForCore.Models.Dto.DtoYealry);
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(1114, 27);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(75, 23);
            this.btnHome.TabIndex = 2;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTotal.Location = new System.Drawing.Point(1232, 27);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(0, 26);
            this.lblTotal.TabIndex = 3;
            // 
            // dtoExpenseBindingSource
            // 
            this.dtoExpenseBindingSource.DataSource = typeof(PatternForCore.Models.Dto.DtoExpense);
            // 
            // dgvTooltip
            // 
            this.dgvTooltip.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTooltip.Location = new System.Drawing.Point(1195, 543);
            this.dgvTooltip.Name = "dgvTooltip";
            this.dgvTooltip.RowTemplate.Height = 25;
            this.dgvTooltip.Size = new System.Drawing.Size(491, 445);
            this.dgvTooltip.TabIndex = 4;
            // 
            // dgvExpenseOverview
            // 
            this.dgvExpenseOverview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExpenseOverview.Location = new System.Drawing.Point(1195, 238);
            this.dgvExpenseOverview.Name = "dgvExpenseOverview";
            this.dgvExpenseOverview.RowTemplate.Height = 25;
            this.dgvExpenseOverview.Size = new System.Drawing.Size(491, 289);
            this.dgvExpenseOverview.TabIndex = 5;
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(1033, 27);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(75, 23);
            this.btnExport.TabIndex = 6;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // Category
            // 
            this.Category.DataPropertyName = "Category";
            this.Category.HeaderText = "Category";
            this.Category.MinimumWidth = 8;
            this.Category.Name = "Category";
            this.Category.Width = 150;
            // 
            // Jan
            // 
            this.Jan.DataPropertyName = "Jan";
            this.Jan.HeaderText = "Jan";
            this.Jan.MinimumWidth = 8;
            this.Jan.Name = "Jan";
            this.Jan.Width = 150;
            // 
            // Feb
            // 
            this.Feb.DataPropertyName = "Feb";
            this.Feb.HeaderText = "Feb";
            this.Feb.MinimumWidth = 8;
            this.Feb.Name = "Feb";
            this.Feb.Width = 150;
            // 
            // March
            // 
            this.March.DataPropertyName = "March";
            this.March.HeaderText = "March";
            this.March.MinimumWidth = 8;
            this.March.Name = "March";
            this.March.Width = 150;
            // 
            // April
            // 
            this.April.DataPropertyName = "April";
            this.April.HeaderText = "April";
            this.April.MinimumWidth = 8;
            this.April.Name = "April";
            this.April.Width = 150;
            // 
            // May
            // 
            this.May.DataPropertyName = "May";
            this.May.HeaderText = "May";
            this.May.MinimumWidth = 8;
            this.May.Name = "May";
            this.May.Width = 150;
            // 
            // June
            // 
            this.June.DataPropertyName = "June";
            this.June.HeaderText = "June";
            this.June.MinimumWidth = 8;
            this.June.Name = "June";
            this.June.Width = 150;
            // 
            // July
            // 
            this.July.DataPropertyName = "July";
            this.July.HeaderText = "July";
            this.July.MinimumWidth = 8;
            this.July.Name = "July";
            this.July.Width = 150;
            // 
            // August
            // 
            this.August.DataPropertyName = "August";
            this.August.HeaderText = "August";
            this.August.MinimumWidth = 8;
            this.August.Name = "August";
            this.August.Width = 150;
            // 
            // September
            // 
            this.September.DataPropertyName = "September";
            this.September.HeaderText = "September";
            this.September.MinimumWidth = 8;
            this.September.Name = "September";
            this.September.Width = 150;
            // 
            // October
            // 
            this.October.DataPropertyName = "October";
            this.October.HeaderText = "October";
            this.October.MinimumWidth = 8;
            this.October.Name = "October";
            this.October.Width = 150;
            // 
            // November
            // 
            this.November.DataPropertyName = "November";
            this.November.HeaderText = "November";
            this.November.MinimumWidth = 8;
            this.November.Name = "November";
            this.November.Width = 150;
            // 
            // December
            // 
            this.December.DataPropertyName = "December";
            this.December.HeaderText = "December";
            this.December.MinimumWidth = 8;
            this.December.Name = "December";
            this.December.Width = 150;
            // 
            // CatogoryTotal
            // 
            this.CatogoryTotal.DataPropertyName = "CatogoryTotal";
            this.CatogoryTotal.HeaderText = "CatogoryTotal";
            this.CatogoryTotal.MinimumWidth = 8;
            this.CatogoryTotal.Name = "CatogoryTotal";
            this.CatogoryTotal.Width = 150;
            // 
            // YearlyView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1698, 1028);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.dgvExpenseOverview);
            this.Controls.Add(this.dgvTooltip);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.dgvYealy);
            this.Controls.Add(this.datePickerYearly);
            this.Name = "YearlyView";
            this.Text = "YearlyView";
            this.Load += new System.EventHandler(this.YearlyView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvYealy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtoYealryBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtoYealryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtoExpenseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTooltip)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExpenseOverview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DateTimePicker datePickerYearly;
        private DataGridView dgvYealy;
        private Button btnHome;
        private Label lblTotal;
        private BindingSource dtoYealryBindingSource;
        private BindingSource dtoYealryBindingSource1;
        private BindingSource dtoExpenseBindingSource;
        private DataGridView dgvTooltip;
        private DataGridView dgvExpenseOverview;
        private Button btnExport;
        private DataGridViewTextBoxColumn Category;
        private DataGridViewTextBoxColumn Jan;
        private DataGridViewTextBoxColumn Feb;
        private DataGridViewTextBoxColumn March;
        private DataGridViewTextBoxColumn April;
        private DataGridViewTextBoxColumn May;
        private DataGridViewTextBoxColumn June;
        private DataGridViewTextBoxColumn July;
        private DataGridViewTextBoxColumn August;
        private DataGridViewTextBoxColumn September;
        private DataGridViewTextBoxColumn October;
        private DataGridViewTextBoxColumn November;
        private DataGridViewTextBoxColumn December;
        private DataGridViewTextBoxColumn CatogoryTotal;
    }
}