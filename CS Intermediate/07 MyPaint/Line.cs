using System;
using System.Drawing;

namespace _07_MyPaint
{
    class Line : Shape, IDrawable
    {
        public int Length { get; set; } = 50;

        public void Draw(Graphics g)
        {
            Point pt2 = new Point(Location.X + Length, Location.Y + Length);
            g.DrawLine(Pens.Blue, Location, pt2);
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
