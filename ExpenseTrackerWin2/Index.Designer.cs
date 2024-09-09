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
            DataGridViewCellStyle dataGridViewCellStyle13 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle14 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle15 = new DataGridViewCellStyle();
            materialTab = new MaterialSkin.Controls.MaterialTabControl();
            tabDashboard = new TabPage();
            panel2 = new Panel();
            dgvYearly = new DataGridView();
            panel1 = new Panel();
            dgvBankAmount = new DataGridView();
            cmbDatabasePicker = new MaterialSkin.Controls.MaterialComboBox();
            dgvTooltip = new DataGridView();
            tabAddIncome = new TabPage();
            lblName = new Label();
            lblBank = new Label();
            lblComment = new Label();
            lblAmount = new Label();
            Date = new Label();
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
            dgvIncome = new DataGridView();
            BankName = new DataGridViewTextBoxColumn();
            Comment = new DataGridViewTextBoxColumn();
            btnSave = new MaterialSkin.Controls.MaterialButton();
            btnDelete = new MaterialSkin.Controls.MaterialButton();
            materialTab.SuspendLayout();
            tabDashboard.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvYearly).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBankAmount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvTooltip).BeginInit();
            tabAddIncome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvIncome).BeginInit();
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
            tabAddIncome.Controls.Add(btnDelete);
            tabAddIncome.Controls.Add(btnSave);
            tabAddIncome.Controls.Add(dgvIncome);
            tabAddIncome.Controls.Add(lblName);
            tabAddIncome.Controls.Add(lblBank);
            tabAddIncome.Controls.Add(lblComment);
            tabAddIncome.Controls.Add(lblAmount);
            tabAddIncome.Controls.Add(Date);
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
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(399, 13);
            lblName.Name = "lblName";
            lblName.Size = new Size(39, 15);
            lblName.TabIndex = 20;
            lblName.Text = "Name";
            // 
            // lblBank
            // 
            lblBank.AutoSize = true;
            lblBank.Location = new Point(717, 14);
            lblBank.Name = "lblBank";
            lblBank.Size = new Size(33, 15);
            lblBank.TabIndex = 19;
            lblBank.Text = "Bank";
            // 
            // lblComment
            // 
            lblComment.AutoSize = true;
            lblComment.Location = new Point(399, 96);
            lblComment.Name = "lblComment";
            lblComment.Size = new Size(61, 15);
            lblComment.TabIndex = 18;
            lblComment.Text = "Comment";
            // 
            // lblAmount
            // 
            lblAmount.AutoSize = true;
            lblAmount.Location = new Point(66, 81);
            lblAmount.Name = "lblAmount";
            lblAmount.Size = new Size(51, 15);
            lblAmount.TabIndex = 16;
            lblAmount.Text = "Amount";
            // 
            // Date
            // 
            Date.AutoSize = true;
            Date.Location = new Point(66, 8);
            Date.Name = "Date";
            Date.Size = new Size(44, 15);
            Date.TabIndex = 15;
            Date.Text = "lblDate";
            // 
            // txtAmount
            // 
            txtAmount.AnimateReadOnly = false;
            txtAmount.BorderStyle = BorderStyle.None;
            txtAmount.Depth = 0;
            txtAmount.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtAmount.LeadingIcon = null;
            txtAmount.Location = new Point(137, 61);
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
            cmbComment.Location = new Point(486, 81);
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
            cmbNames.Location = new Point(486, 0);
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
            datePicker.Location = new Point(137, 8);
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
            // dgvIncome
            // 
            dgvIncome.AllowUserToAddRows = false;
            dgvIncome.AllowUserToOrderColumns = true;
            dataGridViewCellStyle13.BackColor = SystemColors.ControlLight;
            dataGridViewCellStyle13.Font = new Font("Calibri", 14.25F);
            dataGridViewCellStyle13.NullValue = null;
            dgvIncome.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            dgvIncome.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle14.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = SystemColors.Control;
            dataGridViewCellStyle14.Font = new Font("Calibri", 14.25F, FontStyle.Bold);
            dataGridViewCellStyle14.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle14.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = DataGridViewTriState.True;
            dgvIncome.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            dgvIncome.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvIncome.Columns.AddRange(new DataGridViewColumn[] { BankName, Comment });
            dataGridViewCellStyle15.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = SystemColors.Window;
            dataGridViewCellStyle15.Font = new Font("Calibri", 14.25F);
            dataGridViewCellStyle15.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle15.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = DataGridViewTriState.False;
            dgvIncome.DefaultCellStyle = dataGridViewCellStyle15;
            dgvIncome.Location = new Point(157, 136);
            dgvIncome.Name = "dgvIncome";
            dgvIncome.Size = new Size(846, 549);
            dgvIncome.TabIndex = 21;
            // 
            // BankName
            // 
            BankName.DataPropertyName = "BankName";
            BankName.HeaderText = "BankName";
            BankName.Name = "BankName";
            // 
            // Comment
            // 
            Comment.DataPropertyName = "Comment";
            Comment.HeaderText = "Comment";
            Comment.Name = "Comment";
            // 
            // btnSave
            // 
            btnSave.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnSave.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnSave.Depth = 0;
            btnSave.HighEmphasis = true;
            btnSave.Icon = null;
            btnSave.Location = new Point(502, 694);
            btnSave.Margin = new Padding(4, 6, 4, 6);
            btnSave.MouseState = MaterialSkin.MouseState.HOVER;
            btnSave.Name = "btnSave";
            btnSave.NoAccentTextColor = Color.Empty;
            btnSave.Size = new Size(64, 36);
            btnSave.TabIndex = 23;
            btnSave.Text = "Save";
            btnSave.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnSave.UseAccentColor = false;
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnDelete
            // 
            btnDelete.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnDelete.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnDelete.Depth = 0;
            btnDelete.HighEmphasis = true;
            btnDelete.Icon = null;
            btnDelete.Location = new Point(584, 694);
            btnDelete.Margin = new Padding(4, 6, 4, 6);
            btnDelete.MouseState = MaterialSkin.MouseState.HOVER;
            btnDelete.Name = "btnDelete";
            btnDelete.NoAccentTextColor = Color.Empty;
            btnDelete.Size = new Size(73, 36);
            btnDelete.TabIndex = 24;
            btnDelete.Text = "Delete";
            btnDelete.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnDelete.UseAccentColor = false;
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
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
            tabAddIncome.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvIncome).EndInit();
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
        private Label Date;
        private Label lblAmount;
        private Label lblName;
        private Label lblBank;
        private Label lblComment;
        private MaterialSkin.Controls.MaterialButton btnSave;
        private DataGridView dgvIncome;
        private DataGridViewTextBoxColumn BankName;
        private DataGridViewTextBoxColumn Comment;
        private MaterialSkin.Controls.MaterialButton btnDelete;
    }
}