﻿namespace wap_project
{
    partial class AddStudForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddStudForm));
            this.tbFN = new System.Windows.Forms.TextBox();
            this.lblFName = new System.Windows.Forms.Label();
            this.lblLName = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbLN = new System.Windows.Forms.TextBox();
            this.btnAddStud = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cbFAC = new System.Windows.Forms.ComboBox();
            this.errFName = new System.Windows.Forms.ErrorProvider(this.components);
            this.errLName = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errFName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errLName)).BeginInit();
            this.SuspendLayout();
            // 
            // tbFN
            // 
            this.tbFN.Location = new System.Drawing.Point(141, 41);
            this.tbFN.Name = "tbFN";
            this.tbFN.Size = new System.Drawing.Size(243, 22);
            this.tbFN.TabIndex = 0;
            this.tbFN.Validating += new System.ComponentModel.CancelEventHandler(this.textBox1_Validating);
            // 
            // lblFName
            // 
            this.lblFName.AutoSize = true;
            this.lblFName.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblFName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFName.Location = new System.Drawing.Point(18, 41);
            this.lblFName.Name = "lblFName";
            this.lblFName.Size = new System.Drawing.Size(78, 18);
            this.lblFName.TabIndex = 1;
            this.lblFName.Text = "First name";
            // 
            // lblLName
            // 
            this.lblLName.AutoSize = true;
            this.lblLName.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblLName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLName.Location = new System.Drawing.Point(18, 101);
            this.lblLName.Name = "lblLName";
            this.lblLName.Size = new System.Drawing.Size(77, 18);
            this.lblLName.TabIndex = 2;
            this.lblLName.Text = "Last name";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Controls.Add(this.tbLN);
            this.groupBox1.Controls.Add(this.tbFN);
            this.groupBox1.Controls.Add(this.lblLName);
            this.groupBox1.Controls.Add(this.lblFName);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(479, 166);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Student Information";
            // 
            // tbLN
            // 
            this.tbLN.Location = new System.Drawing.Point(140, 97);
            this.tbLN.Name = "tbLN";
            this.tbLN.Size = new System.Drawing.Size(244, 22);
            this.tbLN.TabIndex = 3;
            this.tbLN.Validating += new System.ComponentModel.CancelEventHandler(this.tbLN_Validating);
            // 
            // btnAddStud
            // 
            this.btnAddStud.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAddStud.Location = new System.Drawing.Point(10, 105);
            this.btnAddStud.Name = "btnAddStud";
            this.btnAddStud.Size = new System.Drawing.Size(128, 39);
            this.btnAddStud.TabIndex = 11;
            this.btnAddStud.Text = "Add student";
            this.btnAddStud.UseVisualStyleBackColor = true;
            this.btnAddStud.Click += new System.EventHandler(this.btnAddStud_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.cbFAC);
            this.groupBox2.Controls.Add(this.btnAddStud);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(2, 159);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(479, 161);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Year and Subject";
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Location = new System.Drawing.Point(334, 105);
            this.button1.Name = "button1";
            this.button1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.button1.Size = new System.Drawing.Size(128, 39);
            this.button1.TabIndex = 16;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 18);
            this.label3.TabIndex = 15;
            this.label3.Text = "Faculty subject";
            // 
            // cbFAC
            // 
            this.cbFAC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFAC.FormattingEnabled = true;
            this.cbFAC.Items.AddRange(new object[] {
            "Statistics",
            "Economic Informatics",
            "Economic Informatics(in English)",
            "Cybernetics"});
            this.cbFAC.Location = new System.Drawing.Point(140, 48);
            this.cbFAC.Name = "cbFAC";
            this.cbFAC.Size = new System.Drawing.Size(244, 24);
            this.cbFAC.TabIndex = 13;
            // 
            // errFName
            // 
            this.errFName.ContainerControl = this;
            // 
            // errLName
            // 
            this.errLName.ContainerControl = this;
            // 
            // AddStudForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 315);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AddStudForm";
            this.Text = "Add a student";
            this.Load += new System.EventHandler(this.AddStudForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errFName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errLName)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tbFN;
        private System.Windows.Forms.Label lblFName;
        private System.Windows.Forms.Label lblLName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbLN;
        private System.Windows.Forms.Button btnAddStud;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbFAC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ErrorProvider errFName;
        private System.Windows.Forms.ErrorProvider errLName;
        private System.Windows.Forms.Button button1;
    }
}