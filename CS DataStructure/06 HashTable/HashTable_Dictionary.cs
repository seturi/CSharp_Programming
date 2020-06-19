using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _06_HashTable
{
    class HashTable_Dictionary
    {
        // 1. Hashtable 클래스
        public void HashTable()
        {
            Hashtable ht = new Hashtable();
            ht.Add("irina", "Irina SP");
            ht.Add("tom", "Tom Cr");

            if (ht.Contains("tom"))
            {
                Console.WriteLine(ht["tom"]);
            }
        }

        // 2. Dictionary<Tkey,TValue> 클래스
        public void Dictionary()
        {
            Dictionary<int, string> emp = new Dictionary<int, string>();
            emp.Add(1001, "Jane");
            emp.Add(1002, "Tom");
            emp.Add(1003, "Cindy");

            string name = emp[1002];
            Console.WriteLine(name);
        }


        // 3. ConcurrentDictionary<Tkey,TValue> 클래스 
        public void ConcurrentDict()
        {
            var dict = new ConcurrentDictionary<int, string>();

            Task t1 = Task.Factory.StartNew(() =>
            {
                int key = 1;
                while (key <= 100)
                {
                    if (dict.TryAdd(key, "D" + key))
                    {
                        key++;
                    }
                    Thread.Sleep(100);
                }
            });

            Task t2 = Task.Factory.StartNew(() =>
            {
                int key = 1;
                string val;
                while (key <= 100)
                {
                    if (dict.TryGetValue(key, out val))
                    {
                        Console.WriteLine("{0},{1}", key, val);
                        key++;
                    }
                    Thread.Sleep(100);
                }
            });

            Task.WaitAll(t1, t2);
        }
    }
}
