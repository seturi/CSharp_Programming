using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_ExtensionMethod
{
    // 3rd Party Class that cannot modify
    public sealed class Calc
    {
        int Add(int a, int b) { return a + b; }
        int Subtract(int a, int b) { return a - b; }
        int Multiply(int a, int b) { return a * b; }
        int Divide(int a, int b) { return a / b; }
    }
}
