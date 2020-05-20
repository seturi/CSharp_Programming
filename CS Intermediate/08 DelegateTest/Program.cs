﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_DelegateTest
{
    class Program
    {
        static void Main(string[] args)
        {
            new Program().TestCode();
        }

        void TestCode()
        {
            var addOp = new CalcDelegate(Add);
            Calc(6, 3, addOp);
            Calc(6, 3, Subtract);
            Calc(6, 3, Power);
        }

        delegate int CalcDelegate(int a, int b);

        void Calc(int a, int b, CalcDelegate calc)
        {
            int res = calc(a, b);
            Console.WriteLine("사용함수 : {0}", calc.Method);
            Console.WriteLine($"f({a}, {b}) = {res}");
        }

        #region delegate 타입에 맞는 메서드들
        int Add(int a, int b)
        {
            return a + b;
        }
        int Subtract(int a, int b)
        {
            return a - b;
        }
        int Multiply(int a, int b)
        {
            return a * b;
        }
        int Divide(int a, int b)
        {
            return a / b;
        }
        int Mod(int a, int b)
        {
            return a % b;
        }
        int Power(int a, int b)
        {
            int r = 1;
            for(int i = 0; i < b; i++)
            {
                r *= a;
            }
            return r;
        }
        #endregion
    }
}
