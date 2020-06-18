using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _02_DynamicArray
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. ArrayList 클래스
            ArrayList arrList = new ArrayList();
            arrList.Add(90);
            arrList.Add(88);
            arrList.Add(75);

            // int로 casting
            int val1 = (int)arrList[1];
            Console.WriteLine(val1);
            Console.WriteLine("-------------------------------");

            // 2. List<T> 클래스
            List<int> myList = new List<int>();
            myList.Add(90);
            myList.Add(88);
            myList.Add(75);
            int val2 = myList[1];
            Console.WriteLine(val2);
            Console.WriteLine("-------------------------------");

            // 3. SortedList<TKey,TValue> 클래스
            SortedList<int, string> list = new SortedList<int, string>();
            list.Add(1001, "Tim");
            list.Add(1020, "Ted");
            list.Add(1010, "Kim");

            string name = list[1001];

            foreach (KeyValuePair<int, string> kv in list)
            {
                Console.WriteLine("{0}:{1}", kv.Key, kv.Value);
            }
            Console.WriteLine("-------------------------------");


            // 4. ConcurrentBag 클래스
            var bag = new ConcurrentBag<int>();

            // 데이타를 Bag에 넣는 쓰레드
            Task t1 = Task.Factory.StartNew(() =>
            {
                for (int i = 0; i < 100; i++)
                {
                    bag.Add(i);
                    Thread.Sleep(100);
                }
            });

            // Bag에서 데이타를 읽는 쓰레드
            Task t2 = Task.Factory.StartNew(() =>
            {
                int n = 1;
                // Bag 데이타 내용을 10번 출력함
                while (n <= 10)
                {
                    Console.WriteLine("{0} iteration", n);
                    int count = 0;

                    // Bag에서 데이타 읽기
                    foreach (int i in bag)
                    {
                        Console.WriteLine(i);
                        count++;
                    }
                    Console.WriteLine("Count={0}", count);

                    Thread.Sleep(1000);
                    n++;
                }
            });

            // 두 쓰레드가 끝날 때까지 대기
            Task.WaitAll(t1, t2);
            Console.WriteLine("-------------------------------");
        }
    }
}
