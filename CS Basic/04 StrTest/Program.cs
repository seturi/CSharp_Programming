using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_StrTest
{
    class Program
    {
        static void Main(string[] args)
        {
            // 문자열(string)
            string s1 = "C#";
            string s2 = "Programming";

            // 문자(char)
            char c1 = 'a';
            char c2 = 'b';

            char c = s2[0]; // P

            // 문자열 결합
            string s = s1 + " " + s2;

            // 부분문자열
            string s4 = s2.Substring(1, 4); // rogr

            // 문자열 치환
            string s5 = s2.Replace("Pro", "PRO");
            // Console.WriteLine(s5);

            // 문자열 삭제
            string s6 = s2.Remove(3);   // Pro

            // 공백 삭제
            string s7 = "Hello         ".Trim();

            // 문자열을 문자배열로
            char[] arr = s.ToCharArray();
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }

            // 문자배열을 문자열로
            string ss = new string(arr);

            // 문자열(string) immutable type
            s1 = "F#";      // 다른 주소에 할당

            //for(int i = 0; i < 100000; i++)
            //{
            //    s = s + i.ToString();
            //}

            // mutable type
            int ii = 1;
            ii = 2;      // 같은 주소

            StringBuilder sb = new StringBuilder(); // mutable type
            for (int i = 0; i < 10000; i++)
            {
                sb.Append(i.ToString());
            }
            string result = sb.ToString();
        }
    }
}
