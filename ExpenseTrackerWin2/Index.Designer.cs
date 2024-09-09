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
            panel2 = new Panel();
            dgvYearly = new DataGridView();
            panel1 = new Panel();
            dgvBankAmount = new DataGridView();
            cmbDatabasePicker = new MaterialSkin.Controls.MaterialComboBox();
            dgvTooltip = new DataGridView();
            tabAddIncome = new TabPage();
            txtAmount = new MaterialSkin.Controls.MaterialTextBox();
            cmbComment = new MaterialSkin.Controls.MaterialComboBox();
            cmbBank = new MaterialSkin.Controls.MaterialComboBox();
            cmbNames = new MaterialSkin.Controls.MaterialComboBox();
            datePicker = new DateTimePicker();
            tabAddTransactions = new TabPage();
            tabViewTransactions = new TabPage();
            tabViewInomce = new TabPage();
            tabHistory = new TabPage();
            tabUserSetting = new TabPage();
            menubarImages = new ImageList(components);
            materialTab.SuspendLayout();
            tabDashboard.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvYearly).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBankAmount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvTooltip).BeginInit();
            tabAddIncome.SuspendLayout();
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
            tabDashboard.Controls.Add(panel2);
            tabDashboard.Controls.Add(panel1);
            tabDashboard.ImageKey = "Dashboard.png";
            tabDashboard.Location = new Point(4, 39);
            tabDashboard.Name = "tabDashboard";
            tabDashboard.Size = new Size(1920, 780);
            tabDashboard.TabIndex = 5;
            tabDashboard.Text = "Dashboard";
            tabDashboard.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(dgvYearly);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(352, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1568, 780);
            panel2.TabIndex = 5;
            // 
            // dgvYearly
            // 
            dgvYearly.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvYearly.Dock = DockStyle.Fill;
            dgvYearly.Location = new Point(0, 0);
            dgvYearly.Name = "dgvYearly";
            dgvYearly.Size = new Size(1568, 780);
            dgvYearly.TabIndex = 3;
            dgvYearly.CellContentClick += dgvYearly_CellContentClick;
            // 
            // panel1
            // 
            panel1.Controls.Add(dgvBankAmount);
            panel1.Controls.Add(cmbDatabasePicker);
            panel1.Controls.Add(dgvTooltip);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(352, 780);
            panel1.TabIndex = 4;
            // 
            // dgvBankAmount
            // 
            dgvBankAmount.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBankAmount.Location = new Point(44, 58);
            dgvBankAmount.Name = "dgvBankAmount";
            dgvBankAmount.Size = new Size(302, 297);
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
            cmbDatabasePicker.Location = new Point(225, 0);
            cmbDatabasePicker.MaxDropDownItems = 4;
            cmbDatabasePicker.MouseState = MaterialSkin.MouseState.OUT;
            cmbDatabasePicker.Name = "cmbDatabasePicker";
            cmbDatabasePicker.Size = new Size(121, 49);
            cmbDatabasePicker.StartIndex = 0;
            cmbDatabasePicker.TabIndex = 0;
            cmbDatabasePicker.SelectedIndexChanged += cmbDatabasePicker_SelectedIndexChanged;
            cmbDatabasePicker.SelectedValueChanged += cmbDatabasePicker_SelectedValueChanged;
            // 
            // dgvTooltip
            // 
            dgvTooltip.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTooltip.Location = new Point(44, 361);
            dgvTooltip.Name = "dgvTooltip";
            dgvTooltip.Size = new Size(302, 416);
            dgvTooltip.TabIndex = 2;
            // 
            // tabAddIncome
            // 
            tabAddIncome.Controls.Add(txtAmount);
            tabAddIncome.Controls.Add(cmbComment);
            tabAddIncome.Controls.Add(cmbBank);
            tabAddIncome.Controls.Add(cmbNames);
            tabAddIncome.Controls.Add(datePicker);
            tabAddIncome.ImageKey = "AddIncome.png";
            tabAddIncome.Location = new Point(4, 39);
            tabAddIncome.Name = "tabAddIncome";
            tabAddIncome.Padding = new Padding(3);
            tabAddIncome.Size = new Size(1920, 780);
            tabAddIncome.TabIndex = 0;
            tabAddIncome.Text = "Add Income";
            tabAddIncome.UseVisualStyleBackColor = true;
            tabAddIncome.Click += tabAddIncome_Click;
            // 
            // txtAmount
            // 
            txtAmount.AnimateReadOnly = false;
            txtAmount.BorderStyle = BorderStyle.None;
            txtAmount.Depth = 0;
            txtAmount.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtAmount.LeadingIcon = null;
            txtAmount.Location = new Point(77, 74);
            txtAmount.MaxLength = 50;
            txtAmount.MouseState = MaterialSkin.MouseState.OUT;
            txtAmount.Multiline = false;
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(100, 50);
            txtAmount.TabIndex = 14;
            txtAmount.Text = "";
            txtAmount.TrailingIcon = null;
            // 
            // cmbComment
            // 
            cmbComment.AutoResize = false;
            cmbComment.BackColor = Color.FromArgb(255, 255, 255);
            cmbComment.Depth = 0;
            cmbComment.DrawMode = DrawMode.OwnerDrawVariable;
            cmbComment.DropDownHeight = 174;
            cmbComment.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbComment.DropDownWidth = 121;
            cmbComment.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cmbComment.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cmbComment.FormattingEnabled = true;
            cmbComment.IntegralHeight = false;
            cmbComment.ItemHeight = 43;
            cmbComment.Location = new Point(804, 91);
            cmbComment.MaxDropDownItems = 4;
            cmbComment.MouseState = MaterialSkin.MouseState.OUT;
            cmbComment.Name = "cmbComment";
            cmbComment.Size = new Size(121, 49);
            cmbComment.StartIndex = 0;
            cmbComment.TabIndex = 12;
            // 
            // cmbBank
            // 
            cmbBank.AutoResize = false;
            cmbBank.BackColor = Color.FromArgb(255, 255, 255);
            cmbBank.Depth = 0;
            cmbBank.DrawMode = DrawMode.OwnerDrawVariable;
            cmbBank.DropDownHeight = 174;
            cmbBank.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBank.DropDownWidth = 121;
            cmbBank.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cmbBank.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cmbBank.FormattingEnabled = true;
            cmbBank.IntegralHeight = false;
            cmbBank.ItemHeight = 43;
            cmbBank.Location = new Point(804, 8);
            cmbBank.MaxDropDownItems = 4;
            cmbBank.MouseState = MaterialSkin.MouseState.OUT;
            cmbBank.Name = "cmbBank";
            cmbBank.Size = new Size(121, 49);
            cmbBank.StartIndex = 0;
            cmbBank.TabIndex = 10;
            // 
            // cmbNames
            // 
            cmbNames.AutoResize = false;
            cmbNames.BackColor = Color.FromArgb(255, 255, 255);
            cmbNames.Depth = 0;
            cmbNames.DrawMode = DrawMode.OwnerDrawVariable;
            cmbNames.DropDownHeight = 174;
            cmbNames.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbNames.DropDownWidth = 121;
            cmbNames.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cmbNames.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cmbNames.FormattingEnabled = true;
            cmbNames.IntegralHeight = false;
            cmbNames.ItemHeight = 43;
            cmbNames.Location = new Point(398, 6);
            cmbNames.MaxDropDownItems = 4;
            cmbNames.MouseState = MaterialSkin.MouseState.OUT;
            cmbNames.Name = "cmbNames";
            cmbNames.Size = new Size(121, 49);
            cmbNames.StartIndex = 0;
            cmbNames.TabIndex = 9;
            cmbNames.SelectionChangeCommitted += cmbNames_SelectionChangeCommitted;
            // 
            // datePicker
            // 
            datePicker.Location = new Point(77, 8);
            datePicker.Margin = new Padding(2);
            datePicker.Name = "datePicker";
            datePicker.Size = new Size(200, 23);
            datePicker.TabIndex = 8;
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
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvYearly).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvBankAmount).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvTooltip).EndInit();
            tabAddIncome.ResumeLayout(false);
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
        private DateTimePicker datePicker;
        private MaterialSkin.Controls.MaterialComboBox cmbNames;
        private MaterialSkin.Controls.MaterialComboBox cmbComment;
        private MaterialSkin.Controls.MaterialComboBox cmbBank;
        private MaterialSkin.Controls.MaterialTextBox txtAmount;
        private Panel panel2;
        private Panel panel1;
    }
}