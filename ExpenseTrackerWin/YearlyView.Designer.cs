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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.datePickerYearly = new System.Windows.Forms.DateTimePicker();
            this.dgvYealy = new System.Windows.Forms.DataGridView();
            this.btnHome = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvYealy)).BeginInit();
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
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvYealy.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvYealy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvYealy.Location = new System.Drawing.Point(28, 56);
            this.dgvYealy.Name = "dgvYealy";
            this.dgvYealy.RowTemplate.Height = 25;
            this.dgvYealy.Size = new System.Drawing.Size(1418, 936);
            this.dgvYealy.TabIndex = 1;
            this.dgvYealy.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(1371, 27);
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
            this.lblTotal.Location = new System.Drawing.Point(269, 27);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(65, 26);
            this.lblTotal.TabIndex = 3;
            this.lblTotal.Text = "label1";
            // 
            // YearlyView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1480, 1004);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.dgvYealy);
            this.Controls.Add(this.datePickerYearly);
            this.Name = "YearlyView";
            this.Text = "YearlyView";
            this.Load += new System.EventHandler(this.YearlyView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvYealy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DateTimePicker datePickerYearly;
        private DataGridView dgvYealy;
        private Button btnHome;
        private Label lblTotal;
    }
}