using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration; // 1. ConfigurationManager 네임스페이스 지정
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _27_App.Config
{
    public partial class Form1 : Form
    {
        private string dataDirectory;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // 2. AppSettings 에서 DataDirectory 값 읽기
            this.dataDirectory = ConfigurationManager.AppSettings["DataDirectory"];
        }
    }
}
