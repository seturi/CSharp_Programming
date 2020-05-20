using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_ExtensionMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 124;
            //bool b = MyUtility.IsEven(a);
            bool b = a.IsEven();
            b = 100.IsEven();

            string s = "ABC";
            string s2 = s.DashAppend("DEF");

            Calc c = new Calc();
            int res = c.Modulo(5, 3);

            // interface 확장 메서드
            var list = new List<string> { "Alexa", "Pane", "Jane", "Alex" };
            var aNames = list.Where(p => p.StartsWith("A"));
        }
    }
}
