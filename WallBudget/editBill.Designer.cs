﻿namespace WallBudget
{
    partial class editBill
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
            this.cmbSubmit = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.txtAmt = new System.Windows.Forms.TextBox();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cmbSubmit
            // 
            this.cmbSubmit.Location = new System.Drawing.Point(312, 126);
            this.cmbSubmit.Name = "cmbSubmit";
            this.cmbSubmit.Size = new System.Drawing.Size(75, 23);
            this.cmbSubmit.TabIndex = 31;
            this.cmbSubmit.Text = "Submit";
            this.cmbSubmit.UseVisualStyleBackColor = true;
            this.cmbSubmit.Click += new System.EventHandler(this.cmbSubmit_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblStatus.Location = new System.Drawing.Point(607, 55);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(49, 20);
            this.lblStatus.TabIndex = 30;
            this.lblStatus.Text = "Status";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(417, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 20);
            this.label4.TabIndex = 29;
            this.label4.Text = "Notes";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(273, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 20);
            this.label3.TabIndex = 28;
            this.label3.Text = "Due Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(205, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 20);
            this.label2.TabIndex = 27;
            this.label2.Text = "Amount";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(66, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 20);
            this.label1.TabIndex = 26;
            this.label1.Text = "Description";
            // 
            // cmbStatus
            // 
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Location = new System.Drawing.Point(565, 78);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(151, 23);
            this.cmbStatus.TabIndex = 5;
            // 
            // txtNotes
            // 
            this.txtNotes.Location = new System.Drawing.Point(342, 78);
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(217, 23);
            this.txtNotes.TabIndex = 4;
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(277, 78);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(59, 23);
            this.txtDate.TabIndex = 3;
            this.txtDate.Text = "7/15";
            // 
            // txtAmt
            // 
            this.txtAmt.Location = new System.Drawing.Point(205, 78);
            this.txtAmt.Name = "txtAmt";
            this.txtAmt.Size = new System.Drawing.Size(64, 23);
            this.txtAmt.TabIndex = 2;
            this.txtAmt.Text = "0.00";
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(25, 78);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(174, 23);
            this.txtDesc.TabIndex = 1;
            this.txtDesc.Text = "Description";
            // 
            // editBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(740, 174);
            this.Controls.Add(this.cmbSubmit);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.txtNotes);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.txtAmt);
            this.Controls.Add(this.txtDesc);
            this.Name = "editBill";
            this.Text = "editBill";
            this.Load += new System.EventHandler(this.editBill_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button cmbSubmit;
        private Label lblStatus;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox cmbStatus;
        private TextBox txtNotes;
        private TextBox txtDate;
        private TextBox txtAmt;
        private TextBox txtDesc;
    }
}