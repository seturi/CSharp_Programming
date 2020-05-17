using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _15_MyWinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if(txtUsername.Text == "admin" && txtPassword.Text == "1234")
            {
                MessageBox.Show("로그인이 성공했습니다.");
            }
            else
            {
                MessageBox.Show("로그인이 실패했습니다.", "에러");
            }
        }
    }
}
