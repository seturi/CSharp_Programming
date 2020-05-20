using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _09_AnonymousMethod
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        delegate void RunDelegate(int p);
        delegate int Expr(int a, int b);

        private void Form1_Load(object sender, EventArgs e)
        {
            // 무명 메서드
            RunDelegate r = delegate (int p) { MessageBox.Show(p.ToString()); };
            r(123);

            Expr expr = delegate (int a, int b)
            {
                return 2 * a + b;
            };
            int result = expr(1, 2);

            button1.Click += delegate (object s, EventArgs ea)
            {
                MessageBox.Show("Button1");
            };
        }
    }
}
