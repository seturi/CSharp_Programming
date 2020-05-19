using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_GenericTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var iCalc = new Calculator<int>();
            var x = iCalc.Add(1, 2);

            var dCalc = new Calculator<double>();
            var y = dCalc.Add(1.0, 3.14);

            List<string> nameList = new List<string>();
            nameList.Add("홍길동");

            List<int> intList = new List<int>();
            intList.Add(100);

            Dictionary<string, int> scores = new Dictionary<string, int>();
            scores.Add("홍길동", 100);
        }
    }
}
