using System;

namespace _05_CS8Index
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "Hello World!";

            char ch = s[0]; // H
            ch = s[1];  // e
            ch = s[^1]; // !
            ch = s[^2]; // d

            Index a = ^2;
            ch = s[a];

            Range r1 = 1..4;    // ell
            Range r2 = ^6..^1;  // Wordl
            string s1 = s[r1];
            string s2 = s[r2];
            string s3 = s[1..^0];    // ello World!

            var x = s[..];


            int[] b = { 1, 2, 3, 4, 5 };
            var result = b[1..^1];
            foreach(var item in result)
            {
                Console.WriteLine(item);
            }
        }
    }
}
