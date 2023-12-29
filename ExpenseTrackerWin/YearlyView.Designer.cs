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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblTotal = new System.Windows.Forms.Label();
            this.dtoExpenseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnExport = new System.Windows.Forms.Button();
            this.dgvBankAmount = new System.Windows.Forms.DataGridView();
            this.dgvTooltip = new System.Windows.Forms.DataGridView();
            this.cmbDatabasePicker = new System.Windows.Forms.ComboBox();
            this.dgvYearly = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtoExpenseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBankAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTooltip)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvYearly)).BeginInit();
            this.SuspendLayout();
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
            this.dtoExpenseBindingSource.DataSource = typeof(ExpenseTracker.Models.Dto.DtoTransaction);
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(274, 18);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(75, 23);
            this.btnExport.TabIndex = 6;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // dgvBankAmount
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dgvBankAmount.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBankAmount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.Format = "N0";
            dataGridViewCellStyle2.NullValue = null;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBankAmount.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvBankAmount.Location = new System.Drawing.Point(12, 56);
            this.dgvBankAmount.Name = "dgvBankAmount";
            this.dgvBankAmount.RowTemplate.Height = 25;
            this.dgvBankAmount.Size = new System.Drawing.Size(398, 217);
            this.dgvBankAmount.TabIndex = 43;
            // 
            // dgvTooltip
            // 
            this.dgvTooltip.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTooltip.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvTooltip.Location = new System.Drawing.Point(12, 279);
            this.dgvTooltip.Name = "dgvTooltip";
            this.dgvTooltip.RowTemplate.Height = 25;
            this.dgvTooltip.Size = new System.Drawing.Size(398, 680);
            this.dgvTooltip.TabIndex = 41;
            // 
            // cmbDatabasePicker
            // 
            this.cmbDatabasePicker.FormattingEnabled = true;
            this.cmbDatabasePicker.Location = new System.Drawing.Point(12, 18);
            this.cmbDatabasePicker.Name = "cmbDatabasePicker";
            this.cmbDatabasePicker.Size = new System.Drawing.Size(227, 23);
            this.cmbDatabasePicker.TabIndex = 44;
            this.cmbDatabasePicker.SelectedIndexChanged += new System.EventHandler(this.cmbDatabasePicker_SelectedIndexChanged);
            // 
            // dgvYearly
            // 
            this.dgvYearly.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvYearly.Location = new System.Drawing.Point(424, 6);
            this.dgvYearly.Name = "dgvYearly";
            this.dgvYearly.RowTemplate.Height = 25;
            this.dgvYearly.Size = new System.Drawing.Size(1471, 1052);
            this.dgvYearly.TabIndex = 45;
            this.dgvYearly.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // YearlyView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1924, 1062);
            this.Controls.Add(this.dgvYearly);
            this.Controls.Add(this.cmbDatabasePicker);
            this.Controls.Add(this.dgvBankAmount);
            this.Controls.Add(this.dgvTooltip);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.lblTotal);
            this.Name = "YearlyView";
            this.Text = "YearlyView";
            this.Load += new System.EventHandler(this.YearlyView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtoExpenseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBankAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTooltip)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvYearly)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label lblTotal;
        private BindingSource dtoExpenseBindingSource;
        private DataGridView dgvTooltip;
        private Button btnExport;
        private Label label3;
        private DataGridView dgvBankAmount;
        private ComboBox cmbDatabasePicker;
        private DataGridViewTextBoxColumn Category;
        private DataGridView dgvYearly;
    }
}