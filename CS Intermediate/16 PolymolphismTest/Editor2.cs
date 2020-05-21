using _15_InheritanceTest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_PolymolphismTest
{
    class Editor2
    {
        public void DrawShape(object obj)
        {
            if(obj is Rectangle)
            {
                Rectangle r = (Rectangle)obj;
                r.Draw();
            }
            else if (obj is Triangle)
            {
                Triangle t = (Triangle)obj;
                t.Draw();
            }
            else if (obj is Circle)
            {
                Circle c = (Circle)obj;
                c.Draw();
            }
        }
    }
}
