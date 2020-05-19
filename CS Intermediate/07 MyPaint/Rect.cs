using System;
using System.Drawing;

namespace _07_MyPaint
{
    class Rect : Shape, IDrawable
    {
        public int Width { get; set; } = 50;
        public int Height { get; set; } = 50;

        public void Draw(Graphics g)
        {
            g.DrawRectangle(Pens.Red, Location.X, Location.Y, Width, Height);
        }

        public override void Clip()
        {
            throw new NotImplementedException();
        }

        public override void Resize()
        {
            throw new NotImplementedException();
        }
    }
}
