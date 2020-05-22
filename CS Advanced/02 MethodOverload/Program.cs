using System;

namespace _02_MethodOverload
{
    class Calculator
    {
        public double Result { get; protected set; }

        //public void Add(int a, int b)
        //{
        //    Result = a + b;
        //}

        //public void Add(double a, double b)
        //{
        //    Result = a + b;
        //}

        public string Change(int a)
        {
            return a.ToString();
        }

        public char[] Change(double a)
        {
            string s = a.ToString();
            return s.ToCharArray();
        }

        public void Print(int a, int b = 10)
        {
            Console.WriteLine($"{a}, {b}");
        }

        public void Print(int a)
        {
            Console.WriteLine(a);
        }

        public void PrintValue(int a)
        {
            Console.WriteLine(a);
        }

        public void PrintValue(double b)
        {
            Console.WriteLine(b);
        }

        public virtual void Add(int a, int b)
        {
            Result = a + b;
        }
    }

    class MyCalculator : Calculator
    {
        public override void Add(int a, int b)
        {
            Result = a + b;
        }

        public void Add(double a, double b)
        {
            Result = a + b;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var c = new Calculator();
            //c.Add(1, 2);
            //char[] a = c.Change(1);
            //c.Print(1);  // Print(int a)
            //c.PrintValue(b: 1);

            MyCalculator mc = new MyCalculator();
            mc.Add(1, 2);
        }
    }
}
