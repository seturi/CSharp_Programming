using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _11_MaskedTextBoxControl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // 0는 반드시 숫자 입력 요
            // 9은 숫자나 공란
            maskedTextBox1.Mask = "(999)000-0000";
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            if (e.Position < 5) // (999)인 경우
            {
                toolTip1.Show("숫자나 공란만 입력 가능", this);
            }
            else // 000-0000 인 경우
            {
                toolTip1.Show("숫자만 입력 가능", this);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string val = maskedTextBox1.Text;
            MessageBox.Show(val);
        }
    }
}
