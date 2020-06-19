using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _05_Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Stack 클래스
            Stack<double> s1 = new Stack<double>();
            s1.Push(10.5);
            s1.Push(3.54);
            s1.Push(4.22);

            double val = s1.Pop();

            // 2. ConcurrentStack 클래스
            var s2 = new ConcurrentStack<int>();

            // 데이타를 스택에 넣는 쓰레드
            Task tPush = Task.Factory.StartNew(() =>
            {
                for (int i = 0; i < 100; i++)
                {
                    s2.Push(i);
                    Thread.Sleep(100);
                }
            });

            // 데이타를 스택에서 읽는 쓰레드
            Task tPop = Task.Factory.StartNew(() =>
            {
                int n = 0;
                int result;
                while (n < 100)
                {
                    if (s2.TryPop(out result))
                    {
                        Console.WriteLine(result);
                        n++;
                    }
                    Thread.Sleep(150);
                }
            });

            // 두 쓰레드가 끝날 때까지 대기
            Task.WaitAll(tPush, tPop);

        }
    }
}
