using _15_InheritanceTest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_PolymolphismTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle("Rect1");
            Triangle t = new Triangle("Tri1");
            Circle c = new Circle("Circle1");

            // Using Editor1
            GraphicEditor1 editor1 = new GraphicEditor1();
            editor1.DrawShpae(r);
            editor1.DrawShpae(t);
            editor1.DrawShpae(c);

            // Using Editor2
            Editor2 editor2 = new Editor2();
            editor2.DrawShape(r);
            editor2.DrawShape(t);
            editor2.DrawShape(c);

            // Using OOP Polymolphism


        }
    }
}
