using System;

namespace _01_ReferenceTest
{
    class MyData
    {
        public int Value;
    }

    class Program
    {
        static void Main(string[] args)
        {
            new Program().ReferenceRun();
        }

        unsafe void ReferenceRun()
        {
            for(int i = 0; i < 100000; i++)
            {
                var obj = new MyData();
            }

            var data = new MyData();
            data.Value = 55;

            fixed(int* p = &data.Value)
            {
                Console.WriteLine("Address: {0}", (int)p);
            }

            GC.Collect();
            fixed (int* p = &data.Value)
            {
                Console.WriteLine("Address: {0}", (int)p);
            }

        }
    }
}
