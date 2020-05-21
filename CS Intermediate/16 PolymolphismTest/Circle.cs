using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_InheritanceTest
{
    public class Circle : Shape
    {
        public Circle()      // Default Constructor
        {
            Name = "Unnamed";
        }

        public Circle(string name)
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
