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
            this.SuspendLayout();
            // 
            // btnAddExpensed
            // 
            this.btnAddExpensed.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddExpensed.Location = new System.Drawing.Point(411, 241);
            this.btnAddExpensed.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddExpensed.Name = "btnAddExpensed";
            this.btnAddExpensed.Size = new System.Drawing.Size(303, 40);
            this.btnAddExpensed.TabIndex = 0;
            this.btnAddExpensed.Text = "Add Expenses";
            this.btnAddExpensed.UseVisualStyleBackColor = true;
            this.btnAddExpensed.Click += new System.EventHandler(this.btnAddExpensed_Click);
            // 
            // btnAddIncome
            // 
            this.btnAddIncome.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAddIncome.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddIncome.Location = new System.Drawing.Point(411, 178);
            this.btnAddIncome.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddIncome.Name = "btnAddIncome";
            this.btnAddIncome.Size = new System.Drawing.Size(303, 40);
            this.btnAddIncome.TabIndex = 1;
            this.btnAddIncome.Text = "Add Income";
            this.btnAddIncome.UseVisualStyleBackColor = true;
            this.btnAddIncome.Click += new System.EventHandler(this.btnAddIncome_Click);
            // 
            // btnViewExpense
            // 
            this.btnViewExpense.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnViewExpense.Location = new System.Drawing.Point(411, 309);
            this.btnViewExpense.Margin = new System.Windows.Forms.Padding(2);
            this.btnViewExpense.Name = "btnViewExpense";
            this.btnViewExpense.Size = new System.Drawing.Size(303, 40);
            this.btnViewExpense.TabIndex = 2;
            this.btnViewExpense.Text = "View Expense";
            this.btnViewExpense.UseVisualStyleBackColor = true;
            this.btnViewExpense.Click += new System.EventHandler(this.btnViewExpense_Click);
            // 
            // btnYealry
            // 
            this.btnYealry.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnYealry.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnYealry.Location = new System.Drawing.Point(411, 371);
            this.btnYealry.Margin = new System.Windows.Forms.Padding(2);
            this.btnYealry.Name = "btnYealry";
            this.btnYealry.Size = new System.Drawing.Size(303, 40);
            this.btnYealry.TabIndex = 3;
            this.btnYealry.Text = "Yealry Expense View";
            this.btnYealry.UseVisualStyleBackColor = true;
            this.btnYealry.Click += new System.EventHandler(this.btnYealry_Click);
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Sigmar One", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblHeader.ForeColor = System.Drawing.Color.Red;
            this.lblHeader.Location = new System.Drawing.Point(290, 23);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(537, 79);
            this.lblHeader.TabIndex = 4;
            this.lblHeader.Text = "Expense Tracker";
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1147, 554);
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
    }
}