namespace _29_ChartControlData
{
    partial class Form2
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
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.chart7 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart6 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnData = new System.Windows.Forms.Button();
            this.chart5 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnForm3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart5)).BeginInit();
            this.SuspendLayout();
            // 
            // chart7
            // 
            chartArea1.Name = "ChartArea1";
            this.chart7.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart7.Legends.Add(legend1);
            this.chart7.Location = new System.Drawing.Point(735, 12);
            this.chart7.Name = "chart7";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "sales";
            this.chart7.Series.Add(series1);
            this.chart7.Size = new System.Drawing.Size(352, 333);
            this.chart7.TabIndex = 7;
            this.chart7.Text = "chart3";
            // 
            // chart6
            // 
            chartArea2.Name = "ChartArea1";
            this.chart6.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart6.Legends.Add(legend2);
            this.chart6.Location = new System.Drawing.Point(377, 12);
            this.chart6.Name = "chart6";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "sales";
            this.chart6.Series.Add(series2);
            this.chart6.Size = new System.Drawing.Size(352, 333);
            this.chart6.TabIndex = 6;
            this.chart6.Text = "chart2";
            // 
            // btnData
            // 
            this.btnData.Location = new System.Drawing.Point(448, 385);
            this.btnData.Name = "btnData";
            this.btnData.Size = new System.Drawing.Size(170, 53);
            this.btnData.TabIndex = 5;
            this.btnData.Text = "데이터";
            this.btnData.UseVisualStyleBackColor = true;
            this.btnData.Click += new System.EventHandler(this.btnData_Click);
            // 
            // chart5
            // 
            chartArea3.Name = "ChartArea1";
            this.chart5.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart5.Legends.Add(legend3);
            this.chart5.Location = new System.Drawing.Point(19, 12);
            this.chart5.Name = "chart5";
            this.chart5.Size = new System.Drawing.Size(352, 333);
            this.chart5.TabIndex = 4;
            this.chart5.Text = "chart1";
            // 
            // btnForm3
            // 
            this.btnForm3.Location = new System.Drawing.Point(864, 388);
            this.btnForm3.Name = "btnForm3";
            this.btnForm3.Size = new System.Drawing.Size(89, 46);
            this.btnForm3.TabIndex = 8;
            this.btnForm3.Text = "다음";
            this.btnForm3.UseVisualStyleBackColor = true;
            this.btnForm3.Click += new System.EventHandler(this.btnForm3_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1099, 463);
            this.Controls.Add(this.btnForm3);
            this.Controls.Add(this.chart7);
            this.Controls.Add(this.chart6);
            this.Controls.Add(this.btnData);
            this.Controls.Add(this.chart5);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.chart7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart7;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart6;
        private System.Windows.Forms.Button btnData;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart5;
        private System.Windows.Forms.Button btnForm3;
    }
}