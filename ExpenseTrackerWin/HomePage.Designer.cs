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
            this.btnAddExpensed.Location = new System.Drawing.Point(476, 191);
            this.btnAddExpensed.Name = "btnAddExpensed";
            this.btnAddExpensed.Size = new System.Drawing.Size(278, 62);
            this.btnAddExpensed.TabIndex = 0;
            this.btnAddExpensed.Text = "Add Expenses";
            this.btnAddExpensed.UseVisualStyleBackColor = true;
            this.btnAddExpensed.Click += new System.EventHandler(this.btnAddExpensed_Click);
            // 
            // btnAddIncome
            // 
            this.btnAddIncome.AutoSize = true;
            this.btnAddIncome.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAddIncome.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddIncome.Location = new System.Drawing.Point(176, 191);
            this.btnAddIncome.Name = "btnAddIncome";
            this.btnAddIncome.Size = new System.Drawing.Size(227, 59);
            this.btnAddIncome.TabIndex = 1;
            this.btnAddIncome.Text = "Add Income";
            this.btnAddIncome.UseVisualStyleBackColor = true;
            this.btnAddIncome.Click += new System.EventHandler(this.btnAddIncome_Click);
            // 
            // btnViewExpense
            // 
            this.btnViewExpense.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnViewExpense.Location = new System.Drawing.Point(797, 191);
            this.btnViewExpense.Name = "btnViewExpense";
            this.btnViewExpense.Size = new System.Drawing.Size(311, 62);
            this.btnViewExpense.TabIndex = 2;
            this.btnViewExpense.Text = "View Expense";
            this.btnViewExpense.UseVisualStyleBackColor = true;
            this.btnViewExpense.Click += new System.EventHandler(this.btnViewExpense_Click);
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1435, 990);
            this.Controls.Add(this.btnViewExpense);
            this.Controls.Add(this.btnAddIncome);
            this.Controls.Add(this.btnAddExpensed);
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
    }
}