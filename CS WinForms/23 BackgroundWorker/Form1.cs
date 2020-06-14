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

namespace _23_BackgroundWorker
{
    public partial class Form1 : Form
    {
        private BackgroundWorker worker;

        public Form1()
        {
            InitializeComponent();
            worker = new BackgroundWorker();
            worker.WorkerReportsProgress = true;
            worker.WorkerSupportsCancellation = true;
            worker.DoWork += new DoWorkEventHandler(worker_DoWork);
            worker.ProgressChanged += new ProgressChangedEventHandler(worker_ProgressChanged);
            worker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(worker_RunWorkerCompleted);
        }
        // Worker Thread가 실제 하는 일
        void worker_DoWork(object sender, DoWorkEventArgs e)
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

            //    pct = ((++counter * 100) / totalFiles);
            //    worker.ReportProgress(pct);
            //}

            int sum = 0;
            int pct = 0;
            int max = 100000;

            for(int i = 1; i < max; i++)
            {
                sum += i;
                pct = i * 100 / max;
                worker.ReportProgress(pct);
            }
        }

        // Progress 리포트 - UI Thread
        void worker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            this.progressBar1.Value = e.ProgressPercentage;
        }

        // 작업 완료 - UI Thread
        void worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            // 에러가 있는지 체크
            if (e.Error != null)
            {
                lblMsg.Text = e.Error.Message;
                MessageBox.Show(e.Error.Message, "Error");
                return;
            }

            lblMsg.Text = "성공적으로 완료되었습니다";
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            // 비동기(Async)로 실행 
            worker.RunWorkerAsync();
        }
    }
}
