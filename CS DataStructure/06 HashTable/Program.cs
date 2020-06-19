using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_HashTable
{
    // HashTable 구현
    public class SimpleHashTable
    {
        private const int INITIAL_SIZE = 16;
        private int size;
        private Node[] buckets;

        public SimpleHashTable()
        {
            this.size = INITIAL_SIZE;
            this.buckets = new Node[size];
        }

        public SimpleHashTable(int capacity)
        {
            this.size = capacity;
            this.buckets = new Node[size];
        }

        public void Put(object key, object value)
        {
            int index = HashFunction(key);
            if (buckets[index] == null)
            {
                buckets[index] = new Node(key, value);
            }
            else
            {
                Node newNode = new Node(key, value);
                newNode.Next = buckets[index];
                buckets[index] = newNode;
            }
        }

        public object Get(object key)
        {
            int index = HashFunction(key);

            if (buckets[index] != null)
            {
                for (Node n = buckets[index]; n != null; n = n.Next)
                {
                    if (n.Key == key)
                    {
                        return n.Value;
                    }
                }
            }
            return null;
        }

        public bool Contains(object key)
        {
            int index = HashFunction(key);
            if (buckets[index] != null)
            {
                for (Node n = buckets[index]; n != null; n = n.Next)
                {
                    if (n.Key == key)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        protected virtual int HashFunction(object key)
        {
            return Math.Abs(key.GetHashCode() + 1 +
                (((key.GetHashCode() >> 5) + 1) % (size))) % size;
        }

        private class Node
        {
            public object Key { get; set; }
            public object Value { get; set; }
            public Node Next { get; set; }

            public Node(object key, object value)
            {
                this.Key = key;
                this.Value = value;
                this.Next = null;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Chaining 테스트를 위해 
            // capacity를 1로 셋팅할 수 있음            
            //SimpleHashTable ht = new SimpleHashTable(1);

            SimpleHashTable ht = new SimpleHashTable();
            ht.Put("Kim D", "Sales 01");
            ht.Put("Lee K", "Sales 02");
            ht.Put("Park S", "IT 03");
            ht.Put("Shin O", "IT 04");

            Console.WriteLine(ht.Get("Lee K"));
            Console.WriteLine(ht.Get("Shin O"));
            Console.WriteLine(ht.Contains("Unknown"));
        }
    }
}
