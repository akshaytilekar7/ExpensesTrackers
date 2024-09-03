namespace ExpenseTrackerWin2
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Index));
            materialTab = new MaterialSkin.Controls.MaterialTabControl();
            tabAddIncome = new TabPage();
            tabAddTransactions = new TabPage();
            tabViewTransactions = new TabPage();
            tabViewInomce = new TabPage();
            tabUserSetting = new TabPage();
            tabDashboard = new TabPage();
            tabHistory = new TabPage();
            menubarImages = new ImageList(components);
            materialTab.SuspendLayout();
            SuspendLayout();
            // 
            // materialTab
            // 
            materialTab.Controls.Add(tabAddIncome);
            materialTab.Controls.Add(tabAddTransactions);
            materialTab.Controls.Add(tabViewTransactions);
            materialTab.Controls.Add(tabViewInomce);
            materialTab.Controls.Add(tabUserSetting);
            materialTab.Controls.Add(tabDashboard);
            materialTab.Controls.Add(tabHistory);
            materialTab.Depth = 0;
            materialTab.ImageList = menubarImages;
            materialTab.Location = new Point(6, 67);
            materialTab.MouseState = MaterialSkin.MouseState.HOVER;
            materialTab.Multiline = true;
            materialTab.Name = "materialTab";
            materialTab.SelectedIndex = 0;
            materialTab.Size = new Size(788, 100);
            materialTab.TabIndex = 0;
            // 
            // tabAddIncome
            // 
            tabAddIncome.ImageKey = "AddIncome.png";
            tabAddIncome.Location = new Point(4, 74);
            tabAddIncome.Name = "tabAddIncome";
            tabAddIncome.Padding = new Padding(3);
            tabAddIncome.Size = new Size(780, 22);
            tabAddIncome.TabIndex = 0;
            tabAddIncome.Text = "Add Income";
            tabAddIncome.UseVisualStyleBackColor = true;
            // 
            // tabAddTransactions
            // 
            tabAddTransactions.ImageKey = "AddExpenses.png";
            tabAddTransactions.Location = new Point(4, 74);
            tabAddTransactions.Name = "tabAddTransactions";
            tabAddTransactions.Padding = new Padding(3);
            tabAddTransactions.Size = new Size(780, 22);
            tabAddTransactions.TabIndex = 1;
            tabAddTransactions.Text = "Add Transactions";
            tabAddTransactions.UseVisualStyleBackColor = true;
            // 
            // tabViewTransactions
            // 
            tabViewTransactions.ImageKey = "ViewExpenses.png";
            tabViewTransactions.Location = new Point(4, 74);
            tabViewTransactions.Name = "tabViewTransactions";
            tabViewTransactions.Padding = new Padding(3);
            tabViewTransactions.Size = new Size(780, 22);
            tabViewTransactions.TabIndex = 2;
            tabViewTransactions.Text = "View Transactions";
            tabViewTransactions.UseVisualStyleBackColor = true;
            // 
            // tabViewInomce
            // 
            tabViewInomce.ImageKey = "ViewIncome.png";
            tabViewInomce.Location = new Point(4, 74);
            tabViewInomce.Name = "tabViewInomce";
            tabViewInomce.Size = new Size(780, 22);
            tabViewInomce.TabIndex = 3;
            tabViewInomce.Text = "View Inomce";
            tabViewInomce.UseVisualStyleBackColor = true;
            // 
            // tabUserSetting
            // 
            tabUserSetting.ImageKey = "UserSetting.png";
            tabUserSetting.Location = new Point(4, 74);
            tabUserSetting.Name = "tabUserSetting";
            tabUserSetting.Size = new Size(780, 22);
            tabUserSetting.TabIndex = 4;
            tabUserSetting.Text = "User Setting";
            tabUserSetting.UseVisualStyleBackColor = true;
            // 
            // tabDashboard
            // 
            tabDashboard.ImageKey = "Dashboard.png";
            tabDashboard.Location = new Point(4, 74);
            tabDashboard.Name = "tabDashboard";
            tabDashboard.Size = new Size(780, 22);
            tabDashboard.TabIndex = 5;
            tabDashboard.Text = "Dashboard";
            tabDashboard.UseVisualStyleBackColor = true;
            // 
            // tabHistory
            // 
            tabHistory.ImageKey = "History.png";
            tabHistory.Location = new Point(4, 74);
            tabHistory.Name = "tabHistory";
            tabHistory.Size = new Size(780, 22);
            tabHistory.TabIndex = 6;
            tabHistory.Text = "History";
            tabHistory.UseVisualStyleBackColor = true;
            // 
            // menubarImages
            // 
            menubarImages.ColorDepth = ColorDepth.Depth32Bit;
            menubarImages.ImageStream = (ImageListStreamer)resources.GetObject("menubarImages.ImageStream");
            menubarImages.TransparentColor = Color.Transparent;
            menubarImages.Images.SetKeyName(0, "ViewExpenses.png");
            menubarImages.Images.SetKeyName(1, "ViewIncome.png");
            menubarImages.Images.SetKeyName(2, "UserSetting.png");
            menubarImages.Images.SetKeyName(3, "Dashboard.png");
            menubarImages.Images.SetKeyName(4, "History.png");
            menubarImages.Images.SetKeyName(5, "AddIncome.png");
            menubarImages.Images.SetKeyName(6, "AddExpenses.png");
            // 
            // Index
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(materialTab);
            DrawerShowIconsWhenHidden = true;
            DrawerTabControl = materialTab;
            Name = "Index";
            Text = "Expense Tracker";
            materialTab.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl materialTab;
        private TabPage tabAddIncome;
        private TabPage tabAddTransactions;
        private ImageList menubarImages;
        private TabPage tabViewInomce;
        private TabPage tabViewTransactions;
        private TabPage tabUserSetting;
        private TabPage tabDashboard;
        private TabPage tabHistory;
    }
}