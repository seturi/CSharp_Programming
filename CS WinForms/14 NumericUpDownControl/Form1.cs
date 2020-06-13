using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _14_NumericUpDownControl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            numericUpDown1.Value = 21.0M;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            // 섭씨를 화씨로 변경
            decimal C = numericUpDown1.Value;
            decimal F = C * (9.0M / 5.0M) + 32.0M;

            // 화씨 출력
            this.txtFahrenheit.Text = F.ToString();
        }
    }
}
