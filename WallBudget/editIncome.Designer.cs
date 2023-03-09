namespace WallBudget
{
    partial class editIncome
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
            this.lblTithe = new System.Windows.Forms.Label();
            this.txtTithe = new System.Windows.Forms.TextBox();
            this.lblGross = new System.Windows.Forms.Label();
            this.txtGross = new System.Windows.Forms.TextBox();
            this.cmdSubmit = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lblNet = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.txtNet = new System.Windows.Forms.TextBox();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblTithe
            // 
            this.lblTithe.AutoSize = true;
            this.lblTithe.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTithe.Location = new System.Drawing.Point(427, 61);
            this.lblTithe.Name = "lblTithe";
            this.lblTithe.Size = new System.Drawing.Size(42, 20);
            this.lblTithe.TabIndex = 36;
            this.lblTithe.Text = "Tithe";
            // 
            // txtTithe
            // 
            this.txtTithe.Location = new System.Drawing.Point(427, 84);
            this.txtTithe.Name = "txtTithe";
            this.txtTithe.Size = new System.Drawing.Size(64, 23);
            this.txtTithe.TabIndex = 4;
            this.txtTithe.Text = "0.00";
            // 
            // lblGross
            // 
            this.lblGross.AutoSize = true;
            this.lblGross.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblGross.Location = new System.Drawing.Point(329, 61);
            this.lblGross.Name = "lblGross";
            this.lblGross.Size = new System.Drawing.Size(45, 20);
            this.lblGross.TabIndex = 34;
            this.lblGross.Text = "Gross";
            // 
            // txtGross
            // 
            this.txtGross.Location = new System.Drawing.Point(329, 84);
            this.txtGross.Name = "txtGross";
            this.txtGross.Size = new System.Drawing.Size(64, 23);
            this.txtGross.TabIndex = 3;
            this.txtGross.Text = "0.00";
            // 
            // cmdSubmit
            // 
            this.cmdSubmit.Location = new System.Drawing.Point(299, 140);
            this.cmdSubmit.Name = "cmdSubmit";
            this.cmdSubmit.Size = new System.Drawing.Size(84, 23);
            this.cmdSubmit.TabIndex = 32;
            this.cmdSubmit.Text = "Submit";
            this.cmdSubmit.UseVisualStyleBackColor = true;
            this.cmdSubmit.Click += new System.EventHandler(this.cmdSubmit_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(560, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 20);
            this.label5.TabIndex = 31;
            this.label5.Text = "Status";
            // 
            // lblNet
            // 
            this.lblNet.AutoSize = true;
            this.lblNet.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNet.Location = new System.Drawing.Point(250, 61);
            this.lblNet.Name = "lblNet";
            this.lblNet.Size = new System.Drawing.Size(33, 20);
            this.lblNet.TabIndex = 30;
            this.lblNet.Text = "Net";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(80, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 20);
            this.label1.TabIndex = 29;
            this.label1.Text = "Description";
            // 
            // cmbStatus
            // 
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Location = new System.Drawing.Point(518, 84);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(151, 23);
            this.cmbStatus.TabIndex = 5;
            // 
            // txtNet
            // 
            this.txtNet.Location = new System.Drawing.Point(235, 84);
            this.txtNet.Name = "txtNet";
            this.txtNet.Size = new System.Drawing.Size(64, 23);
            this.txtNet.TabIndex = 2;
            this.txtNet.Text = "0.00";
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(32, 84);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(174, 23);
            this.txtDesc.TabIndex = 1;
            this.txtDesc.Text = "Description";
            // 
            // editIncome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(701, 200);
            this.Controls.Add(this.lblTithe);
            this.Controls.Add(this.txtTithe);
            this.Controls.Add(this.lblGross);
            this.Controls.Add(this.txtGross);
            this.Controls.Add(this.cmdSubmit);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblNet);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.txtNet);
            this.Controls.Add(this.txtDesc);
            this.Name = "editIncome";
            this.Text = "editIncome";
            this.Load += new System.EventHandler(this.editIncome_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblTithe;
        private TextBox txtTithe;
        private Label lblGross;
        private TextBox txtGross;
        private Button cmdSubmit;
        private Label label5;
        private Label lblNet;
        private Label label1;
        private ComboBox cmbStatus;
        private TextBox txtNet;
        private TextBox txtDesc;
    }
}