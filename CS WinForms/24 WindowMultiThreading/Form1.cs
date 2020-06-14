using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _24_WindowMultiThreading
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            Thread worker = new Thread(new ThreadStart(MyThreadRun));
            worker.Start();
        }

        private void MyThreadRun()
        {
            //string srcDir = @"C:\Temp\_Src";
            //string destDir = @"C:\Temp\_Dest";

            //DirectoryInfo di = new DirectoryInfo(srcDir);
            //FileInfo[] fileInfos = di.GetFiles();
            //int totalFiles = fileInfos.Length;
            //int counter = 0;
            //int pct = 0;
            //foreach (var fi in fileInfos)
            //{
            //    string destFile = Path.Combine(destDir, fi.Name);
            //    File.Copy(fi.FullName, destFile);
            //    //Thread.Sleep(1000);
            //    pct = ((++counter * 100) / totalFiles);
            //    ShowProgress(pct);
            //}

            int sum = 0;
            int pct = 0;
            int max = 100000;

            for (int i = 1; i < max; i++)
            {
                sum += i;
                pct = i * 100 / max;
                ShowProgress(pct);
            }
        }

        delegate void ShowDelegate(int percent);

        private void ShowProgress(int pct)
        {
            if (InvokeRequired)
            {
                ShowDelegate del = new ShowDelegate(ShowProgress);
                //또는 ShowDelegate del = p => ShowProgress(p);
                Invoke(del, pct);
            }
            else
            {
                progressBar1.Value = pct;
            }
        }

    }
}
