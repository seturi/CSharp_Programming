using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_ClassTest
{
    class Brick
    {
        // 필드 (데이터)
        private int width;
        private int height;
        private int depth;
        private Color color;

        // 생성자 (Constructor)
        public Brick()
        {
            width = 10;
            height = 10;
            depth = 5;
            color = Color.Red;
        }

        public Brick(int width, int height, int depth, Color color)
        {
            this.width = width;
            this.height = height;
            this.depth = depth;
            this.color = color;
        }

        // 속성 (Property)
        public int Width
        {
            get { return this.width; }
            set
            {
                if(value > 0)
                {
                    this.width = value;
                }
            }
        }
        public Color Color
        {
            get { return this.color; }
        }

        public int Volume
        {
            get { return width * height * depth; }
        }
        
        // 메서드 (Method)
        public void MakeBrick()
        {
            // Event Fire
            if (ProcessStarted != null)
            {
                ProcessStarted(this, EventArgs.Empty);
            }
            Step1();
            Step2();
            Step3();

            if(ProcessCompleted != null)
            {
                ProcessCompleted(this, EventArgs.Empty);
            }
        }

        private void Step1()
        {
            Console.WriteLine("Step #1");
        }
        private void Step2()
        {
            Console.WriteLine("Step #2");
        }
        private void Step3()
        {
            Console.WriteLine("Step #3");
        }

        // 이벤트 (Event)
        public event EventHandler ProcessStarted;
        public event EventHandler ProcessCompleted;
    }
}
