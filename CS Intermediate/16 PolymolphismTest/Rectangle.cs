using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_InheritanceTest
{
    public class Rectangle : Shape
    {
        private int height;
        private int width;

        public Rectangle()      // Default Constructor
        {
            height = width = 0;
            Name = "Unnamed";
        }

        public Rectangle(string name)
        {
            this.Name = name;
        }

        public Rectangle(string name, int height, int width)
        {
            this.Name = name;
            this.height = height;
            this.width = width;
        }



        public int Height
        {
            get
            {
                return this.height;
            }
            set
            {
                if(value <= 0)
                {
                    throw new InvalidOperationException();
                }
                this.height = value;
            }
        }
        public int Width
        {
            get
            {
                return this.width;
            }
            set
            {
                if (value <= 0)
                {
                    throw new InvalidOperationException();
                }
                this.width = value;
            }
        }

        public int CalculateArea()
        {
            int area = height * width;
            return area;
        }

        public override void Draw()
        {
            if(DrawStarted != null)
            {
                DrawStarted(this, EventArgs.Empty);
            }

            Console.WriteLine("ObjectId={0} : Drawing....", this.ID);

            if(DrawCompleted != null)
            {
                DrawCompleted(this, EventArgs.Empty);
            }
        }

        public event EventHandler DrawStarted;
        public event EventHandler DrawCompleted;
    }

    sealed class Square : Rectangle
    {

    }
}
