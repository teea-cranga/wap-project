namespace wap_project.Forms
{
    partial class StatsForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StatsForm));
            this.chartStuds = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartStuds)).BeginInit();
            this.SuspendLayout();
            // 
            // chartStuds
            // 
            this.chartStuds.BorderlineColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.chartStuds.ChartAreas.Add(chartArea1);
            this.chartStuds.Cursor = System.Windows.Forms.Cursors.Default;
            legend1.Name = "Legend1";
            this.chartStuds.Legends.Add(legend1);
            this.chartStuds.Location = new System.Drawing.Point(-7, -2);
            this.chartStuds.Name = "chartStuds";
            this.chartStuds.Size = new System.Drawing.Size(528, 380);
            this.chartStuds.TabIndex = 0;
            this.chartStuds.Text = "Distributions of students";
            this.chartStuds.Paint += new System.Windows.Forms.PaintEventHandler(this.chart1_Paint);
            // 
            // StatsForm
            // 
            this.ClientSize = new System.Drawing.Size(519, 375);
            this.Controls.Add(this.chartStuds);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StatsForm";
            this.Text = "Distribution of Students";
            ((System.ComponentModel.ISupportInitialize)(this.chartStuds)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartStuds;
    }
}