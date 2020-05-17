using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_DataTypeTest
{
    class Program
    {
        static void Main(string[] args)
        {
            bool b = true;

            short sh = 100;
            int ii = 100;
            long l = 10000L;         // signed integer
            ushort us = 111;
            uint ui = 0U;
            ulong ul = 10000UL;

            float f = 3.14f;        // 32bit
            double d = 3.141592d;   // 64bit
            decimal dd = 3.14m;     // 128bit

            char ch = '한';  // 16bit Unicode

            byte by = 0x46; // 8bit

            int? ix = 123;

            string s = null;
            object o = null;
        }
    }
}
