using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20_TooltipControl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(txtName, "성과 이름을 모두 기록해 주십시오.");
            toolTip1.SetToolTip(txtJumin, "주민번호 입력시 '-'를 생략해 주십시오.");
        }
    }
}
