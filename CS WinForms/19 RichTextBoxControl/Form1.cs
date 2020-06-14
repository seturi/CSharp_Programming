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

namespace _19_RichTextBoxControl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLoadFile_Click(object sender, EventArgs e)
        {
            string filepath = txtFilename.Text;
            if (string.IsNullOrEmpty(filepath) || !File.Exists(filepath))
            {
                MessageBox.Show("Invalid file name");
                return;
            }

            // Load .RTF or Text File
            richTextBox1.LoadFile(filepath);
        }

        private void btnChangeAllToItalic_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionStart = 0;
            richTextBox1.SelectionLength = richTextBox1.Text.Length;
            richTextBox1.SelectionFont = new Font(SystemFonts.DefaultFont, FontStyle.Italic);
        }
    }
}
