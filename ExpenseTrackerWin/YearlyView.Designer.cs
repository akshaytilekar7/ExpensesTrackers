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
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.datePickerYearly = new System.Windows.Forms.DateTimePicker();
            this.dgvYealy = new System.Windows.Forms.DataGridView();
            this.categoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.janDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.febDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marchDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aprilDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.juneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.julyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.augustDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.septemberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.octoberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.novemberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.decemberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.catogoryTotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtoYealryBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dtoYealryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnHome = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.dtoExpenseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgvTooltip = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvYealy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtoYealryBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtoYealryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtoExpenseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTooltip)).BeginInit();
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
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.MenuBar;
            dataGridViewCellStyle3.Format = "N0";
            dataGridViewCellStyle3.NullValue = null;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvYealy.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvYealy.AutoGenerateColumns = false;
            this.dgvYealy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvYealy.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.categoryDataGridViewTextBoxColumn,
            this.janDataGridViewTextBoxColumn,
            this.febDataGridViewTextBoxColumn,
            this.marchDataGridViewTextBoxColumn,
            this.aprilDataGridViewTextBoxColumn,
            this.mayDataGridViewTextBoxColumn,
            this.juneDataGridViewTextBoxColumn,
            this.julyDataGridViewTextBoxColumn,
            this.augustDataGridViewTextBoxColumn,
            this.septemberDataGridViewTextBoxColumn,
            this.octoberDataGridViewTextBoxColumn,
            this.novemberDataGridViewTextBoxColumn,
            this.decemberDataGridViewTextBoxColumn,
            this.catogoryTotalDataGridViewTextBoxColumn});
            this.dgvYealy.DataSource = this.dtoYealryBindingSource1;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.Format = "N0";
            dataGridViewCellStyle4.NullValue = null;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvYealy.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvYealy.Location = new System.Drawing.Point(3, 56);
            this.dgvYealy.Name = "dgvYealy";
            this.dgvYealy.RowHeadersWidth = 62;
            this.dgvYealy.RowTemplate.Height = 25;
            this.dgvYealy.Size = new System.Drawing.Size(1186, 932);
            this.dgvYealy.TabIndex = 1;
            this.dgvYealy.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dgvYealy.CellMouseMove += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvYealy_CellMouseMove);
            // 
            // categoryDataGridViewTextBoxColumn
            // 
            this.categoryDataGridViewTextBoxColumn.DataPropertyName = "Category";
            this.categoryDataGridViewTextBoxColumn.HeaderText = "Category";
            this.categoryDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.categoryDataGridViewTextBoxColumn.Name = "categoryDataGridViewTextBoxColumn";
            this.categoryDataGridViewTextBoxColumn.Width = 150;
            // 
            // janDataGridViewTextBoxColumn
            // 
            this.janDataGridViewTextBoxColumn.DataPropertyName = "Jan";
            this.janDataGridViewTextBoxColumn.HeaderText = "Jan";
            this.janDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.janDataGridViewTextBoxColumn.Name = "janDataGridViewTextBoxColumn";
            this.janDataGridViewTextBoxColumn.Width = 150;
            // 
            // febDataGridViewTextBoxColumn
            // 
            this.febDataGridViewTextBoxColumn.DataPropertyName = "Feb";
            this.febDataGridViewTextBoxColumn.HeaderText = "Feb";
            this.febDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.febDataGridViewTextBoxColumn.Name = "febDataGridViewTextBoxColumn";
            this.febDataGridViewTextBoxColumn.Width = 150;
            // 
            // marchDataGridViewTextBoxColumn
            // 
            this.marchDataGridViewTextBoxColumn.DataPropertyName = "March";
            this.marchDataGridViewTextBoxColumn.HeaderText = "March";
            this.marchDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.marchDataGridViewTextBoxColumn.Name = "marchDataGridViewTextBoxColumn";
            this.marchDataGridViewTextBoxColumn.Width = 150;
            // 
            // aprilDataGridViewTextBoxColumn
            // 
            this.aprilDataGridViewTextBoxColumn.DataPropertyName = "April";
            this.aprilDataGridViewTextBoxColumn.HeaderText = "April";
            this.aprilDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.aprilDataGridViewTextBoxColumn.Name = "aprilDataGridViewTextBoxColumn";
            this.aprilDataGridViewTextBoxColumn.Width = 150;
            // 
            // mayDataGridViewTextBoxColumn
            // 
            this.mayDataGridViewTextBoxColumn.DataPropertyName = "May";
            this.mayDataGridViewTextBoxColumn.HeaderText = "May";
            this.mayDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.mayDataGridViewTextBoxColumn.Name = "mayDataGridViewTextBoxColumn";
            this.mayDataGridViewTextBoxColumn.Width = 150;
            // 
            // juneDataGridViewTextBoxColumn
            // 
            this.juneDataGridViewTextBoxColumn.DataPropertyName = "June";
            this.juneDataGridViewTextBoxColumn.HeaderText = "June";
            this.juneDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.juneDataGridViewTextBoxColumn.Name = "juneDataGridViewTextBoxColumn";
            this.juneDataGridViewTextBoxColumn.Width = 150;
            // 
            // julyDataGridViewTextBoxColumn
            // 
            this.julyDataGridViewTextBoxColumn.DataPropertyName = "July";
            this.julyDataGridViewTextBoxColumn.HeaderText = "July";
            this.julyDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.julyDataGridViewTextBoxColumn.Name = "julyDataGridViewTextBoxColumn";
            this.julyDataGridViewTextBoxColumn.Width = 150;
            // 
            // augustDataGridViewTextBoxColumn
            // 
            this.augustDataGridViewTextBoxColumn.DataPropertyName = "August";
            this.augustDataGridViewTextBoxColumn.HeaderText = "August";
            this.augustDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.augustDataGridViewTextBoxColumn.Name = "augustDataGridViewTextBoxColumn";
            this.augustDataGridViewTextBoxColumn.Width = 150;
            // 
            // septemberDataGridViewTextBoxColumn
            // 
            this.septemberDataGridViewTextBoxColumn.DataPropertyName = "September";
            this.septemberDataGridViewTextBoxColumn.HeaderText = "September";
            this.septemberDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.septemberDataGridViewTextBoxColumn.Name = "septemberDataGridViewTextBoxColumn";
            this.septemberDataGridViewTextBoxColumn.Width = 150;
            // 
            // octoberDataGridViewTextBoxColumn
            // 
            this.octoberDataGridViewTextBoxColumn.DataPropertyName = "October";
            this.octoberDataGridViewTextBoxColumn.HeaderText = "October";
            this.octoberDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.octoberDataGridViewTextBoxColumn.Name = "octoberDataGridViewTextBoxColumn";
            this.octoberDataGridViewTextBoxColumn.Width = 150;
            // 
            // novemberDataGridViewTextBoxColumn
            // 
            this.novemberDataGridViewTextBoxColumn.DataPropertyName = "November";
            this.novemberDataGridViewTextBoxColumn.HeaderText = "November";
            this.novemberDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.novemberDataGridViewTextBoxColumn.Name = "novemberDataGridViewTextBoxColumn";
            this.novemberDataGridViewTextBoxColumn.Width = 150;
            // 
            // decemberDataGridViewTextBoxColumn
            // 
            this.decemberDataGridViewTextBoxColumn.DataPropertyName = "December";
            this.decemberDataGridViewTextBoxColumn.HeaderText = "December";
            this.decemberDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.decemberDataGridViewTextBoxColumn.Name = "decemberDataGridViewTextBoxColumn";
            this.decemberDataGridViewTextBoxColumn.Width = 150;
            // 
            // catogoryTotalDataGridViewTextBoxColumn
            // 
            this.catogoryTotalDataGridViewTextBoxColumn.DataPropertyName = "CatogoryTotal";
            this.catogoryTotalDataGridViewTextBoxColumn.HeaderText = "CatogoryTotal";
            this.catogoryTotalDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.catogoryTotalDataGridViewTextBoxColumn.Name = "catogoryTotalDataGridViewTextBoxColumn";
            this.catogoryTotalDataGridViewTextBoxColumn.Width = 150;
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
            this.btnHome.Location = new System.Drawing.Point(1390, 27);
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
            this.lblTotal.Location = new System.Drawing.Point(269, 23);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(65, 26);
            this.lblTotal.TabIndex = 3;
            this.lblTotal.Text = "label1";
            // 
            // dtoExpenseBindingSource
            // 
            this.dtoExpenseBindingSource.DataSource = typeof(PatternForCore.Models.Dto.DtoExpense);
            // 
            // dgvTooltip
            // 
            this.dgvTooltip.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTooltip.Location = new System.Drawing.Point(1195, 268);
            this.dgvTooltip.Name = "dgvTooltip";
            this.dgvTooltip.RowTemplate.Height = 25;
            this.dgvTooltip.Size = new System.Drawing.Size(491, 445);
            this.dgvTooltip.TabIndex = 4;
            // 
            // YearlyView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1698, 1028);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DateTimePicker datePickerYearly;
        private DataGridView dgvYealy;
        private Button btnHome;
        private Label lblTotal;
        private BindingSource dtoYealryBindingSource;
        private DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn janDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn febDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn marchDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn aprilDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn mayDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn juneDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn julyDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn augustDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn septemberDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn octoberDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn novemberDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn decemberDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn catogoryTotalDataGridViewTextBoxColumn;
        private BindingSource dtoYealryBindingSource1;
        private BindingSource dtoExpenseBindingSource;
        private DataGridView dgvTooltip;
    }
}