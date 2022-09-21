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
            this.SuspendLayout();
            // 
            // btnAddExpensed
            // 
            this.btnAddExpensed.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddExpensed.Location = new System.Drawing.Point(388, 258);
            this.btnAddExpensed.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddExpensed.Name = "btnAddExpensed";
            this.btnAddExpensed.Size = new System.Drawing.Size(218, 43);
            this.btnAddExpensed.TabIndex = 0;
            this.btnAddExpensed.Text = "Add Expenses";
            this.btnAddExpensed.UseVisualStyleBackColor = true;
            this.btnAddExpensed.Click += new System.EventHandler(this.btnAddExpensed_Click);
            // 
            // btnAddIncome
            // 
            this.btnAddIncome.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAddIncome.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddIncome.Location = new System.Drawing.Point(388, 191);
            this.btnAddIncome.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddIncome.Name = "btnAddIncome";
            this.btnAddIncome.Size = new System.Drawing.Size(218, 43);
            this.btnAddIncome.TabIndex = 1;
            this.btnAddIncome.Text = "Add Income";
            this.btnAddIncome.UseVisualStyleBackColor = true;
            this.btnAddIncome.Click += new System.EventHandler(this.btnAddIncome_Click);
            // 
            // btnViewExpense
            // 
            this.btnViewExpense.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnViewExpense.Location = new System.Drawing.Point(388, 331);
            this.btnViewExpense.Margin = new System.Windows.Forms.Padding(2);
            this.btnViewExpense.Name = "btnViewExpense";
            this.btnViewExpense.Size = new System.Drawing.Size(218, 43);
            this.btnViewExpense.TabIndex = 2;
            this.btnViewExpense.Text = "View Expense";
            this.btnViewExpense.UseVisualStyleBackColor = true;
            this.btnViewExpense.Click += new System.EventHandler(this.btnViewExpense_Click);
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1004, 594);
            this.Controls.Add(this.btnViewExpense);
            this.Controls.Add(this.btnAddIncome);
            this.Controls.Add(this.btnAddExpensed);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "HomePage";
            this.Text = "HomePage";
            this.Load += new System.EventHandler(this.HomePage_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnAddExpensed;
        private Button btnAddIncome;
        private Button btnViewExpense;
    }
}