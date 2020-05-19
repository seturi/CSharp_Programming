using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_StaticTest
{
    class Program
    {
        static void Main(string[] args)
        {
            StaticRun();
            new Program().InstanceRun();

            int[] nums = { 1, 2, 3, 4, 5 };
            int sum = MyCalc.Sum(nums);
            double avg = MyCalc.Avg(nums);

            int cnt = MyCalc.NextCount;
            Console.WriteLine(cnt); // 1
            cnt = MyCalc.NextCount;
            Console.WriteLine(cnt); // 2

            MyCalc calcObj = new MyCalc();

        }

        static void StaticRun() { }
        void InstanceRun() { }
    }
}
