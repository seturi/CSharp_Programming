namespace _29_ChartControlData
{
    partial class Form3
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
            this.chart9 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnData = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart9)).BeginInit();
            this.SuspendLayout();
            // 
            // chart9
            // 
            chartArea1.Name = "ChartArea1";
            this.chart9.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart9.Legends.Add(legend1);
            this.chart9.Location = new System.Drawing.Point(12, 12);
            this.chart9.Name = "chart9";
            this.chart9.Size = new System.Drawing.Size(424, 426);
            this.chart9.TabIndex = 0;
            this.chart9.Text = "chart1";
            // 
            // btnData
            // 
            this.btnData.Location = new System.Drawing.Point(492, 374);
            this.btnData.Name = "btnData";
            this.btnData.Size = new System.Drawing.Size(107, 64);
            this.btnData.TabIndex = 1;
            this.btnData.Text = "데이터";
            this.btnData.UseVisualStyleBackColor = true;
            this.btnData.Click += new System.EventHandler(this.btnData_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 450);
            this.Controls.Add(this.btnData);
            this.Controls.Add(this.chart9);
            this.Name = "Form3";
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.chart9)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart9;
        private System.Windows.Forms.Button btnData;
    }
}