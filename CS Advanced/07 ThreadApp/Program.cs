using System;
using System.Threading;

namespace _07_ThreadApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var tm = new TableMaker();

            Thread[] t = new Thread[10];
            for (int i = 0; i < 10; i++)
            {
                t[i] = new Thread(new ThreadStart(tm.DoWork));
                t[i].Start();
            }
            
            for(int i = 0; i < 10; i++)
            {
                t[i].Join();
            }

            int total = tm.TotalCount;
            Console.WriteLine($"Total: {total}");
        }
    }
}
