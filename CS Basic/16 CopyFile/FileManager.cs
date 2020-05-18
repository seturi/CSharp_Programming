using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_CopyFile
{
    class FileManager
    {
        public event EventHandler<double> InProgress;
        public void Copy(string srcfile, string destfile)
        {
            byte[] buffer = new byte[1024]; // 1k
            int pos = 0;

            // 파일 사이즈
            var fi = new FileInfo(srcfile);
            var fileSize = fi.Length;

            // 파일 복사
            using (BinaryReader rd = new BinaryReader(File.Open(srcfile, FileMode.Open)))
            using (BinaryWriter wr = new BinaryWriter(File.Open(destfile, FileMode.Create)))
            {
                while (pos < fileSize)
                {
                    int count = rd.Read(buffer, 0, buffer.Length);
                    wr.Write(buffer, 0, count);
                    pos += count;
                    double pct = (pos / (double) fileSize) * 100;

                    if(InProgress != null)
                    {
                        InProgress(this, pct);
                    }
                }
            }
        }
    }
}
