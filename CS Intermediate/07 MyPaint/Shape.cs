using System.Drawing;

namespace _07_MyPaint
{
    abstract class Shape
    {
        public Point Location { get; set; } = new Point(0, 0);
        public string Name { get; set; }
        public string Tag { get; set; }

        // 고급 기능들
        public abstract void Clip(/**/);
        public abstract void Resize();
        //...
    }
}
