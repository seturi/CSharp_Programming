using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace _28_ChartControl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Y만 추가한 경우
        private void btnAddY_Click(object sender, EventArgs e)
        {
            chartA.Series["Series1"].Points.Clear();
            chartA.Series["Series1"].Points.Add(100);  // X=1
            chartA.Series["Series1"].Points.Add(200);  // X=2
            chartA.Series["Series1"].Points.Add(300);
            chartA.Series["Series1"].Points.Add(400);
        }

        // X,Y를 추가한 경우
        private void btnAddXY_Click(object sender, EventArgs e)
        {
            chartB.Series["Series1"].Points.Clear();
            chartB.Series["Series1"].Points.AddXY(10, 100);
            chartB.Series["Series1"].Points.AddXY(20, 200);
            chartB.Series["Series1"].Points.AddXY(30, 300);
            chartB.Series["Series1"].Points.AddXY(40, 400);
        }

        private void btnType_Click(object sender, EventArgs e)
        {
            chartB.Series[0].Points.Clear();
            chartB.Series[0].Points.AddXY(10, 100);
            chartB.Series[0].Points.AddXY(20, 500);
            chartB.Series[0].Points.AddXY(30, 300);
            chartB.Series[0].Points.AddXY(40, 400);

            //chartB.Series[0].ChartType = SeriesChartType.Pie;
            //chartB.Series[0].ChartType = SeriesChartType.Line;
            //chartB.Series[0].ChartType = SeriesChartType.Bar;
            chartB.Series[0].ChartType = SeriesChartType.SplineArea;
        }
    }
}
