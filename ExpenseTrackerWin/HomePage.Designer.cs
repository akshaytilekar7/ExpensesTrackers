namespace ExpenseTrackerWin
{
    partial class HomePage
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
            this.btnAddExpensed = new System.Windows.Forms.Button();
            this.btnAddIncome = new System.Windows.Forms.Button();
            this.btnViewExpense = new System.Windows.Forms.Button();
            this.btnYealry = new System.Windows.Forms.Button();
            this.lblHeader = new System.Windows.Forms.Label();
            this.btnUserSettings = new System.Windows.Forms.Button();
            this.btnYearlyTotal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddExpensed
            // 
            this.btnAddExpensed.Location = new System.Drawing.Point(538, 356);
            this.btnAddExpensed.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddExpensed.Name = "btnAddExpensed";
            this.btnAddExpensed.Size = new System.Drawing.Size(136, 23);
            this.btnAddExpensed.TabIndex = 0;
            this.btnAddExpensed.Text = "Add Expenses";
            this.btnAddExpensed.UseVisualStyleBackColor = true;
            this.btnAddExpensed.Click += new System.EventHandler(this.btnAddExpensed_Click);
            // 
            // btnAddIncome
            // 
            this.btnAddIncome.Location = new System.Drawing.Point(538, 316);
            this.btnAddIncome.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddIncome.Name = "btnAddIncome";
            this.btnAddIncome.Size = new System.Drawing.Size(136, 23);
            this.btnAddIncome.TabIndex = 1;
            this.btnAddIncome.Text = "Add Income";
            this.btnAddIncome.UseVisualStyleBackColor = true;
            this.btnAddIncome.Click += new System.EventHandler(this.btnAddIncome_Click);
            // 
            // btnViewExpense
            // 
            this.btnViewExpense.Location = new System.Drawing.Point(694, 316);
            this.btnViewExpense.Margin = new System.Windows.Forms.Padding(2);
            this.btnViewExpense.Name = "btnViewExpense";
            this.btnViewExpense.Size = new System.Drawing.Size(146, 23);
            this.btnViewExpense.TabIndex = 2;
            this.btnViewExpense.Text = "Monthly Expense";
            this.btnViewExpense.UseVisualStyleBackColor = true;
            this.btnViewExpense.Click += new System.EventHandler(this.btnViewExpense_Click);
            // 
            // btnYealry
            // 
            this.btnYealry.Location = new System.Drawing.Point(694, 356);
            this.btnYealry.Margin = new System.Windows.Forms.Padding(2);
            this.btnYealry.Name = "btnYealry";
            this.btnYealry.Size = new System.Drawing.Size(146, 23);
            this.btnYealry.TabIndex = 3;
            this.btnYealry.Text = "Yealry Expense";
            this.btnYealry.UseVisualStyleBackColor = true;
            this.btnYealry.Click += new System.EventHandler(this.btnYealry_Click);
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Sigmar One", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblHeader.ForeColor = System.Drawing.Color.Teal;
            this.lblHeader.Location = new System.Drawing.Point(456, 87);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(537, 79);
            this.lblHeader.TabIndex = 4;
            this.lblHeader.Text = "Expense Tracker";
            // 
            // btnUserSettings
            // 
            this.btnUserSettings.Location = new System.Drawing.Point(21, 616);
            this.btnUserSettings.Margin = new System.Windows.Forms.Padding(2);
            this.btnUserSettings.Name = "btnUserSettings";
            this.btnUserSettings.Size = new System.Drawing.Size(88, 23);
            this.btnUserSettings.TabIndex = 5;
            this.btnUserSettings.Text = "Admin";
            this.btnUserSettings.UseVisualStyleBackColor = true;
            this.btnUserSettings.Click += new System.EventHandler(this.btnUserSettings_Click);
            // 
            // btnYearlyTotal
            // 
            this.btnYearlyTotal.Location = new System.Drawing.Point(617, 393);
            this.btnYearlyTotal.Margin = new System.Windows.Forms.Padding(2);
            this.btnYearlyTotal.Name = "btnYearlyTotal";
            this.btnYearlyTotal.Size = new System.Drawing.Size(150, 23);
            this.btnYearlyTotal.TabIndex = 6;
            this.btnYearlyTotal.Text = "Yealry Total";
            this.btnYearlyTotal.UseVisualStyleBackColor = true;
            this.btnYearlyTotal.Click += new System.EventHandler(this.btnYearlyTotal_Click);
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1454, 692);
            this.Controls.Add(this.btnYearlyTotal);
            this.Controls.Add(this.btnUserSettings);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.btnYealry);
            this.Controls.Add(this.btnViewExpense);
            this.Controls.Add(this.btnAddIncome);
            this.Controls.Add(this.btnAddExpensed);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "HomePage";
            this.Text = "HomePage";
            this.Load += new System.EventHandler(this.HomePage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnAddExpensed;
        private Button btnAddIncome;
        private Button btnViewExpense;
        private Button btnYealry;
        private Label lblHeader;
        private Button btnUserSettings;
        private Button btnYearlyTotal;
    }
}