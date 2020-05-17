using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ConditionTest
{
    class Program
    {
        static void Main(string[] args)
        {
            // if 문

            int score = 95;
            if (score >= 90)
            {
                if (score == 100)
                {
                    Console.WriteLine("만점");
                }
                else
                {
                    Console.WriteLine("수");
                }
            }
            else if (score >= 80)
            {
                Console.WriteLine("우");
            }
            else if (score >= 70)
            {
                Console.WriteLine("미");
            }
            else if (score >= 60)
            {
                Console.WriteLine("양");
            }
            else
            {
                Console.WriteLine("가");
            }

            //int a = -1;
            //int b;
            //if(a > 0)
            //{
            //    b = a;
            //}
            //else
            //{
            //    b = 0;
            //}
            int a = -1;
            int b = (a > 0) ? a : 0;    // 조건 연산자

            // switch 문

            string option = args[0];
            switch (option)
            {
                case "/p":
                    Console.WriteLine("Phone");
                    break;
                case "/s":
                    Console.WriteLine("SMS");
                    break;
                case "/k":
                    Console.WriteLine("Kakao");
                    break;
                default:
                    Console.WriteLine("N/A");
                    break;

            }
        }
    }
}
