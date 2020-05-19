using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _04_StaticTest
{
    class MyCalc
    {
        // static method
        public static int Sum(int[] numbers)
        {
            int sum = 0;
            foreach (var n in numbers)
            {
                sum += n;
            }
            return sum;
        }

        public static double Avg(int[] numbers)
        {
            double avg = Sum(numbers) / (double)numbers.Count();
            return avg;
        }

        private static int counter;

        static MyCalc()
        {
            counter = 0;
            // ...
        }

        public static int NextCount
        {
            get
            {
                return Interlocked.Increment(ref counter);
            }
        }
    }
}
