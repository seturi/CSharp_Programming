using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02_CheckBoxControl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkEvents_CheckedChanged(object sender, EventArgs e)
        {
            checkEvent1.Checked = checkEvents.Checked;
            checkEvent2.Checked = checkEvents.Checked;
        }
    }
}
