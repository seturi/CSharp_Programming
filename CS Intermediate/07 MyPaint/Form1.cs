using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _07_MyPaint
{
    public partial class Form1 : Form
    {
        private List<IDrawable> drawings = new List<IDrawable>();
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox_Paint(object sender, PaintEventArgs e)
        {
            foreach(IDrawable s in drawings)
            {
                s.Draw(e.Graphics);
            }
        }

        private void Custom1_Draw()
        {
            Point loc = pictureBox.PointToClient(MousePosition);

            Assembly custom = Assembly.LoadFrom(@"C:\Users\SwKim\Desktop\ing\Coding\C# Programming\CS Intermediate\07 MyPaintCustom1\bin\Debug\07 MyPaintCustom1.dll");
            Type pie = custom.GetType("MyPaintCustom1.Pie");
            IDrawable obj = (IDrawable)Activator.CreateInstance(pie, loc.X, loc.Y, 100, 100, 100);
            obj.Draw(pictureBox.CreateGraphics());

            drawings.Add(obj);
        }

        #region Private Method
        #endregion
    }
}
