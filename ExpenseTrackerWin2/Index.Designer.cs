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
            tabDashboard = new TabPage();
            dgvYearly = new DataGridView();
            dgvTooltip = new DataGridView();
            dgvBankAmount = new DataGridView();
            cmbDatabasePicker = new MaterialSkin.Controls.MaterialComboBox();
            tabAddIncome = new TabPage();
            tabAddTransactions = new TabPage();
            tabViewTransactions = new TabPage();
            tabViewInomce = new TabPage();
            tabHistory = new TabPage();
            tabUserSetting = new TabPage();
            menubarImages = new ImageList(components);
            materialTab.SuspendLayout();
            tabDashboard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvYearly).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvTooltip).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvBankAmount).BeginInit();
            SuspendLayout();
            // 
            // materialTab
            // 
            materialTab.Controls.Add(tabDashboard);
            materialTab.Controls.Add(tabAddIncome);
            materialTab.Controls.Add(tabAddTransactions);
            materialTab.Controls.Add(tabViewTransactions);
            materialTab.Controls.Add(tabViewInomce);
            materialTab.Controls.Add(tabHistory);
            materialTab.Controls.Add(tabUserSetting);
            materialTab.Depth = 0;
            materialTab.ImageList = menubarImages;
            materialTab.Location = new Point(6, 67);
            materialTab.MouseState = MaterialSkin.MouseState.HOVER;
            materialTab.Multiline = true;
            materialTab.Name = "materialTab";
            materialTab.SelectedIndex = 0;
            materialTab.Size = new Size(1928, 823);
            materialTab.TabIndex = 0;
            // 
            // tabDashboard
            // 
            tabDashboard.Controls.Add(dgvYearly);
            tabDashboard.Controls.Add(dgvTooltip);
            tabDashboard.Controls.Add(dgvBankAmount);
            tabDashboard.Controls.Add(cmbDatabasePicker);
            tabDashboard.ImageKey = "Dashboard.png";
            tabDashboard.Location = new Point(4, 39);
            tabDashboard.Name = "tabDashboard";
            tabDashboard.Size = new Size(1920, 780);
            tabDashboard.TabIndex = 5;
            tabDashboard.Text = "Dashboard";
            tabDashboard.UseVisualStyleBackColor = true;
            // 
            // dgvYearly
            // 
            dgvYearly.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvYearly.Dock = DockStyle.Right;
            dgvYearly.Location = new Point(453, 0);
            dgvYearly.Name = "dgvYearly";
            dgvYearly.Size = new Size(1467, 780);
            dgvYearly.TabIndex = 3;
            dgvYearly.CellContentClick += dgvYearly_CellContentClick;
            // 
            // dgvTooltip
            // 
            dgvTooltip.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTooltip.Location = new Point(65, 352);
            dgvTooltip.Name = "dgvTooltip";
            dgvTooltip.Size = new Size(382, 423);
            dgvTooltip.TabIndex = 2;
            // 
            // dgvBankAmount
            // 
            dgvBankAmount.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBankAmount.Location = new Point(65, 60);
            dgvBankAmount.Name = "dgvBankAmount";
            dgvBankAmount.Size = new Size(382, 286);
            dgvBankAmount.TabIndex = 1;
            // 
            // cmbDatabasePicker
            // 
            cmbDatabasePicker.AutoResize = false;
            cmbDatabasePicker.BackColor = Color.FromArgb(255, 255, 255);
            cmbDatabasePicker.Depth = 0;
            cmbDatabasePicker.DrawMode = DrawMode.OwnerDrawVariable;
            cmbDatabasePicker.DropDownHeight = 174;
            cmbDatabasePicker.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDatabasePicker.DropDownWidth = 121;
            cmbDatabasePicker.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cmbDatabasePicker.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cmbDatabasePicker.FormattingEnabled = true;
            cmbDatabasePicker.IntegralHeight = false;
            cmbDatabasePicker.ItemHeight = 43;
            cmbDatabasePicker.Items.AddRange(new object[] { "2022", "2023", "2024" });
            cmbDatabasePicker.Location = new Point(65, 5);
            cmbDatabasePicker.MaxDropDownItems = 4;
            cmbDatabasePicker.MouseState = MaterialSkin.MouseState.OUT;
            cmbDatabasePicker.Name = "cmbDatabasePicker";
            cmbDatabasePicker.Size = new Size(121, 49);
            cmbDatabasePicker.StartIndex = 0;
            cmbDatabasePicker.TabIndex = 0;
            cmbDatabasePicker.SelectedIndexChanged += cmbDatabasePicker_SelectedIndexChanged;
            cmbDatabasePicker.SelectedValueChanged += cmbDatabasePicker_SelectedValueChanged;
            // 
            // tabAddIncome
            // 
            tabAddIncome.ImageKey = "AddIncome.png";
            tabAddIncome.Location = new Point(4, 39);
            tabAddIncome.Name = "tabAddIncome";
            tabAddIncome.Padding = new Padding(3);
            tabAddIncome.Size = new Size(1920, 780);
            tabAddIncome.TabIndex = 0;
            tabAddIncome.Text = "Add Income";
            tabAddIncome.UseVisualStyleBackColor = true;
            // 
            // tabAddTransactions
            // 
            tabAddTransactions.ImageKey = "AddExpenses.png";
            tabAddTransactions.Location = new Point(4, 39);
            tabAddTransactions.Name = "tabAddTransactions";
            tabAddTransactions.Padding = new Padding(3);
            tabAddTransactions.Size = new Size(1920, 780);
            tabAddTransactions.TabIndex = 1;
            tabAddTransactions.Text = "Add Transactions";
            tabAddTransactions.UseVisualStyleBackColor = true;
            // 
            // tabViewTransactions
            // 
            tabViewTransactions.ImageKey = "ViewExpenses.png";
            tabViewTransactions.Location = new Point(4, 39);
            tabViewTransactions.Name = "tabViewTransactions";
            tabViewTransactions.Padding = new Padding(3);
            tabViewTransactions.Size = new Size(1920, 780);
            tabViewTransactions.TabIndex = 2;
            tabViewTransactions.Text = "View Transactions";
            tabViewTransactions.UseVisualStyleBackColor = true;
            // 
            // tabViewInomce
            // 
            tabViewInomce.ImageKey = "ViewIncome.png";
            tabViewInomce.Location = new Point(4, 39);
            tabViewInomce.Name = "tabViewInomce";
            tabViewInomce.Size = new Size(1920, 780);
            tabViewInomce.TabIndex = 3;
            tabViewInomce.Text = "View Inomce";
            tabViewInomce.UseVisualStyleBackColor = true;
            // 
            // tabHistory
            // 
            tabHistory.ImageKey = "History.png";
            tabHistory.Location = new Point(4, 39);
            tabHistory.Name = "tabHistory";
            tabHistory.Size = new Size(1920, 780);
            tabHistory.TabIndex = 6;
            tabHistory.Text = "History";
            tabHistory.UseVisualStyleBackColor = true;
            // 
            // tabUserSetting
            // 
            tabUserSetting.ImageKey = "UserSetting.png";
            tabUserSetting.Location = new Point(4, 39);
            tabUserSetting.Name = "tabUserSetting";
            tabUserSetting.Size = new Size(1920, 780);
            tabUserSetting.TabIndex = 4;
            tabUserSetting.Text = "User Setting";
            tabUserSetting.UseVisualStyleBackColor = true;
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
            ClientSize = new Size(1940, 903);
            Controls.Add(materialTab);
            DrawerShowIconsWhenHidden = true;
            DrawerTabControl = materialTab;
            Name = "Index";
            Text = "Expense Tracker";
            materialTab.ResumeLayout(false);
            tabDashboard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvYearly).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvTooltip).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvBankAmount).EndInit();
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
        private MaterialSkin.Controls.MaterialComboBox cmbDatabasePicker;
        private DataGridView dgvBankAmount;
        private DataGridView dgvTooltip;
        private DataGridView dgvYearly;
    }
}