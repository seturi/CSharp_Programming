using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_ArrayTest
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1부터 100까지를 변수에 저장
            int[] n = new int[100];
            for (int i = 0; i < n.Length; i++)
            {
                n[i] = i + 1;
            }

            int x = n[10];

            // 배열을 함수(메서드)에 전달
            PrintArray(n);

            // Boolean 배열
            bool[] boo = new bool[100];
            // stirng 배열
            string[] str = new string[100];
        }
        static void PrintArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}
