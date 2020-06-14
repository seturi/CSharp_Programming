namespace _28_ChartControl
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnAddY = new System.Windows.Forms.Button();
            this.btnAddXY = new System.Windows.Forms.Button();
            this.chartB = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnType = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chartA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartB)).BeginInit();
            this.SuspendLayout();
            // 
            // chartA
            // 
            chartArea1.Name = "ChartArea1";
            this.chartA.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartA.Legends.Add(legend1);
            this.chartA.Location = new System.Drawing.Point(29, 27);
            this.chartA.Name = "chartA";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartA.Series.Add(series1);
            this.chartA.Size = new System.Drawing.Size(372, 421);
            this.chartA.TabIndex = 0;
            this.chartA.Text = "chart1";
            // 
            // btnAddY
            // 
            this.btnAddY.Location = new System.Drawing.Point(163, 458);
            this.btnAddY.Name = "btnAddY";
            this.btnAddY.Size = new System.Drawing.Size(75, 70);
            this.btnAddY.TabIndex = 1;
            this.btnAddY.Text = "Add Y";
            this.btnAddY.UseVisualStyleBackColor = true;
            this.btnAddY.Click += new System.EventHandler(this.btnAddY_Click);
            // 
            // btnAddXY
            // 
            this.btnAddXY.Location = new System.Drawing.Point(574, 454);
            this.btnAddXY.Name = "btnAddXY";
            this.btnAddXY.Size = new System.Drawing.Size(75, 70);
            this.btnAddXY.TabIndex = 2;
            this.btnAddXY.Text = "Add XY";
            this.btnAddXY.UseVisualStyleBackColor = true;
            this.btnAddXY.Click += new System.EventHandler(this.btnAddXY_Click);
            // 
            // chartB
            // 
            chartArea2.Name = "ChartArea1";
            this.chartB.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartB.Legends.Add(legend2);
            this.chartB.Location = new System.Drawing.Point(512, 27);
            this.chartB.Name = "chartB";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartB.Series.Add(series2);
            this.chartB.Size = new System.Drawing.Size(372, 421);
            this.chartB.TabIndex = 3;
            this.chartB.Text = "chart2";
            // 
            // btnType
            // 
            this.btnType.Location = new System.Drawing.Point(709, 454);
            this.btnType.Name = "btnType";
            this.btnType.Size = new System.Drawing.Size(75, 70);
            this.btnType.TabIndex = 4;
            this.btnType.Text = "Type";
            this.btnType.UseVisualStyleBackColor = true;
            this.btnType.Click += new System.EventHandler(this.btnType_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 540);
            this.Controls.Add(this.btnType);
            this.Controls.Add(this.chartB);
            this.Controls.Add(this.btnAddXY);
            this.Controls.Add(this.btnAddY);
            this.Controls.Add(this.chartA);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chartA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartA;
        private System.Windows.Forms.Button btnAddY;
        private System.Windows.Forms.Button btnAddXY;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartB;
        private System.Windows.Forms.Button btnType;
    }
}

