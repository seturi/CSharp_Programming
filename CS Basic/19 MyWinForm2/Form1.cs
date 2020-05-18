using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _19_MyWinForm2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string mf = radioM.Checked ? "남" : "여";

            string data = txtName.Text + ", " + cboRegion.SelectedItem + ", " + dtDOB.Value + ", " + mf;

            StreamWriter wr = new StreamWriter(@"C:\Test\test.txt", true);
            wr.WriteLine(data);
            wr.Close();

            txtName.Text = "";
            cboRegion.SelectedIndex = -1;
            dtDOB.Value = DateTime.Now;
        }
    }
}
