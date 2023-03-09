namespace WallBudget
{
    partial class mainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.dgvIncome = new System.Windows.Forms.DataGridView();
            this.dgvUtilities = new System.Windows.Forms.DataGridView();
            this.dgvBills = new System.Windows.Forms.DataGridView();
            this.dgvExpenses = new System.Windows.Forms.DataGridView();
            this.lblTotalIn = new System.Windows.Forms.Label();
            this.lblTotalOut = new System.Windows.Forms.Label();
            this.lblLeftover = new System.Windows.Forms.Label();
            this.lblInValue = new System.Windows.Forms.Label();
            this.lblOutValue = new System.Windows.Forms.Label();
            this.lblLeftValue = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newMonthToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuThemes = new System.Windows.Forms.ToolStripMenuItem();
            this.darkModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lightModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grayModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFixDates = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFixTransID = new System.Windows.Forms.ToolStripMenuItem();
            this.devToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportAllDBsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableCreatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmdAddExpense = new System.Windows.Forms.Button();
            this.cmdDeleteExpense = new System.Windows.Forms.Button();
            this.cmdRefresh = new System.Windows.Forms.Button();
            this.cmdAddIncome = new System.Windows.Forms.Button();
            this.cmdDeleteIncome = new System.Windows.Forms.Button();
            this.cmdDeleteBill = new System.Windows.Forms.Button();
            this.cmdAddBill = new System.Windows.Forms.Button();
            this.cmbMonth = new System.Windows.Forms.ComboBox();
            this.cmdEditExpense = new System.Windows.Forms.Button();
            this.cmbEditBill = new System.Windows.Forms.Button();
            this.cmbYear = new System.Windows.Forms.ComboBox();
            this.panelCats = new System.Windows.Forms.Panel();
            this.lblCat10Val = new System.Windows.Forms.Label();
            this.lblCat10 = new System.Windows.Forms.Label();
            this.lblCat9Val = new System.Windows.Forms.Label();
            this.lblCat9 = new System.Windows.Forms.Label();
            this.lblCat8Val = new System.Windows.Forms.Label();
            this.lblCat8 = new System.Windows.Forms.Label();
            this.lblCat7Val = new System.Windows.Forms.Label();
            this.lblCat7 = new System.Windows.Forms.Label();
            this.lblCat6Val = new System.Windows.Forms.Label();
            this.lblCat6 = new System.Windows.Forms.Label();
            this.lblCat5Val = new System.Windows.Forms.Label();
            this.lblCat5 = new System.Windows.Forms.Label();
            this.lblCat4Val = new System.Windows.Forms.Label();
            this.lblCat4 = new System.Windows.Forms.Label();
            this.lblCat3Val = new System.Windows.Forms.Label();
            this.lblCat3 = new System.Windows.Forms.Label();
            this.lblCat2Val = new System.Windows.Forms.Label();
            this.lblCat2 = new System.Windows.Forms.Label();
            this.lblCat1Val = new System.Windows.Forms.Label();
            this.lblTopTen = new System.Windows.Forms.Label();
            this.lblCat1 = new System.Windows.Forms.Label();
            this.lblBills = new System.Windows.Forms.Label();
            this.lblIncome = new System.Windows.Forms.Label();
            this.lblUtilities = new System.Windows.Forms.Label();
            this.lblExpenses = new System.Windows.Forms.Label();
            this.cmdEditIncome = new System.Windows.Forms.Button();
            this.cmdAddUtility = new System.Windows.Forms.Button();
            this.cmdDeleteUtility = new System.Windows.Forms.Button();
            this.cmdEditUtility = new System.Windows.Forms.Button();
            this.lblTotalTithe = new System.Windows.Forms.Label();
            this.lblTotalTitheVal = new System.Windows.Forms.Label();
            this.lblTotalUtilVal = new System.Windows.Forms.Label();
            this.lblTotalUtil = new System.Windows.Forms.Label();
            this.lblTotalBillsVal = new System.Windows.Forms.Label();
            this.lblTotalBills = new System.Windows.Forms.Label();
            this.lblTotalExpensesVal = new System.Windows.Forms.Label();
            this.lblTotalExpenses = new System.Windows.Forms.Label();
            this.lblTithePercent = new System.Windows.Forms.Label();
            this.txtTithePercent = new System.Windows.Forms.TextBox();
            this.cmbSetTithe = new System.Windows.Forms.Button();
            this.devToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIncome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUtilities)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBills)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExpenses)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.panelCats.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvIncome
            // 
            this.dgvIncome.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvIncome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvIncome.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIncome.GridColor = System.Drawing.Color.Black;
            this.dgvIncome.Location = new System.Drawing.Point(643, 139);
            this.dgvIncome.Name = "dgvIncome";
            this.dgvIncome.RowTemplate.Height = 25;
            this.dgvIncome.Size = new System.Drawing.Size(551, 195);
            this.dgvIncome.TabIndex = 2;
            // 
            // dgvUtilities
            // 
            this.dgvUtilities.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvUtilities.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvUtilities.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUtilities.GridColor = System.Drawing.Color.Black;
            this.dgvUtilities.Location = new System.Drawing.Point(51, 559);
            this.dgvUtilities.Name = "dgvUtilities";
            this.dgvUtilities.RowTemplate.Height = 25;
            this.dgvUtilities.Size = new System.Drawing.Size(573, 249);
            this.dgvUtilities.TabIndex = 4;
            // 
            // dgvBills
            // 
            this.dgvBills.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvBills.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvBills.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBills.GridColor = System.Drawing.Color.Black;
            this.dgvBills.Location = new System.Drawing.Point(643, 502);
            this.dgvBills.Name = "dgvBills";
            this.dgvBills.RowTemplate.Height = 25;
            this.dgvBills.Size = new System.Drawing.Size(551, 306);
            this.dgvBills.TabIndex = 10;
            // 
            // dgvExpenses
            // 
            this.dgvExpenses.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvExpenses.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvExpenses.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvExpenses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExpenses.GridColor = System.Drawing.Color.Black;
            this.dgvExpenses.Location = new System.Drawing.Point(1223, 139);
            this.dgvExpenses.Name = "dgvExpenses";
            this.dgvExpenses.RowTemplate.Height = 25;
            this.dgvExpenses.Size = new System.Drawing.Size(577, 669);
            this.dgvExpenses.TabIndex = 11;
            // 
            // lblTotalIn
            // 
            this.lblTotalIn.AutoSize = true;
            this.lblTotalIn.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalIn.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTotalIn.ForeColor = System.Drawing.Color.Black;
            this.lblTotalIn.Location = new System.Drawing.Point(29, 85);
            this.lblTotalIn.Name = "lblTotalIn";
            this.lblTotalIn.Size = new System.Drawing.Size(84, 26);
            this.lblTotalIn.TabIndex = 16;
            this.lblTotalIn.Text = "Total In: ";
            // 
            // lblTotalOut
            // 
            this.lblTotalOut.AutoSize = true;
            this.lblTotalOut.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalOut.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTotalOut.ForeColor = System.Drawing.Color.Black;
            this.lblTotalOut.Location = new System.Drawing.Point(255, 85);
            this.lblTotalOut.Name = "lblTotalOut";
            this.lblTotalOut.Size = new System.Drawing.Size(95, 26);
            this.lblTotalOut.TabIndex = 17;
            this.lblTotalOut.Text = "Total Out: ";
            // 
            // lblLeftover
            // 
            this.lblLeftover.AutoSize = true;
            this.lblLeftover.BackColor = System.Drawing.Color.Transparent;
            this.lblLeftover.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLeftover.ForeColor = System.Drawing.Color.Black;
            this.lblLeftover.Location = new System.Drawing.Point(465, 85);
            this.lblLeftover.Name = "lblLeftover";
            this.lblLeftover.Size = new System.Drawing.Size(90, 26);
            this.lblLeftover.TabIndex = 18;
            this.lblLeftover.Text = "Leftover: ";
            // 
            // lblInValue
            // 
            this.lblInValue.AutoSize = true;
            this.lblInValue.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblInValue.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.lblInValue.Location = new System.Drawing.Point(130, 85);
            this.lblInValue.Name = "lblInValue";
            this.lblInValue.Size = new System.Drawing.Size(73, 26);
            this.lblInValue.TabIndex = 19;
            this.lblInValue.Text = "#Value";
            this.lblInValue.Click += new System.EventHandler(this.lblInValue_Click);
            // 
            // lblOutValue
            // 
            this.lblOutValue.AutoSize = true;
            this.lblOutValue.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblOutValue.ForeColor = System.Drawing.Color.Crimson;
            this.lblOutValue.Location = new System.Drawing.Point(356, 85);
            this.lblOutValue.Name = "lblOutValue";
            this.lblOutValue.Size = new System.Drawing.Size(73, 26);
            this.lblOutValue.TabIndex = 20;
            this.lblOutValue.Text = "#Value";
            // 
            // lblLeftValue
            // 
            this.lblLeftValue.AutoSize = true;
            this.lblLeftValue.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLeftValue.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.lblLeftValue.Location = new System.Drawing.Point(566, 85);
            this.lblLeftValue.Name = "lblLeftValue";
            this.lblLeftValue.Size = new System.Drawing.Size(73, 26);
            this.lblLeftValue.TabIndex = 21;
            this.lblLeftValue.Text = "#Value";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.devToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1812, 24);
            this.menuStrip1.TabIndex = 22;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newMonthToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newMonthToolStripMenuItem
            // 
            this.newMonthToolStripMenuItem.Name = "newMonthToolStripMenuItem";
            this.newMonthToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.newMonthToolStripMenuItem.Text = "New Month -->";
            this.newMonthToolStripMenuItem.Click += new System.EventHandler(this.newMonthToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuThemes,
            this.mnuFixDates,
            this.mnuFixTransID});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // mnuThemes
            // 
            this.mnuThemes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.darkModeToolStripMenuItem,
            this.lightModeToolStripMenuItem,
            this.grayModeToolStripMenuItem});
            this.mnuThemes.Name = "mnuThemes";
            this.mnuThemes.Size = new System.Drawing.Size(166, 22);
            this.mnuThemes.Text = "Theme";
            // 
            // darkModeToolStripMenuItem
            // 
            this.darkModeToolStripMenuItem.Name = "darkModeToolStripMenuItem";
            this.darkModeToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.darkModeToolStripMenuItem.Text = "Dark Mode";
            this.darkModeToolStripMenuItem.Click += new System.EventHandler(this.darkModeToolStripMenuItem_Click);
            // 
            // lightModeToolStripMenuItem
            // 
            this.lightModeToolStripMenuItem.Name = "lightModeToolStripMenuItem";
            this.lightModeToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.lightModeToolStripMenuItem.Text = "Light Mode";
            this.lightModeToolStripMenuItem.Click += new System.EventHandler(this.lightModeToolStripMenuItem_Click);
            // 
            // grayModeToolStripMenuItem
            // 
            this.grayModeToolStripMenuItem.Name = "grayModeToolStripMenuItem";
            this.grayModeToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.grayModeToolStripMenuItem.Text = "Gray Mode";
            this.grayModeToolStripMenuItem.Click += new System.EventHandler(this.grayModeToolStripMenuItem_Click);
            // 
            // mnuFixDates
            // 
            this.mnuFixDates.Name = "mnuFixDates";
            this.mnuFixDates.Size = new System.Drawing.Size(166, 22);
            this.mnuFixDates.Text = "Fix Dates";
            this.mnuFixDates.Click += new System.EventHandler(this.fixDatesToolStripMenuItem_Click);
            // 
            // mnuFixTransID
            // 
            this.mnuFixTransID.CheckOnClick = true;
            this.mnuFixTransID.Name = "mnuFixTransID";
            this.mnuFixTransID.Size = new System.Drawing.Size(166, 22);
            this.mnuFixTransID.Text = "Fix Transaction ID";
            this.mnuFixTransID.Click += new System.EventHandler(this.fixTransactinIDToolStripMenuItem_Click);
            // 
            // devToolStripMenuItem
            // 
            this.devToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportAllDBsToolStripMenuItem,
            this.tableCreatorToolStripMenuItem,
            this.devToolStripMenuItem1});
            this.devToolStripMenuItem.Name = "devToolStripMenuItem";
            this.devToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.devToolStripMenuItem.Text = "Dev";
            // 
            // exportAllDBsToolStripMenuItem
            // 
            this.exportAllDBsToolStripMenuItem.Name = "exportAllDBsToolStripMenuItem";
            this.exportAllDBsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exportAllDBsToolStripMenuItem.Text = "Export All DBs";
            this.exportAllDBsToolStripMenuItem.Click += new System.EventHandler(this.exportAllDBsToolStripMenuItem_Click);
            // 
            // tableCreatorToolStripMenuItem
            // 
            this.tableCreatorToolStripMenuItem.Name = "tableCreatorToolStripMenuItem";
            this.tableCreatorToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.tableCreatorToolStripMenuItem.Text = "Table Creator";
            this.tableCreatorToolStripMenuItem.Click += new System.EventHandler(this.tableCreatorToolStripMenuItem_Click);
            // 
            // cmdAddExpense
            // 
            this.cmdAddExpense.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cmdAddExpense.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cmdAddExpense.BackgroundImage")));
            this.cmdAddExpense.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdAddExpense.Image = ((System.Drawing.Image)(resources.GetObject("cmdAddExpense.Image")));
            this.cmdAddExpense.Location = new System.Drawing.Point(1223, 74);
            this.cmdAddExpense.Name = "cmdAddExpense";
            this.cmdAddExpense.Size = new System.Drawing.Size(39, 35);
            this.cmdAddExpense.TabIndex = 24;
            this.cmdAddExpense.UseVisualStyleBackColor = false;
            this.cmdAddExpense.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // cmdDeleteExpense
            // 
            this.cmdDeleteExpense.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cmdDeleteExpense.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cmdDeleteExpense.BackgroundImage")));
            this.cmdDeleteExpense.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdDeleteExpense.Location = new System.Drawing.Point(1261, 74);
            this.cmdDeleteExpense.Name = "cmdDeleteExpense";
            this.cmdDeleteExpense.Size = new System.Drawing.Size(39, 35);
            this.cmdDeleteExpense.TabIndex = 25;
            this.cmdDeleteExpense.UseVisualStyleBackColor = false;
            this.cmdDeleteExpense.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // cmdRefresh
            // 
            this.cmdRefresh.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cmdRefresh.BackgroundImage")));
            this.cmdRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.cmdRefresh.Location = new System.Drawing.Point(255, 27);
            this.cmdRefresh.Name = "cmdRefresh";
            this.cmdRefresh.Size = new System.Drawing.Size(128, 55);
            this.cmdRefresh.TabIndex = 26;
            this.cmdRefresh.UseVisualStyleBackColor = true;
            this.cmdRefresh.Click += new System.EventHandler(this.cmdRefresh_Click);
            // 
            // cmdAddIncome
            // 
            this.cmdAddIncome.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cmdAddIncome.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cmdAddIncome.BackgroundImage")));
            this.cmdAddIncome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdAddIncome.Image = ((System.Drawing.Image)(resources.GetObject("cmdAddIncome.Image")));
            this.cmdAddIncome.Location = new System.Drawing.Point(643, 74);
            this.cmdAddIncome.Name = "cmdAddIncome";
            this.cmdAddIncome.Size = new System.Drawing.Size(41, 35);
            this.cmdAddIncome.TabIndex = 27;
            this.cmdAddIncome.UseVisualStyleBackColor = false;
            this.cmdAddIncome.Click += new System.EventHandler(this.cmdAddIncome_Click);
            // 
            // cmdDeleteIncome
            // 
            this.cmdDeleteIncome.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cmdDeleteIncome.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cmdDeleteIncome.BackgroundImage")));
            this.cmdDeleteIncome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdDeleteIncome.Location = new System.Drawing.Point(684, 74);
            this.cmdDeleteIncome.Name = "cmdDeleteIncome";
            this.cmdDeleteIncome.Size = new System.Drawing.Size(39, 35);
            this.cmdDeleteIncome.TabIndex = 28;
            this.cmdDeleteIncome.UseVisualStyleBackColor = false;
            this.cmdDeleteIncome.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // cmdDeleteBill
            // 
            this.cmdDeleteBill.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cmdDeleteBill.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cmdDeleteBill.BackgroundImage")));
            this.cmdDeleteBill.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdDeleteBill.Location = new System.Drawing.Point(684, 435);
            this.cmdDeleteBill.Name = "cmdDeleteBill";
            this.cmdDeleteBill.Size = new System.Drawing.Size(39, 35);
            this.cmdDeleteBill.TabIndex = 30;
            this.cmdDeleteBill.UseVisualStyleBackColor = false;
            this.cmdDeleteBill.Click += new System.EventHandler(this.cmdDeleteBill_Click);
            // 
            // cmdAddBill
            // 
            this.cmdAddBill.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cmdAddBill.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cmdAddBill.BackgroundImage")));
            this.cmdAddBill.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdAddBill.Image = ((System.Drawing.Image)(resources.GetObject("cmdAddBill.Image")));
            this.cmdAddBill.Location = new System.Drawing.Point(643, 435);
            this.cmdAddBill.Name = "cmdAddBill";
            this.cmdAddBill.Size = new System.Drawing.Size(41, 35);
            this.cmdAddBill.TabIndex = 29;
            this.cmdAddBill.UseVisualStyleBackColor = false;
            this.cmdAddBill.Click += new System.EventHandler(this.cmdAddBill_Click);
            // 
            // cmbMonth
            // 
            this.cmbMonth.FormattingEnabled = true;
            this.cmbMonth.Location = new System.Drawing.Point(145, 56);
            this.cmbMonth.Name = "cmbMonth";
            this.cmbMonth.Size = new System.Drawing.Size(104, 23);
            this.cmbMonth.TabIndex = 33;
            this.cmbMonth.Text = "Month";
            this.cmbMonth.SelectedIndexChanged += new System.EventHandler(this.cmbMonth_SelectedIndexChanged);
            // 
            // cmdEditExpense
            // 
            this.cmdEditExpense.Location = new System.Drawing.Point(1223, 110);
            this.cmdEditExpense.Name = "cmdEditExpense";
            this.cmdEditExpense.Size = new System.Drawing.Size(77, 23);
            this.cmdEditExpense.TabIndex = 34;
            this.cmdEditExpense.Text = "Edit";
            this.cmdEditExpense.UseVisualStyleBackColor = true;
            this.cmdEditExpense.Click += new System.EventHandler(this.cmbEditExpense_Click);
            // 
            // cmbEditBill
            // 
            this.cmbEditBill.Location = new System.Drawing.Point(643, 473);
            this.cmbEditBill.Name = "cmbEditBill";
            this.cmbEditBill.Size = new System.Drawing.Size(80, 23);
            this.cmbEditBill.TabIndex = 35;
            this.cmbEditBill.Text = "Edit";
            this.cmbEditBill.UseVisualStyleBackColor = true;
            this.cmbEditBill.Click += new System.EventHandler(this.cmbEditBill_Click);
            // 
            // cmbYear
            // 
            this.cmbYear.FormattingEnabled = true;
            this.cmbYear.Location = new System.Drawing.Point(169, 27);
            this.cmbYear.Name = "cmbYear";
            this.cmbYear.Size = new System.Drawing.Size(80, 23);
            this.cmbYear.TabIndex = 36;
            this.cmbYear.Text = "Year";
            this.cmbYear.SelectedIndexChanged += new System.EventHandler(this.cmbYear_SelectedIndexChanged_1);
            // 
            // panelCats
            // 
            this.panelCats.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCats.Controls.Add(this.lblCat10Val);
            this.panelCats.Controls.Add(this.lblCat10);
            this.panelCats.Controls.Add(this.lblCat9Val);
            this.panelCats.Controls.Add(this.lblCat9);
            this.panelCats.Controls.Add(this.lblCat8Val);
            this.panelCats.Controls.Add(this.lblCat8);
            this.panelCats.Controls.Add(this.lblCat7Val);
            this.panelCats.Controls.Add(this.lblCat7);
            this.panelCats.Controls.Add(this.lblCat6Val);
            this.panelCats.Controls.Add(this.lblCat6);
            this.panelCats.Controls.Add(this.lblCat5Val);
            this.panelCats.Controls.Add(this.lblCat5);
            this.panelCats.Controls.Add(this.lblCat4Val);
            this.panelCats.Controls.Add(this.lblCat4);
            this.panelCats.Controls.Add(this.lblCat3Val);
            this.panelCats.Controls.Add(this.lblCat3);
            this.panelCats.Controls.Add(this.lblCat2Val);
            this.panelCats.Controls.Add(this.lblCat2);
            this.panelCats.Controls.Add(this.lblCat1Val);
            this.panelCats.Controls.Add(this.lblTopTen);
            this.panelCats.Controls.Add(this.lblCat1);
            this.panelCats.Location = new System.Drawing.Point(29, 154);
            this.panelCats.Name = "panelCats";
            this.panelCats.Size = new System.Drawing.Size(582, 332);
            this.panelCats.TabIndex = 37;
            // 
            // lblCat10Val
            // 
            this.lblCat10Val.AutoSize = true;
            this.lblCat10Val.Font = new System.Drawing.Font("Magneto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCat10Val.ForeColor = System.Drawing.Color.Red;
            this.lblCat10Val.Location = new System.Drawing.Point(490, 244);
            this.lblCat10Val.Name = "lblCat10Val";
            this.lblCat10Val.Size = new System.Drawing.Size(52, 25);
            this.lblCat10Val.TabIndex = 69;
            this.lblCat10Val.Text = "$0 ";
            // 
            // lblCat10
            // 
            this.lblCat10.AutoSize = true;
            this.lblCat10.Font = new System.Drawing.Font("Magneto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCat10.Location = new System.Drawing.Point(290, 244);
            this.lblCat10.Name = "lblCat10";
            this.lblCat10.Size = new System.Drawing.Size(154, 25);
            this.lblCat10.TabIndex = 68;
            this.lblCat10.Text = "10. Category";
            // 
            // lblCat9Val
            // 
            this.lblCat9Val.AutoSize = true;
            this.lblCat9Val.Font = new System.Drawing.Font("Magneto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCat9Val.ForeColor = System.Drawing.Color.Red;
            this.lblCat9Val.Location = new System.Drawing.Point(490, 200);
            this.lblCat9Val.Name = "lblCat9Val";
            this.lblCat9Val.Size = new System.Drawing.Size(52, 25);
            this.lblCat9Val.TabIndex = 67;
            this.lblCat9Val.Text = "$0 ";
            // 
            // lblCat9
            // 
            this.lblCat9.AutoSize = true;
            this.lblCat9.Font = new System.Drawing.Font("Magneto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCat9.Location = new System.Drawing.Point(302, 200);
            this.lblCat9.Name = "lblCat9";
            this.lblCat9.Size = new System.Drawing.Size(142, 25);
            this.lblCat9.TabIndex = 66;
            this.lblCat9.Text = "9. Category";
            // 
            // lblCat8Val
            // 
            this.lblCat8Val.AutoSize = true;
            this.lblCat8Val.Font = new System.Drawing.Font("Magneto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCat8Val.ForeColor = System.Drawing.Color.Red;
            this.lblCat8Val.Location = new System.Drawing.Point(490, 154);
            this.lblCat8Val.Name = "lblCat8Val";
            this.lblCat8Val.Size = new System.Drawing.Size(52, 25);
            this.lblCat8Val.TabIndex = 65;
            this.lblCat8Val.Text = "$0 ";
            // 
            // lblCat8
            // 
            this.lblCat8.AutoSize = true;
            this.lblCat8.Font = new System.Drawing.Font("Magneto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCat8.Location = new System.Drawing.Point(301, 154);
            this.lblCat8.Name = "lblCat8";
            this.lblCat8.Size = new System.Drawing.Size(143, 25);
            this.lblCat8.TabIndex = 64;
            this.lblCat8.Text = "8. Category";
            // 
            // lblCat7Val
            // 
            this.lblCat7Val.AutoSize = true;
            this.lblCat7Val.Font = new System.Drawing.Font("Magneto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCat7Val.ForeColor = System.Drawing.Color.Red;
            this.lblCat7Val.Location = new System.Drawing.Point(490, 110);
            this.lblCat7Val.Name = "lblCat7Val";
            this.lblCat7Val.Size = new System.Drawing.Size(52, 25);
            this.lblCat7Val.TabIndex = 63;
            this.lblCat7Val.Text = "$0 ";
            // 
            // lblCat7
            // 
            this.lblCat7.AutoSize = true;
            this.lblCat7.Font = new System.Drawing.Font("Magneto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCat7.Location = new System.Drawing.Point(301, 110);
            this.lblCat7.Name = "lblCat7";
            this.lblCat7.Size = new System.Drawing.Size(141, 25);
            this.lblCat7.TabIndex = 62;
            this.lblCat7.Text = "7. Category";
            // 
            // lblCat6Val
            // 
            this.lblCat6Val.AutoSize = true;
            this.lblCat6Val.Font = new System.Drawing.Font("Magneto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCat6Val.ForeColor = System.Drawing.Color.Red;
            this.lblCat6Val.Location = new System.Drawing.Point(490, 66);
            this.lblCat6Val.Name = "lblCat6Val";
            this.lblCat6Val.Size = new System.Drawing.Size(52, 25);
            this.lblCat6Val.TabIndex = 61;
            this.lblCat6Val.Text = "$0 ";
            // 
            // lblCat6
            // 
            this.lblCat6.AutoSize = true;
            this.lblCat6.Font = new System.Drawing.Font("Magneto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCat6.Location = new System.Drawing.Point(302, 66);
            this.lblCat6.Name = "lblCat6";
            this.lblCat6.Size = new System.Drawing.Size(143, 25);
            this.lblCat6.TabIndex = 60;
            this.lblCat6.Text = "6. Category";
            // 
            // lblCat5Val
            // 
            this.lblCat5Val.AutoSize = true;
            this.lblCat5Val.Font = new System.Drawing.Font("Magneto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCat5Val.ForeColor = System.Drawing.Color.Red;
            this.lblCat5Val.Location = new System.Drawing.Point(212, 244);
            this.lblCat5Val.Name = "lblCat5Val";
            this.lblCat5Val.Size = new System.Drawing.Size(52, 25);
            this.lblCat5Val.TabIndex = 59;
            this.lblCat5Val.Text = "$0 ";
            // 
            // lblCat5
            // 
            this.lblCat5.AutoSize = true;
            this.lblCat5.Font = new System.Drawing.Font("Magneto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCat5.Location = new System.Drawing.Point(38, 244);
            this.lblCat5.Name = "lblCat5";
            this.lblCat5.Size = new System.Drawing.Size(142, 25);
            this.lblCat5.TabIndex = 58;
            this.lblCat5.Text = "5. Category";
            this.lblCat5.Click += new System.EventHandler(this.lblCat5_Click);
            // 
            // lblCat4Val
            // 
            this.lblCat4Val.AutoSize = true;
            this.lblCat4Val.Font = new System.Drawing.Font("Magneto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCat4Val.ForeColor = System.Drawing.Color.Red;
            this.lblCat4Val.Location = new System.Drawing.Point(212, 200);
            this.lblCat4Val.Name = "lblCat4Val";
            this.lblCat4Val.Size = new System.Drawing.Size(52, 25);
            this.lblCat4Val.TabIndex = 57;
            this.lblCat4Val.Text = "$0 ";
            // 
            // lblCat4
            // 
            this.lblCat4.AutoSize = true;
            this.lblCat4.Font = new System.Drawing.Font("Magneto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCat4.Location = new System.Drawing.Point(36, 200);
            this.lblCat4.Name = "lblCat4";
            this.lblCat4.Size = new System.Drawing.Size(144, 25);
            this.lblCat4.TabIndex = 56;
            this.lblCat4.Text = "4. Category";
            // 
            // lblCat3Val
            // 
            this.lblCat3Val.AutoSize = true;
            this.lblCat3Val.Font = new System.Drawing.Font("Magneto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCat3Val.ForeColor = System.Drawing.Color.Red;
            this.lblCat3Val.Location = new System.Drawing.Point(212, 154);
            this.lblCat3Val.Name = "lblCat3Val";
            this.lblCat3Val.Size = new System.Drawing.Size(52, 25);
            this.lblCat3Val.TabIndex = 55;
            this.lblCat3Val.Text = "$0 ";
            // 
            // lblCat3
            // 
            this.lblCat3.AutoSize = true;
            this.lblCat3.Font = new System.Drawing.Font("Magneto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCat3.Location = new System.Drawing.Point(36, 154);
            this.lblCat3.Name = "lblCat3";
            this.lblCat3.Size = new System.Drawing.Size(143, 25);
            this.lblCat3.TabIndex = 54;
            this.lblCat3.Text = "3. Category";
            // 
            // lblCat2Val
            // 
            this.lblCat2Val.AutoSize = true;
            this.lblCat2Val.Font = new System.Drawing.Font("Magneto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCat2Val.ForeColor = System.Drawing.Color.Red;
            this.lblCat2Val.Location = new System.Drawing.Point(212, 110);
            this.lblCat2Val.Name = "lblCat2Val";
            this.lblCat2Val.Size = new System.Drawing.Size(52, 25);
            this.lblCat2Val.TabIndex = 53;
            this.lblCat2Val.Text = "$0 ";
            // 
            // lblCat2
            // 
            this.lblCat2.AutoSize = true;
            this.lblCat2.Font = new System.Drawing.Font("Magneto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCat2.Location = new System.Drawing.Point(36, 110);
            this.lblCat2.Name = "lblCat2";
            this.lblCat2.Size = new System.Drawing.Size(143, 25);
            this.lblCat2.TabIndex = 52;
            this.lblCat2.Text = "2. Category";
            // 
            // lblCat1Val
            // 
            this.lblCat1Val.AutoSize = true;
            this.lblCat1Val.Font = new System.Drawing.Font("Magneto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCat1Val.ForeColor = System.Drawing.Color.Red;
            this.lblCat1Val.Location = new System.Drawing.Point(212, 66);
            this.lblCat1Val.Name = "lblCat1Val";
            this.lblCat1Val.Size = new System.Drawing.Size(52, 25);
            this.lblCat1Val.TabIndex = 51;
            this.lblCat1Val.Text = "$0 ";
            // 
            // lblTopTen
            // 
            this.lblTopTen.AutoSize = true;
            this.lblTopTen.Font = new System.Drawing.Font("Magneto", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTopTen.Location = new System.Drawing.Point(101, 0);
            this.lblTopTen.Name = "lblTopTen";
            this.lblTopTen.Size = new System.Drawing.Size(382, 45);
            this.lblTopTen.TabIndex = 50;
            this.lblTopTen.Text = "Top Ten Expenses";
            // 
            // lblCat1
            // 
            this.lblCat1.AutoSize = true;
            this.lblCat1.Font = new System.Drawing.Font("Magneto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCat1.Location = new System.Drawing.Point(36, 66);
            this.lblCat1.Name = "lblCat1";
            this.lblCat1.Size = new System.Drawing.Size(138, 25);
            this.lblCat1.TabIndex = 50;
            this.lblCat1.Text = "1. Category";
            // 
            // lblBills
            // 
            this.lblBills.AutoSize = true;
            this.lblBills.Font = new System.Drawing.Font("Magneto", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBills.Location = new System.Drawing.Point(856, 449);
            this.lblBills.Name = "lblBills";
            this.lblBills.Size = new System.Drawing.Size(114, 45);
            this.lblBills.TabIndex = 38;
            this.lblBills.Text = "Bills";
            // 
            // lblIncome
            // 
            this.lblIncome.AutoSize = true;
            this.lblIncome.Font = new System.Drawing.Font("Magneto", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblIncome.Location = new System.Drawing.Point(842, 88);
            this.lblIncome.Name = "lblIncome";
            this.lblIncome.Size = new System.Drawing.Size(174, 45);
            this.lblIncome.TabIndex = 39;
            this.lblIncome.Text = "Income";
            // 
            // lblUtilities
            // 
            this.lblUtilities.AutoSize = true;
            this.lblUtilities.Font = new System.Drawing.Font("Magneto", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblUtilities.Location = new System.Drawing.Point(255, 506);
            this.lblUtilities.Name = "lblUtilities";
            this.lblUtilities.Size = new System.Drawing.Size(183, 45);
            this.lblUtilities.TabIndex = 40;
            this.lblUtilities.Text = "Utilities";
            // 
            // lblExpenses
            // 
            this.lblExpenses.AutoSize = true;
            this.lblExpenses.Font = new System.Drawing.Font("Magneto", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblExpenses.Location = new System.Drawing.Point(1420, 88);
            this.lblExpenses.Name = "lblExpenses";
            this.lblExpenses.Size = new System.Drawing.Size(206, 45);
            this.lblExpenses.TabIndex = 41;
            this.lblExpenses.Text = "Expenses";
            // 
            // cmdEditIncome
            // 
            this.cmdEditIncome.Location = new System.Drawing.Point(643, 110);
            this.cmdEditIncome.Name = "cmdEditIncome";
            this.cmdEditIncome.Size = new System.Drawing.Size(80, 23);
            this.cmdEditIncome.TabIndex = 42;
            this.cmdEditIncome.Text = "Edit";
            this.cmdEditIncome.UseVisualStyleBackColor = true;
            this.cmdEditIncome.Click += new System.EventHandler(this.cmdEditIncome_Click);
            // 
            // cmdAddUtility
            // 
            this.cmdAddUtility.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cmdAddUtility.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cmdAddUtility.BackgroundImage")));
            this.cmdAddUtility.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdAddUtility.Image = ((System.Drawing.Image)(resources.GetObject("cmdAddUtility.Image")));
            this.cmdAddUtility.Location = new System.Drawing.Point(51, 492);
            this.cmdAddUtility.Name = "cmdAddUtility";
            this.cmdAddUtility.Size = new System.Drawing.Size(41, 35);
            this.cmdAddUtility.TabIndex = 43;
            this.cmdAddUtility.UseVisualStyleBackColor = false;
            this.cmdAddUtility.Click += new System.EventHandler(this.button1_Click_3);
            // 
            // cmdDeleteUtility
            // 
            this.cmdDeleteUtility.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cmdDeleteUtility.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cmdDeleteUtility.BackgroundImage")));
            this.cmdDeleteUtility.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdDeleteUtility.Location = new System.Drawing.Point(92, 492);
            this.cmdDeleteUtility.Name = "cmdDeleteUtility";
            this.cmdDeleteUtility.Size = new System.Drawing.Size(39, 35);
            this.cmdDeleteUtility.TabIndex = 44;
            this.cmdDeleteUtility.UseVisualStyleBackColor = false;
            this.cmdDeleteUtility.Click += new System.EventHandler(this.cmdDeleteUtility_Click);
            // 
            // cmdEditUtility
            // 
            this.cmdEditUtility.Location = new System.Drawing.Point(51, 530);
            this.cmdEditUtility.Name = "cmdEditUtility";
            this.cmdEditUtility.Size = new System.Drawing.Size(80, 23);
            this.cmdEditUtility.TabIndex = 45;
            this.cmdEditUtility.Text = "Edit";
            this.cmdEditUtility.UseVisualStyleBackColor = true;
            this.cmdEditUtility.Click += new System.EventHandler(this.button1_Click_4);
            // 
            // lblTotalTithe
            // 
            this.lblTotalTithe.AutoSize = true;
            this.lblTotalTithe.Font = new System.Drawing.Font("Magneto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTotalTithe.Location = new System.Drawing.Point(793, 358);
            this.lblTotalTithe.Name = "lblTotalTithe";
            this.lblTotalTithe.Size = new System.Drawing.Size(214, 25);
            this.lblTotalTithe.TabIndex = 47;
            this.lblTotalTithe.Text = "Total Tithe Paid: ";
            // 
            // lblTotalTitheVal
            // 
            this.lblTotalTitheVal.AutoSize = true;
            this.lblTotalTitheVal.Font = new System.Drawing.Font("Magneto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTotalTitheVal.ForeColor = System.Drawing.Color.Red;
            this.lblTotalTitheVal.Location = new System.Drawing.Point(1003, 358);
            this.lblTotalTitheVal.Name = "lblTotalTitheVal";
            this.lblTotalTitheVal.Size = new System.Drawing.Size(52, 25);
            this.lblTotalTitheVal.TabIndex = 49;
            this.lblTotalTitheVal.Text = "$0 ";
            // 
            // lblTotalUtilVal
            // 
            this.lblTotalUtilVal.AutoSize = true;
            this.lblTotalUtilVal.Font = new System.Drawing.Font("Magneto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTotalUtilVal.ForeColor = System.Drawing.Color.Red;
            this.lblTotalUtilVal.Location = new System.Drawing.Point(399, 811);
            this.lblTotalUtilVal.Name = "lblTotalUtilVal";
            this.lblTotalUtilVal.Size = new System.Drawing.Size(52, 25);
            this.lblTotalUtilVal.TabIndex = 51;
            this.lblTotalUtilVal.Text = "$0 ";
            // 
            // lblTotalUtil
            // 
            this.lblTotalUtil.AutoSize = true;
            this.lblTotalUtil.Font = new System.Drawing.Font("Magneto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTotalUtil.Location = new System.Drawing.Point(166, 811);
            this.lblTotalUtil.Name = "lblTotalUtil";
            this.lblTotalUtil.Size = new System.Drawing.Size(238, 25);
            this.lblTotalUtil.TabIndex = 50;
            this.lblTotalUtil.Text = "Total Utilites Paid: ";
            // 
            // lblTotalBillsVal
            // 
            this.lblTotalBillsVal.AutoSize = true;
            this.lblTotalBillsVal.Font = new System.Drawing.Font("Magneto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTotalBillsVal.ForeColor = System.Drawing.Color.Red;
            this.lblTotalBillsVal.Location = new System.Drawing.Point(993, 811);
            this.lblTotalBillsVal.Name = "lblTotalBillsVal";
            this.lblTotalBillsVal.Size = new System.Drawing.Size(52, 25);
            this.lblTotalBillsVal.TabIndex = 53;
            this.lblTotalBillsVal.Text = "$0 ";
            // 
            // lblTotalBills
            // 
            this.lblTotalBills.AutoSize = true;
            this.lblTotalBills.Font = new System.Drawing.Font("Magneto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTotalBills.Location = new System.Drawing.Point(793, 811);
            this.lblTotalBills.Name = "lblTotalBills";
            this.lblTotalBills.Size = new System.Drawing.Size(199, 25);
            this.lblTotalBills.TabIndex = 52;
            this.lblTotalBills.Text = "Total Bills Paid:";
            // 
            // lblTotalExpensesVal
            // 
            this.lblTotalExpensesVal.AutoSize = true;
            this.lblTotalExpensesVal.Font = new System.Drawing.Font("Magneto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTotalExpensesVal.ForeColor = System.Drawing.Color.Red;
            this.lblTotalExpensesVal.Location = new System.Drawing.Point(1601, 811);
            this.lblTotalExpensesVal.Name = "lblTotalExpensesVal";
            this.lblTotalExpensesVal.Size = new System.Drawing.Size(52, 25);
            this.lblTotalExpensesVal.TabIndex = 55;
            this.lblTotalExpensesVal.Text = "$0 ";
            // 
            // lblTotalExpenses
            // 
            this.lblTotalExpenses.AutoSize = true;
            this.lblTotalExpenses.Font = new System.Drawing.Font("Magneto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTotalExpenses.Location = new System.Drawing.Point(1398, 811);
            this.lblTotalExpenses.Name = "lblTotalExpenses";
            this.lblTotalExpenses.Size = new System.Drawing.Size(197, 25);
            this.lblTotalExpenses.TabIndex = 54;
            this.lblTotalExpenses.Text = "Total Expenses: ";
            // 
            // lblTithePercent
            // 
            this.lblTithePercent.AutoSize = true;
            this.lblTithePercent.Font = new System.Drawing.Font("Magneto", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTithePercent.Location = new System.Drawing.Point(832, 334);
            this.lblTithePercent.Name = "lblTithePercent";
            this.lblTithePercent.Size = new System.Drawing.Size(160, 24);
            this.lblTithePercent.TabIndex = 56;
            this.lblTithePercent.Text = "Tithe Percent:";
            // 
            // txtTithePercent
            // 
            this.txtTithePercent.Location = new System.Drawing.Point(993, 337);
            this.txtTithePercent.Name = "txtTithePercent";
            this.txtTithePercent.Size = new System.Drawing.Size(32, 23);
            this.txtTithePercent.TabIndex = 57;
            this.txtTithePercent.Text = "15";
            // 
            // cmbSetTithe
            // 
            this.cmbSetTithe.Location = new System.Drawing.Point(1106, 337);
            this.cmbSetTithe.Name = "cmbSetTithe";
            this.cmbSetTithe.Size = new System.Drawing.Size(88, 23);
            this.cmbSetTithe.TabIndex = 58;
            this.cmbSetTithe.Text = "Update Tithe";
            this.cmbSetTithe.UseVisualStyleBackColor = true;
            this.cmbSetTithe.Click += new System.EventHandler(this.cmbSetTithe_Click);
            // 
            // devToolStripMenuItem1
            // 
            this.devToolStripMenuItem1.Name = "devToolStripMenuItem1";
            this.devToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.devToolStripMenuItem1.Text = "Dev";
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1812, 843);
            this.Controls.Add(this.cmbSetTithe);
            this.Controls.Add(this.txtTithePercent);
            this.Controls.Add(this.lblTithePercent);
            this.Controls.Add(this.lblTotalExpensesVal);
            this.Controls.Add(this.lblTotalExpenses);
            this.Controls.Add(this.lblTotalBillsVal);
            this.Controls.Add(this.lblTotalBills);
            this.Controls.Add(this.lblTotalUtilVal);
            this.Controls.Add(this.lblTotalUtil);
            this.Controls.Add(this.lblTotalTitheVal);
            this.Controls.Add(this.lblTotalTithe);
            this.Controls.Add(this.cmdEditUtility);
            this.Controls.Add(this.cmdDeleteUtility);
            this.Controls.Add(this.cmdAddUtility);
            this.Controls.Add(this.cmdEditIncome);
            this.Controls.Add(this.lblExpenses);
            this.Controls.Add(this.lblUtilities);
            this.Controls.Add(this.lblIncome);
            this.Controls.Add(this.lblBills);
            this.Controls.Add(this.panelCats);
            this.Controls.Add(this.cmbYear);
            this.Controls.Add(this.cmbEditBill);
            this.Controls.Add(this.cmdEditExpense);
            this.Controls.Add(this.cmbMonth);
            this.Controls.Add(this.cmdDeleteBill);
            this.Controls.Add(this.cmdAddBill);
            this.Controls.Add(this.cmdDeleteIncome);
            this.Controls.Add(this.cmdAddIncome);
            this.Controls.Add(this.cmdRefresh);
            this.Controls.Add(this.cmdDeleteExpense);
            this.Controls.Add(this.cmdAddExpense);
            this.Controls.Add(this.lblLeftValue);
            this.Controls.Add(this.lblOutValue);
            this.Controls.Add(this.lblInValue);
            this.Controls.Add(this.lblLeftover);
            this.Controls.Add(this.lblTotalOut);
            this.Controls.Add(this.lblTotalIn);
            this.Controls.Add(this.dgvExpenses);
            this.Controls.Add(this.dgvBills);
            this.Controls.Add(this.dgvUtilities);
            this.Controls.Add(this.dgvIncome);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "mainForm";
            this.Text = "WallingBudget";
            this.Load += new System.EventHandler(this.mainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIncome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUtilities)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBills)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExpenses)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelCats.ResumeLayout(false);
            this.panelCats.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DataGridView dgvIncomeManualTithe;
        private DataGridView dgvCreditCards;
        private DataGridView dgvChassCheckTithe;
        private Label lblTotalIn;
        private Label lblTotalOut;
        private Label lblLeftover;
        private Label lblInValue;
        private Label lblOutValue;
        private Label lblLeftValue;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private Button cmdAddExpense;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem mnuThemes;
        private ToolStripMenuItem darkModeToolStripMenuItem;
        private ToolStripMenuItem lightModeToolStripMenuItem;
        private ToolStripMenuItem grayModeToolStripMenuItem;
        private Button cmdDeleteExpense;
        private ToolStripMenuItem mnuFixDates;
        private Button cmdRefresh;
        private Button cmdAddIncome;
        private Button cmdDeleteIncome;
        private Button cmdDeleteBill;
        private Button cmdAddBill;
        public DataGridView dgvIncome;
        public DataGridView dgvUtilities;
        public DataGridView dgvBills;
        public DataGridView dgvExpenses;
        private ToolStripMenuItem newMonthToolStripMenuItem;
        private ToolStripMenuItem mnuFixTransID;
        private Button cmdEditExpense;
        private Button cmbEditBill;
        private Panel panelCats;
        public ComboBox cmbMonth;
        public ComboBox cmbYear;
        private Label lblBills;
        private Label lblIncome;
        private Label lblUtilities;
        private Label lblExpenses;
        private Button cmdEditIncome;
        private Button cmdAddUtility;
        private Button cmdDeleteUtility;
        private Button cmdEditUtility;
        private Label lblTotalTithe;
        private Label lblTotalTitheVal;
        private Label lblCat10Val;
        private Label lblCat10;
        private Label lblCat9Val;
        private Label lblCat9;
        private Label lblCat8Val;
        private Label lblCat8;
        private Label lblCat7Val;
        private Label lblCat7;
        private Label lblCat6Val;
        private Label lblCat6;
        private Label lblCat5Val;
        private Label lblCat5;
        private Label lblCat4Val;
        private Label lblCat4;
        private Label lblCat3Val;
        private Label lblCat3;
        private Label lblCat2Val;
        private Label lblCat2;
        private Label lblCat1Val;
        private Label lblTopTen;
        private Label lblCat1;
        private Label lblTotalUtilVal;
        private Label lblTotalUtil;
        private Label lblTotalBillsVal;
        private Label lblTotalBills;
        private Label lblTotalExpensesVal;
        private Label lblTotalExpenses;
        private Label lblTithePercent;
        private Button cmbSetTithe;
        private ToolStripMenuItem devToolStripMenuItem;
        private ToolStripMenuItem exportAllDBsToolStripMenuItem;
        public TextBox txtTithePercent;
        private ToolStripMenuItem tableCreatorToolStripMenuItem;
        private ToolStripMenuItem devToolStripMenuItem1;
    }
}