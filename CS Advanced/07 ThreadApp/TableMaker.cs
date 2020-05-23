using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading;

namespace _07_ThreadApp
{
    class TableMaker
    {
        private int totalCount = 0;
        public int TotalCount => totalCount;
        private object lockObj = new object();

        public void DoWork()
        {
            int count = 0;
            int threadId = Thread.CurrentThread.ManagedThreadId;

            while(count < 10)   // 100
            {
                // 테이블 만들기
                // ... 
                Thread.Sleep(1000);
                count = count + 1;

                lock (lockObj)
                {
                    totalCount = totalCount + 1;
                }
            }
            Console.WriteLine($"{threadId} : {count}");
        }
    }
}
