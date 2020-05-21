using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_InheritanceTest
{
    public class GraphicEditor1
    {
        public void DrawShpae(Rectangle r)
        {
            r.Draw();
        }
        public void DrawShpae(Triangle t)
        {
            t.Draw();
        }
        public void DrawShpae(Circle c)
        {
            c.Draw();
        }
    }
}
