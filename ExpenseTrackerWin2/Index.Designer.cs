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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
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
            btnDelete = new MaterialSkin.Controls.MaterialButton();
            btnSave = new MaterialSkin.Controls.MaterialButton();
            dgvIncome = new DataGridView();
            BankName = new DataGridViewTextBoxColumn();
            Comment = new DataGridViewTextBoxColumn();
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
            lblATError = new Label();
            btnATClear = new MaterialSkin.Controls.MaterialButton();
            btnATUpload = new MaterialSkin.Controls.MaterialButton();
            btnATSave = new MaterialSkin.Controls.MaterialButton();
            dgvExpenses = new DataGridView();
            Day = new DataGridViewTextBoxColumn();
            Category = new DataGridViewComboBoxColumn();
            Amount = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            cmbATBank = new MaterialSkin.Controls.MaterialComboBox();
            cmbATnames = new MaterialSkin.Controls.MaterialComboBox();
            datePickerAT = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            lblBDate = new Label();
            tabViewTransactions = new TabPage();
            dgvFilter = new DataGridView();
            User = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            Balance = new DataGridViewTextBoxColumn();
            lblVTError = new Label();
            cmbVTBanks = new MaterialSkin.Controls.MaterialComboBox();
            cmbVTUser = new MaterialSkin.Controls.MaterialComboBox();
            cmbCategory = new MaterialSkin.Controls.MaterialComboBox();
            cmbExpensesType = new MaterialSkin.Controls.MaterialComboBox();
            btnVTDelete = new MaterialSkin.Controls.MaterialButton();
            btnVTClear = new MaterialSkin.Controls.MaterialButton();
            btnVTSearch = new MaterialSkin.Controls.MaterialButton();
            label3 = new Label();
            label4 = new Label();
            txtComment = new TextBox();
            label5 = new Label();
            txtVTAmount = new TextBox();
            label6 = new Label();
            lblCategoryMain = new Label();
            lblSubCategory = new Label();
            dateEnd = new DateTimePicker();
            label7 = new Label();
            dateStart = new DateTimePicker();
            lblDate = new Label();
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
            ((System.ComponentModel.ISupportInitialize)dgvIncome).BeginInit();
            tabAddTransactions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvExpenses).BeginInit();
            tabViewTransactions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvFilter).BeginInit();
            SuspendLayout();
            // 
            // materialTab
            // 
            materialTab.Controls.Add(tabDashboard);
            materialTab.Controls.Add(tabAddIncome);
            materialTab.Controls.Add(tabAddTransactions);
            materialTab.Controls.Add(tabViewTransactions);
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
            // dgvIncome
            // 
            dgvIncome.AllowUserToAddRows = false;
            dgvIncome.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = SystemColors.ControlLight;
            dataGridViewCellStyle1.Font = new Font("Calibri", 14.25F);
            dataGridViewCellStyle1.NullValue = null;
            dgvIncome.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvIncome.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Calibri", 14.25F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvIncome.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvIncome.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvIncome.Columns.AddRange(new DataGridViewColumn[] { BankName, Comment });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Calibri", 14.25F);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvIncome.DefaultCellStyle = dataGridViewCellStyle3;
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
            tabAddTransactions.Controls.Add(lblATError);
            tabAddTransactions.Controls.Add(btnATClear);
            tabAddTransactions.Controls.Add(btnATUpload);
            tabAddTransactions.Controls.Add(btnATSave);
            tabAddTransactions.Controls.Add(dgvExpenses);
            tabAddTransactions.Controls.Add(cmbATBank);
            tabAddTransactions.Controls.Add(cmbATnames);
            tabAddTransactions.Controls.Add(datePickerAT);
            tabAddTransactions.Controls.Add(label1);
            tabAddTransactions.Controls.Add(label2);
            tabAddTransactions.Controls.Add(lblBDate);
            tabAddTransactions.ImageKey = "AddExpenses.png";
            tabAddTransactions.Location = new Point(4, 39);
            tabAddTransactions.Name = "tabAddTransactions";
            tabAddTransactions.Padding = new Padding(3);
            tabAddTransactions.Size = new Size(1920, 780);
            tabAddTransactions.TabIndex = 1;
            tabAddTransactions.Text = "Add Transactions";
            tabAddTransactions.UseVisualStyleBackColor = true;
            // 
            // lblATError
            // 
            lblATError.AutoSize = true;
            lblATError.Location = new Point(119, 3);
            lblATError.Margin = new Padding(2, 0, 2, 0);
            lblATError.Name = "lblATError";
            lblATError.Size = new Size(0, 15);
            lblATError.TabIndex = 43;
            // 
            // btnATClear
            // 
            btnATClear.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnATClear.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnATClear.Depth = 0;
            btnATClear.HighEmphasis = true;
            btnATClear.Icon = null;
            btnATClear.Location = new Point(494, 733);
            btnATClear.Margin = new Padding(4, 6, 4, 6);
            btnATClear.MouseState = MaterialSkin.MouseState.HOVER;
            btnATClear.Name = "btnATClear";
            btnATClear.NoAccentTextColor = Color.Empty;
            btnATClear.Size = new Size(66, 36);
            btnATClear.TabIndex = 42;
            btnATClear.Text = "Clear";
            btnATClear.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnATClear.UseAccentColor = false;
            btnATClear.UseVisualStyleBackColor = true;
            btnATClear.Click += btnATClear_Click;
            // 
            // btnATUpload
            // 
            btnATUpload.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnATUpload.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnATUpload.Depth = 0;
            btnATUpload.HighEmphasis = true;
            btnATUpload.Icon = null;
            btnATUpload.Location = new Point(408, 733);
            btnATUpload.Margin = new Padding(4, 6, 4, 6);
            btnATUpload.MouseState = MaterialSkin.MouseState.HOVER;
            btnATUpload.Name = "btnATUpload";
            btnATUpload.NoAccentTextColor = Color.Empty;
            btnATUpload.Size = new Size(78, 36);
            btnATUpload.TabIndex = 41;
            btnATUpload.Text = "Upload";
            btnATUpload.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnATUpload.UseAccentColor = false;
            btnATUpload.UseVisualStyleBackColor = true;
            btnATUpload.Click += btnATUpload_Click;
            // 
            // btnATSave
            // 
            btnATSave.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnATSave.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnATSave.Depth = 0;
            btnATSave.HighEmphasis = true;
            btnATSave.Icon = null;
            btnATSave.Location = new Point(336, 733);
            btnATSave.Margin = new Padding(4, 6, 4, 6);
            btnATSave.MouseState = MaterialSkin.MouseState.HOVER;
            btnATSave.Name = "btnATSave";
            btnATSave.NoAccentTextColor = Color.Empty;
            btnATSave.Size = new Size(64, 36);
            btnATSave.TabIndex = 40;
            btnATSave.Text = "Save";
            btnATSave.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnATSave.UseAccentColor = false;
            btnATSave.UseVisualStyleBackColor = true;
            btnATSave.Click += btnATSave_Click;
            // 
            // dgvExpenses
            // 
            dgvExpenses.AllowUserToOrderColumns = true;
            dataGridViewCellStyle4.BackColor = Color.Gainsboro;
            dataGridViewCellStyle4.SelectionBackColor = Color.Transparent;
            dataGridViewCellStyle4.SelectionForeColor = Color.Black;
            dgvExpenses.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dgvExpenses.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvExpenses.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvExpenses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvExpenses.Columns.AddRange(new DataGridViewColumn[] { Day, Category, Amount, dataGridViewTextBoxColumn1 });
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = SystemColors.Window;
            dataGridViewCellStyle9.Font = new Font("Calibri", 20.25F);
            dataGridViewCellStyle9.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle9.Format = "N0";
            dataGridViewCellStyle9.NullValue = null;
            dataGridViewCellStyle9.SelectionBackColor = Color.Transparent;
            dataGridViewCellStyle9.SelectionForeColor = Color.Black;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.False;
            dgvExpenses.DefaultCellStyle = dataGridViewCellStyle9;
            dgvExpenses.Location = new Point(51, 87);
            dgvExpenses.Name = "dgvExpenses";
            dgvExpenses.RowHeadersWidth = 62;
            dgvExpenses.Size = new Size(979, 637);
            dgvExpenses.TabIndex = 39;
            // 
            // Day
            // 
            Day.DataPropertyName = "Day";
            dataGridViewCellStyle5.Font = new Font("Calibri", 20.25F);
            Day.DefaultCellStyle = dataGridViewCellStyle5;
            Day.HeaderText = "Day";
            Day.MinimumWidth = 8;
            Day.Name = "Day";
            Day.Width = 52;
            // 
            // Category
            // 
            Category.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Category.DataPropertyName = "Category";
            dataGridViewCellStyle6.Font = new Font("Calibri", 20.25F);
            Category.DefaultCellStyle = dataGridViewCellStyle6;
            Category.DisplayStyle = DataGridViewComboBoxDisplayStyle.ComboBox;
            Category.HeaderText = "Category";
            Category.MaxDropDownItems = 5;
            Category.MinimumWidth = 100;
            Category.Name = "Category";
            Category.Resizable = DataGridViewTriState.True;
            Category.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // Amount
            // 
            Amount.DataPropertyName = "Amount";
            dataGridViewCellStyle7.Font = new Font("Calibri", 20.25F);
            Amount.DefaultCellStyle = dataGridViewCellStyle7;
            Amount.HeaderText = "Amount";
            Amount.MinimumWidth = 8;
            Amount.Name = "Amount";
            Amount.Width = 76;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle8.Font = new Font("Calibri", 20.25F);
            dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle8;
            dataGridViewTextBoxColumn1.HeaderText = "Comment";
            dataGridViewTextBoxColumn1.MinimumWidth = 8;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.Width = 86;
            // 
            // cmbATBank
            // 
            cmbATBank.AutoResize = false;
            cmbATBank.BackColor = Color.FromArgb(255, 255, 255);
            cmbATBank.Depth = 0;
            cmbATBank.DrawMode = DrawMode.OwnerDrawVariable;
            cmbATBank.DropDownHeight = 174;
            cmbATBank.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbATBank.DropDownWidth = 121;
            cmbATBank.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cmbATBank.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cmbATBank.FormattingEnabled = true;
            cmbATBank.IntegralHeight = false;
            cmbATBank.ItemHeight = 43;
            cmbATBank.Location = new Point(818, 35);
            cmbATBank.MaxDropDownItems = 4;
            cmbATBank.MouseState = MaterialSkin.MouseState.OUT;
            cmbATBank.Name = "cmbATBank";
            cmbATBank.Size = new Size(121, 49);
            cmbATBank.StartIndex = 0;
            cmbATBank.TabIndex = 38;
            // 
            // cmbATnames
            // 
            cmbATnames.AutoResize = false;
            cmbATnames.BackColor = Color.FromArgb(255, 255, 255);
            cmbATnames.Depth = 0;
            cmbATnames.DrawMode = DrawMode.OwnerDrawVariable;
            cmbATnames.DropDownHeight = 174;
            cmbATnames.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbATnames.DropDownWidth = 121;
            cmbATnames.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cmbATnames.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cmbATnames.IntegralHeight = false;
            cmbATnames.ItemHeight = 43;
            cmbATnames.Location = new Point(555, 37);
            cmbATnames.MaxDropDownItems = 4;
            cmbATnames.MouseState = MaterialSkin.MouseState.OUT;
            cmbATnames.Name = "cmbATnames";
            cmbATnames.Size = new Size(121, 49);
            cmbATnames.StartIndex = 0;
            cmbATnames.TabIndex = 0;
            // 
            // datePickerAT
            // 
            datePickerAT.Location = new Point(181, 38);
            datePickerAT.Margin = new Padding(2);
            datePickerAT.Name = "datePickerAT";
            datePickerAT.Size = new Size(281, 23);
            datePickerAT.TabIndex = 36;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(746, 44);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(33, 15);
            label1.TabIndex = 35;
            label1.Text = "Bank";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(494, 40);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 34;
            label2.Text = "Name";
            // 
            // lblBDate
            // 
            lblBDate.AutoSize = true;
            lblBDate.Location = new Point(119, 40);
            lblBDate.Margin = new Padding(2, 0, 2, 0);
            lblBDate.Name = "lblBDate";
            lblBDate.Size = new Size(31, 15);
            lblBDate.TabIndex = 33;
            lblBDate.Text = "Date";
            // 
            // tabViewTransactions
            // 
            tabViewTransactions.Controls.Add(dgvFilter);
            tabViewTransactions.Controls.Add(lblVTError);
            tabViewTransactions.Controls.Add(cmbVTBanks);
            tabViewTransactions.Controls.Add(cmbVTUser);
            tabViewTransactions.Controls.Add(cmbCategory);
            tabViewTransactions.Controls.Add(cmbExpensesType);
            tabViewTransactions.Controls.Add(btnVTDelete);
            tabViewTransactions.Controls.Add(btnVTClear);
            tabViewTransactions.Controls.Add(btnVTSearch);
            tabViewTransactions.Controls.Add(label3);
            tabViewTransactions.Controls.Add(label4);
            tabViewTransactions.Controls.Add(txtComment);
            tabViewTransactions.Controls.Add(label5);
            tabViewTransactions.Controls.Add(txtVTAmount);
            tabViewTransactions.Controls.Add(label6);
            tabViewTransactions.Controls.Add(lblCategoryMain);
            tabViewTransactions.Controls.Add(lblSubCategory);
            tabViewTransactions.Controls.Add(dateEnd);
            tabViewTransactions.Controls.Add(label7);
            tabViewTransactions.Controls.Add(dateStart);
            tabViewTransactions.Controls.Add(lblDate);
            tabViewTransactions.ImageKey = "ViewExpenses.png";
            tabViewTransactions.Location = new Point(4, 39);
            tabViewTransactions.Name = "tabViewTransactions";
            tabViewTransactions.Padding = new Padding(3);
            tabViewTransactions.Size = new Size(1920, 780);
            tabViewTransactions.TabIndex = 2;
            tabViewTransactions.Text = "View Transactions";
            tabViewTransactions.UseVisualStyleBackColor = true;
            // 
            // dgvFilter
            // 
            dataGridViewCellStyle10.BackColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle10.Font = new Font("Calibri", 14.25F);
            dataGridViewCellStyle10.ForeColor = Color.Black;
            dataGridViewCellStyle10.SelectionBackColor = Color.FromArgb(0, 0, 192);
            dataGridViewCellStyle10.SelectionForeColor = Color.White;
            dgvFilter.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            dgvFilter.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFilter.Columns.AddRange(new DataGridViewColumn[] { User, dataGridViewTextBoxColumn5, Balance });
            dataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = SystemColors.Window;
            dataGridViewCellStyle12.Font = new Font("Calibri", 14.25F);
            dataGridViewCellStyle12.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle12.NullValue = null;
            dataGridViewCellStyle12.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = DataGridViewTriState.False;
            dgvFilter.DefaultCellStyle = dataGridViewCellStyle12;
            dgvFilter.Location = new Point(6, 220);
            dgvFilter.Name = "dgvFilter";
            dgvFilter.RowHeadersWidth = 62;
            dgvFilter.Size = new Size(1268, 520);
            dgvFilter.TabIndex = 61;
            // 
            // User
            // 
            User.DataPropertyName = "User";
            User.HeaderText = "User";
            User.MinimumWidth = 8;
            User.Name = "User";
            User.Width = 150;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.DataPropertyName = "BankName";
            dataGridViewTextBoxColumn5.HeaderText = "BankName";
            dataGridViewTextBoxColumn5.MinimumWidth = 8;
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.Width = 150;
            // 
            // Balance
            // 
            Balance.DataPropertyName = "Balance";
            dataGridViewCellStyle11.Format = "N2";
            dataGridViewCellStyle11.NullValue = null;
            Balance.DefaultCellStyle = dataGridViewCellStyle11;
            Balance.HeaderText = "Balance";
            Balance.Name = "Balance";
            // 
            // lblVTError
            // 
            lblVTError.AutoSize = true;
            lblVTError.Location = new Point(148, 219);
            lblVTError.Name = "lblVTError";
            lblVTError.Size = new Size(0, 15);
            lblVTError.TabIndex = 60;
            // 
            // cmbVTBanks
            // 
            cmbVTBanks.AutoResize = false;
            cmbVTBanks.BackColor = Color.FromArgb(255, 255, 255);
            cmbVTBanks.Depth = 0;
            cmbVTBanks.DrawMode = DrawMode.OwnerDrawVariable;
            cmbVTBanks.DropDownHeight = 174;
            cmbVTBanks.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbVTBanks.DropDownWidth = 121;
            cmbVTBanks.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cmbVTBanks.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cmbVTBanks.FormattingEnabled = true;
            cmbVTBanks.IntegralHeight = false;
            cmbVTBanks.ItemHeight = 43;
            cmbVTBanks.Location = new Point(838, 124);
            cmbVTBanks.MaxDropDownItems = 4;
            cmbVTBanks.MouseState = MaterialSkin.MouseState.OUT;
            cmbVTBanks.Name = "cmbVTBanks";
            cmbVTBanks.Size = new Size(200, 49);
            cmbVTBanks.StartIndex = 0;
            cmbVTBanks.TabIndex = 59;
            // 
            // cmbVTUser
            // 
            cmbVTUser.AutoResize = false;
            cmbVTUser.BackColor = Color.FromArgb(255, 255, 255);
            cmbVTUser.Depth = 0;
            cmbVTUser.DrawMode = DrawMode.OwnerDrawVariable;
            cmbVTUser.DropDownHeight = 174;
            cmbVTUser.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbVTUser.DropDownWidth = 121;
            cmbVTUser.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cmbVTUser.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cmbVTUser.FormattingEnabled = true;
            cmbVTUser.IntegralHeight = false;
            cmbVTUser.ItemHeight = 43;
            cmbVTUser.Location = new Point(838, 64);
            cmbVTUser.MaxDropDownItems = 4;
            cmbVTUser.MouseState = MaterialSkin.MouseState.OUT;
            cmbVTUser.Name = "cmbVTUser";
            cmbVTUser.Size = new Size(200, 49);
            cmbVTUser.StartIndex = 0;
            cmbVTUser.TabIndex = 58;
            // 
            // cmbCategory
            // 
            cmbCategory.AutoResize = false;
            cmbCategory.BackColor = Color.FromArgb(255, 255, 255);
            cmbCategory.Depth = 0;
            cmbCategory.DrawMode = DrawMode.OwnerDrawVariable;
            cmbCategory.DropDownHeight = 174;
            cmbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategory.DropDownWidth = 121;
            cmbCategory.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cmbCategory.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cmbCategory.FormattingEnabled = true;
            cmbCategory.IntegralHeight = false;
            cmbCategory.ItemHeight = 43;
            cmbCategory.Location = new Point(552, 64);
            cmbCategory.MaxDropDownItems = 4;
            cmbCategory.MouseState = MaterialSkin.MouseState.OUT;
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(200, 49);
            cmbCategory.StartIndex = 0;
            cmbCategory.TabIndex = 58;
            // 
            // cmbExpensesType
            // 
            cmbExpensesType.AutoResize = false;
            cmbExpensesType.BackColor = Color.FromArgb(255, 255, 255);
            cmbExpensesType.Depth = 0;
            cmbExpensesType.DrawMode = DrawMode.OwnerDrawVariable;
            cmbExpensesType.DropDownHeight = 174;
            cmbExpensesType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbExpensesType.DropDownWidth = 121;
            cmbExpensesType.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cmbExpensesType.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cmbExpensesType.FormattingEnabled = true;
            cmbExpensesType.IntegralHeight = false;
            cmbExpensesType.ItemHeight = 43;
            cmbExpensesType.Location = new Point(187, 64);
            cmbExpensesType.MaxDropDownItems = 4;
            cmbExpensesType.MouseState = MaterialSkin.MouseState.OUT;
            cmbExpensesType.Name = "cmbExpensesType";
            cmbExpensesType.Size = new Size(200, 49);
            cmbExpensesType.StartIndex = 0;
            cmbExpensesType.TabIndex = 55;
            // 
            // btnVTDelete
            // 
            btnVTDelete.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnVTDelete.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnVTDelete.Depth = 0;
            btnVTDelete.HighEmphasis = true;
            btnVTDelete.Icon = null;
            btnVTDelete.Location = new Point(370, 175);
            btnVTDelete.Margin = new Padding(4, 6, 4, 6);
            btnVTDelete.MouseState = MaterialSkin.MouseState.HOVER;
            btnVTDelete.Name = "btnVTDelete";
            btnVTDelete.NoAccentTextColor = Color.Empty;
            btnVTDelete.Size = new Size(73, 36);
            btnVTDelete.TabIndex = 54;
            btnVTDelete.Text = "Delete";
            btnVTDelete.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnVTDelete.UseAccentColor = false;
            btnVTDelete.UseVisualStyleBackColor = true;
            btnVTDelete.Click += btnVTDelete_Click;
            // 
            // btnVTClear
            // 
            btnVTClear.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnVTClear.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnVTClear.Depth = 0;
            btnVTClear.HighEmphasis = true;
            btnVTClear.Icon = null;
            btnVTClear.Location = new Point(462, 175);
            btnVTClear.Margin = new Padding(4, 6, 4, 6);
            btnVTClear.MouseState = MaterialSkin.MouseState.HOVER;
            btnVTClear.Name = "btnVTClear";
            btnVTClear.NoAccentTextColor = Color.Empty;
            btnVTClear.Size = new Size(66, 36);
            btnVTClear.TabIndex = 53;
            btnVTClear.Text = "Clear";
            btnVTClear.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnVTClear.UseAccentColor = false;
            btnVTClear.UseVisualStyleBackColor = true;
            btnVTClear.Click += btnVTClear_Click;
            // 
            // btnVTSearch
            // 
            btnVTSearch.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnVTSearch.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnVTSearch.Depth = 0;
            btnVTSearch.HighEmphasis = true;
            btnVTSearch.Icon = null;
            btnVTSearch.Location = new Point(273, 175);
            btnVTSearch.Margin = new Padding(4, 6, 4, 6);
            btnVTSearch.MouseState = MaterialSkin.MouseState.HOVER;
            btnVTSearch.Name = "btnVTSearch";
            btnVTSearch.NoAccentTextColor = Color.Empty;
            btnVTSearch.Size = new Size(78, 36);
            btnVTSearch.TabIndex = 52;
            btnVTSearch.Text = "Search";
            btnVTSearch.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnVTSearch.UseAccentColor = false;
            btnVTSearch.UseVisualStyleBackColor = true;
            btnVTSearch.Click += btnVTSearch_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(778, 131);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 50;
            label3.Text = "Bank";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(778, 80);
            label4.Name = "label4";
            label4.Size = new Size(30, 15);
            label4.TabIndex = 48;
            label4.Text = "User";
            // 
            // txtComment
            // 
            txtComment.Location = new Point(552, 129);
            txtComment.Name = "txtComment";
            txtComment.Size = new Size(200, 23);
            txtComment.TabIndex = 47;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(453, 129);
            label5.Name = "label5";
            label5.Size = new Size(61, 15);
            label5.TabIndex = 46;
            label5.Text = "Comment";
            // 
            // txtVTAmount
            // 
            txtVTAmount.Location = new Point(187, 129);
            txtVTAmount.Name = "txtVTAmount";
            txtVTAmount.Size = new Size(200, 23);
            txtVTAmount.TabIndex = 45;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(90, 137);
            label6.Name = "label6";
            label6.Size = new Size(51, 15);
            label6.TabIndex = 44;
            label6.Text = "Amount";
            // 
            // lblCategoryMain
            // 
            lblCategoryMain.AutoSize = true;
            lblCategoryMain.Location = new Point(88, 84);
            lblCategoryMain.Name = "lblCategoryMain";
            lblCategoryMain.Size = new Size(55, 15);
            lblCategoryMain.TabIndex = 42;
            lblCategoryMain.Text = "Category";
            // 
            // lblSubCategory
            // 
            lblSubCategory.AutoSize = true;
            lblSubCategory.Location = new Point(453, 81);
            lblSubCategory.Name = "lblSubCategory";
            lblSubCategory.Size = new Size(75, 15);
            lblSubCategory.TabIndex = 40;
            lblSubCategory.Text = "SubCategory";
            // 
            // dateEnd
            // 
            dateEnd.Location = new Point(552, 18);
            dateEnd.Name = "dateEnd";
            dateEnd.Size = new Size(200, 23);
            dateEnd.TabIndex = 39;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(450, 24);
            label7.Name = "label7";
            label7.Size = new Size(19, 15);
            label7.TabIndex = 38;
            label7.Text = "To";
            // 
            // dateStart
            // 
            dateStart.Location = new Point(187, 24);
            dateStart.Name = "dateStart";
            dateStart.Size = new Size(200, 23);
            dateStart.TabIndex = 37;
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Location = new Point(90, 30);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(35, 15);
            lblDate.TabIndex = 36;
            lblDate.Text = "From";
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
            tabAddIncome.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvIncome).EndInit();
            tabAddTransactions.ResumeLayout(false);
            tabAddTransactions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvExpenses).EndInit();
            tabViewTransactions.ResumeLayout(false);
            tabViewTransactions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvFilter).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl materialTab;
        private TabPage tabAddIncome;
        private TabPage tabAddTransactions;
        private ImageList menubarImages;
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
        private MaterialSkin.Controls.MaterialComboBox cmbATBank;
        private MaterialSkin.Controls.MaterialComboBox cmbATnames;
        private DateTimePicker datePickerAT;
        private Label label1;
        private Label label2;
        private Label lblBDate;
        private DataGridView dgvExpenses;
        private DataGridViewTextBoxColumn Day;
        private DataGridViewComboBoxColumn Category;
        private DataGridViewTextBoxColumn Amount;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private MaterialSkin.Controls.MaterialButton btnATClear;
        private MaterialSkin.Controls.MaterialButton btnATUpload;
        private MaterialSkin.Controls.MaterialButton btnATSave;
        private Label lblATError;
        private ComboBox txtVTBank;
        private Label label3;
        private ComboBox cmbUsers;
        private Label label4;
        private TextBox txtComment;
        private Label label5;
        private TextBox txtVTAmount;
        private Label label6;
        private Label lblCategoryMain;
        private Label lblSubCategory;
        private DateTimePicker dateEnd;
        private Label label7;
        private DateTimePicker dateStart;
        private Label lblDate;
        private MaterialSkin.Controls.MaterialButton btnVTDelete;
        private MaterialSkin.Controls.MaterialButton btnVTClear;
        private MaterialSkin.Controls.MaterialButton btnVTSearch;
        private MaterialSkin.Controls.MaterialComboBox cmbExpensesType;
        private MaterialSkin.Controls.MaterialComboBox cmbCategory;
        private MaterialSkin.Controls.MaterialComboBox cmbVTUser;
        private MaterialSkin.Controls.MaterialComboBox cmbVTBanks;
        private Label lblVTError;
        private DataGridView dgvFilter;
        private DataGridViewTextBoxColumn User;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn Balance;
    }
}