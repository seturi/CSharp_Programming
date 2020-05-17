using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_StructTest
{
    struct Rect
    {
        public int Left;
        public int Top;
        public int Width;
        public int Height;
        public Rect(int left, int top, int width, int height)
        {
            Left = left;
            Top = top;
            Width = width;
            Height = height;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Rect r = new Rect(10, 10, 100, 100);
            Draw(r);
        }

        static void Draw(Rect r)
        {
            DrawRectangle(r);
            PrintData(r);
        }

        static void DrawRectangle(Rect r)
        {
            //
        }

        static void PrintData(Rect r)
        {
            int right = r.Left + r.Width;
            int bottom = r.Top + r.Height;
            Console.WriteLine($"{r.Left}. {r.Top} ~ {right}, {bottom}");

        }
    }
}
