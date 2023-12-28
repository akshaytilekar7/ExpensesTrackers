namespace ExpenseTrackerWin
{
    partial class Index
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.addExpenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewExpenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addIncomeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yearlyOverviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panleIndexPage = new System.Windows.Forms.Panel();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addExpenseToolStripMenuItem,
            this.viewExpenseToolStripMenuItem,
            this.addIncomeToolStripMenuItem,
            this.yearlyOverviewToolStripMenuItem,
            this.historyToolStripMenuItem,
            this.adminToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1711, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // addExpenseToolStripMenuItem
            // 
            this.addExpenseToolStripMenuItem.Name = "addExpenseToolStripMenuItem";
            this.addExpenseToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.addExpenseToolStripMenuItem.Text = "Add Expense";
            this.addExpenseToolStripMenuItem.Click += new System.EventHandler(this.addExpenseToolStripMenuItem_Click);
            // 
            // viewExpenseToolStripMenuItem
            // 
            this.viewExpenseToolStripMenuItem.Name = "viewExpenseToolStripMenuItem";
            this.viewExpenseToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.viewExpenseToolStripMenuItem.Text = "View Expense";
            this.viewExpenseToolStripMenuItem.Click += new System.EventHandler(this.viewExpenseToolStripMenuItem_Click);
            // 
            // addIncomeToolStripMenuItem
            // 
            this.addIncomeToolStripMenuItem.Name = "addIncomeToolStripMenuItem";
            this.addIncomeToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.addIncomeToolStripMenuItem.Text = "Add Income";
            this.addIncomeToolStripMenuItem.Click += new System.EventHandler(this.addIncomeToolStripMenuItem_Click);
            // 
            // yearlyOverviewToolStripMenuItem
            // 
            this.yearlyOverviewToolStripMenuItem.Name = "yearlyOverviewToolStripMenuItem";
            this.yearlyOverviewToolStripMenuItem.Size = new System.Drawing.Size(102, 20);
            this.yearlyOverviewToolStripMenuItem.Text = "Yearly Overview";
            this.yearlyOverviewToolStripMenuItem.Click += new System.EventHandler(this.yearlyOverviewToolStripMenuItem_Click);
            // 
            // historyToolStripMenuItem
            // 
            this.historyToolStripMenuItem.Name = "historyToolStripMenuItem";
            this.historyToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.historyToolStripMenuItem.Text = "History";
            this.historyToolStripMenuItem.Click += new System.EventHandler(this.historyToolStripMenuItem_Click);
            // 
            // panleIndexPage
            // 
            this.panleIndexPage.Location = new System.Drawing.Point(13, 20);
            this.panleIndexPage.Name = "panleIndexPage";
            this.panleIndexPage.Size = new System.Drawing.Size(1686, 938);
            this.panleIndexPage.TabIndex = 2;
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.adminToolStripMenuItem.Text = "Admin";
            this.adminToolStripMenuItem.Click += new System.EventHandler(this.adminToolStripMenuItem_Click);
            // 
            // Index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1711, 970);
            this.Controls.Add(this.panleIndexPage);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Index";
            this.Text = "Index";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ContextMenuStrip contextMenuStrip1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem addExpenseToolStripMenuItem;
        private ToolStripMenuItem viewExpenseToolStripMenuItem;
        private ToolStripMenuItem addIncomeToolStripMenuItem;
        private ToolStripMenuItem yearlyOverviewToolStripMenuItem;
        private ToolStripMenuItem historyToolStripMenuItem;
        private Panel panleIndexPage;
        private ToolStripMenuItem adminToolStripMenuItem;
    }
}