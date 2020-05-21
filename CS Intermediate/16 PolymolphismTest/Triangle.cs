using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_InheritanceTest
{
    public class Triangle : Shape
    {
        public Triangle()      // Default Constructor
        {
            Name = "Unnamed";
        }

        public Triangle(string name)
        {
            this.Name = name;
        }

        public override void Draw()
        {
            if (DrawStarted != null)
            {
                DrawStarted(this, EventArgs.Empty);
            }

            Console.WriteLine("ObjectId={0} : Drawing....", this.ID);

            if (DrawCompleted != null)
            {
                DrawCompleted(this, EventArgs.Empty);
            }
        }

        public event EventHandler DrawStarted;
        public event EventHandler DrawCompleted;
    }
}
