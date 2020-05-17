using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_ClassTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Brick br = new Brick();
            Brick br2 = new Brick(50, 100, 20, Color.Gray);

            int w = br2.Width;
            br2.Width = -1;
            Color c = br2.Color;
            int v = br2.Volume;

            br2.ProcessStarted += Br2_ProcessStarted;
            br2.ProcessCompleted += Br2_ProcessCompleted;
            br2.MakeBrick();
        }

        private static void Br2_ProcessStarted(object sender, EventArgs e)
        {
            Console.WriteLine("Process Started");
        }
        private static void Br2_ProcessCompleted(object sender, EventArgs e)
        {
            Console.WriteLine("Process Completed");
        }
    }
}
