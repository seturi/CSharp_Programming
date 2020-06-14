using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _15_PictureBoxControl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            var src = (Bitmap)Bitmap.FromFile("../../img/soju.png");

            // 소스이미지 크기와 동일한 타겟이미지 생성
            Bitmap tgt = new Bitmap(src.Width, src.Height);

            // 타겟이미지의 Graphics 객체 얻기        
            using (Graphics g = Graphics.FromImage(tgt))
            {
                // 배경색을 설정
                var rect = new Rectangle(0, 0, tgt.Width, tgt.Height);
                using (Brush br = new SolidBrush(SystemColors.Control))
                {
                    g.FillRectangle(br, 0, 0, tgt.Width, tgt.Height);
                }

                // 원모양으로 Clip
                GraphicsPath path = new GraphicsPath();
                path.AddEllipse(0, 0, tgt.Width, tgt.Height);
                g.SetClip(path);

                // 소스이미지를 원모양으로 잘라 타겟이미지에 출력
                g.DrawImage(src, 0, 0);
            }

            // PictureBox에 이미지 출력
            pictureBox1.Image = tgt;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (pictureBox1.SizeMode == PictureBoxSizeMode.Zoom)
            {
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else
            {
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }
    }
}
