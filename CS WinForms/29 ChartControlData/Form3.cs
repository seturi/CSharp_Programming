using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _29_ChartControlData
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnData_Click(object sender, EventArgs e)
        {
            // DataBindCrossTable() 사용

            DataTable dt = new DataTable("Order");
            dt.Columns.Add("customer");
            dt.Columns.Add("product");
            dt.Columns.Add("orders");
            dt.Rows.Add("Tom", "USB", 10);
            dt.Rows.Add("Tom", "HDD", 2);
            dt.Rows.Add("Tom", "Monitor", 1);
            dt.Rows.Add("Jane", "USB", 3);
            dt.Rows.Add("Jane", "HDD", 1);
            dt.Rows.Add("Jane", "Monitor", 2);

            // Product별로 Series를 하나씩 자동으로 생성
            // X축은 customer 컬럼, Y축은 orders 컬럼
            // 각 그래프 상단에 product명으로 Label을 붙임
            chart9.DataBindCrossTable(dt.AsEnumerable(), "product", "customer", "orders", "Label=product");
        }
    }
}
