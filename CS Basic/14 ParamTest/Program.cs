using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_ParamTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var calc = new Calculator();

            int a = 5;
            int b = 10;
            // C# ref
            calc.Double(a, ref b);

            Console.WriteLine("a={0}, b={1}, a, b");

            // C# out
            //int sum;
            //double avg;
            //calc.GetSumAndAvg(5, 15, out sum, out avg);
            //
            // C# 7.0
            calc.GetSumAndAvg(5, 15, out var sum, out _);

            // C# params : 가변 파라미터
            int s = calc.Sum(1);
            s = calc.Sum(1, 2);
            s = calc.Sum(1, 2, 3, 4, 5);
            s = calc.Sum();

            // Named Parameter, Optional Parameter
            var st = new StudentList();
            st.AddStudent("Tim", "111-2222", 10);
            st.AddStudent("Tim", "111-2222");
            st.AddStudent(name: "Tim", age: 10, phone: "111-2222");
        }
    }

    class Calculator
    {
        public void Double(int a, ref int b)
        {
            a *= 2;
            b *= 2;
        }

        public bool GetSumAndAvg(int a, int b, out int sum, out double avg)
        {
            sum = a + b;
            avg = sum / 2;
            return true;
        }

        public int Sum(params int[] values)
        {
            int sum = 0;
            foreach(var v in values)
            {
                sum += v;
            }
            return sum;
        }
    }
    
    class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Phone { get; set; }
    }

    class StudentList
    {
        private List<Student> students = new List<Student>();

        public void AddStudent(string name, string phone, int age = 0)
        {
            var s = new Student();
            s.Name = name;
            s.Age = age;
            s.Phone = phone;
            students.Add(s);
        }
    }
}
