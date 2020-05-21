using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_InheritanceTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle("Rect1");
            string name = r.Name;
            r.Draw();
        }
    }
}
