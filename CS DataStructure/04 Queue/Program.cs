using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _04_Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Queue 클래스
            Queue<int> q1 = new Queue<int>();
            q1.Enqueue(120);
            q1.Enqueue(130);
            q1.Enqueue(150);

            int next = q1.Dequeue(); // 120
            next = q1.Dequeue(); // 130

            // 2. ConcurrentQueue 클래스
            var q2 = new ConcurrentQueue<int>();

            // 데이타를 큐에 넣는 쓰레드
            Task tEnq = Task.Factory.StartNew(() =>
            {
                for (int i = 0; i < 100; i++)
                {
                    q2.Enqueue(i);
                    Thread.Sleep(100);
                }
            });

            // 데이타를 큐에서 읽는 쓰레드
            Task tDeq = Task.Factory.StartNew(() =>
            {
                int n = 0;
                int result;
                while (n < 100)
                {
                    if (q2.TryDequeue(out result))
                    {
                        Console.WriteLine(result);
                        n++;
                    }
                    Thread.Sleep(100);
                }
            });

            // 두 쓰레드가 끝날 때까지 대기
            Task.WaitAll(tEnq, tDeq);
        }
    }
}
