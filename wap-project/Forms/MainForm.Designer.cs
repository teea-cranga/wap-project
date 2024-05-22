﻿namespace wap_project
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btnAddStud = new System.Windows.Forms.Button();
            this.btnEditStud = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDelStud = new System.Windows.Forms.Button();
            this.lvStudents = new System.Windows.Forms.ListView();
            this.colFN = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colLN = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSub = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colYear = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.createAReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblStrip = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblStrip2 = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.textBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddStud
            // 
            this.btnAddStud.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.btnAddStud.Location = new System.Drawing.Point(501, 19);
            this.btnAddStud.Name = "btnAddStud";
            this.btnAddStud.Size = new System.Drawing.Size(167, 41);
            this.btnAddStud.TabIndex = 1;
            this.btnAddStud.Text = "Add Student";
            this.btnAddStud.UseVisualStyleBackColor = false;
            this.btnAddStud.Click += new System.EventHandler(this.btnAddStud_Click);
            // 
            // btnEditStud
            // 
            this.btnEditStud.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.btnEditStud.Location = new System.Drawing.Point(501, 66);
            this.btnEditStud.Name = "btnEditStud";
            this.btnEditStud.Size = new System.Drawing.Size(167, 41);
            this.btnEditStud.TabIndex = 2;
            this.btnEditStud.Text = "Edit Student";
            this.btnEditStud.UseVisualStyleBackColor = false;
            this.btnEditStud.Click += new System.EventHandler(this.btnEditStud_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Transparent;
            this.textBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("textBox1.BackgroundImage")));
            this.textBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.textBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("textBox1.InitialImage")));
            this.textBox1.Location = new System.Drawing.Point(-46, -64);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(398, 222);
            this.textBox1.TabIndex = 3;
            this.textBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Controls.Add(this.btnDelStud);
            this.groupBox1.Controls.Add(this.btnAddStud);
            this.groupBox1.Controls.Add(this.btnEditStud);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(58, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(700, 158);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // btnDelStud
            // 
            this.btnDelStud.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.btnDelStud.Location = new System.Drawing.Point(501, 111);
            this.btnDelStud.Name = "btnDelStud";
            this.btnDelStud.Size = new System.Drawing.Size(167, 41);
            this.btnDelStud.TabIndex = 4;
            this.btnDelStud.Text = "Delete Student";
            this.btnDelStud.UseVisualStyleBackColor = false;
            this.btnDelStud.Click += new System.EventHandler(this.btnDelStud_Click);
            // 
            // lvStudents
            // 
            this.lvStudents.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colFN,
            this.colLN,
            this.colSub,
            this.colYear});
            this.lvStudents.HideSelection = false;
            this.lvStudents.Location = new System.Drawing.Point(58, 204);
            this.lvStudents.Name = "lvStudents";
            this.lvStudents.Size = new System.Drawing.Size(700, 236);
            this.lvStudents.TabIndex = 6;
            this.lvStudents.UseCompatibleStateImageBehavior = false;
            this.lvStudents.View = System.Windows.Forms.View.Details;
            // 
            // colFN
            // 
            this.colFN.Text = "First Name";
            this.colFN.Width = 180;
            // 
            // colLN
            // 
            this.colLN.Text = "Last Name";
            this.colLN.Width = 207;
            // 
            // colSub
            // 
            this.colSub.Text = "Subject";
            this.colSub.Width = 191;
            // 
            // colYear
            // 
            this.colYear.Text = "Year";
            this.colYear.Width = 116;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createAReportToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(153, 26);
            // 
            // createAReportToolStripMenuItem
            // 
            this.createAReportToolStripMenuItem.Name = "createAReportToolStripMenuItem";
            this.createAReportToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.createAReportToolStripMenuItem.Text = "Create a report";
            this.createAReportToolStripMenuItem.Click += new System.EventHandler(this.createAReportToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.lblStrip,
            this.toolStripStatusLabel2,
            this.lblStrip2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 467);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(815, 22);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(93, 17);
            this.toolStripStatusLabel1.Text = "Students count: ";
            // 
            // lblStrip
            // 
            this.lblStrip.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblStrip.Name = "lblStrip";
            this.lblStrip.Size = new System.Drawing.Size(13, 17);
            this.lblStrip.Text = "0";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripStatusLabel2.ForeColor = System.Drawing.SystemColors.Control;
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(73, 17);
            this.toolStripStatusLabel2.Text = "......................";
            // 
            // lblStrip2
            // 
            this.lblStrip2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblStrip2.Name = "lblStrip2";
            this.lblStrip2.Size = new System.Drawing.Size(80, 17);
            this.lblStrip2.Text = "No report yet.";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(815, 489);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.lvStudents);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Academify";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.textBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAddStud;
        private System.Windows.Forms.Button btnEditStud;
        private System.Windows.Forms.PictureBox textBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDelStud;
        private System.Windows.Forms.ListView lvStudents;
        private System.Windows.Forms.ColumnHeader colFN;
        private System.Windows.Forms.ColumnHeader colLN;
        private System.Windows.Forms.ColumnHeader colSub;
        private System.Windows.Forms.ColumnHeader colYear;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem createAReportToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel lblStrip;
        private System.Windows.Forms.ToolStripStatusLabel lblStrip2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
    }
}

