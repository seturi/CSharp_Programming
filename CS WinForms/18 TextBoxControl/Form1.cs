using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _18_TextBoxControl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TextBox 에 초기 값 할당
            txtSingleLine.Text = "서울특별시 강남구 서초동 123번지";

            StringBuilder sb = new StringBuilder();
            sb.AppendLine("이름 : 홍길동");
            sb.AppendLine("나이 : 25세");
            sb.AppendLine("국적 : 한국");
            txtMultiLine.Text = sb.ToString();
        }

        private void txtSingleLine_TextChanged(object sender, EventArgs e)
        {
            // 오른쪽으로 문자열 정렬
            txtSingleLine.SelectionStart = txtSingleLine.TextLength;
            txtSingleLine.SelectionLength = 0;
        }
    }
}
