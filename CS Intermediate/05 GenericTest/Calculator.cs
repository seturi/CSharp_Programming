using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_GenericTest
{
    class BaseClass { }
    class MyClass<T, U>
        where T : BaseClass
        where U : IComparable
    {

    }

    class Calculator<T> where T : struct
    {

        public T Add(T a, T b)
        {
            dynamic da = a;
            dynamic db = b;
            T result = da + db;
            return result;
        }
        public T Subtract(T a, T b)
        {
            dynamic da = a;
            dynamic db = b;
            T result = da - db;
            return result;
        }
        public T Multiply(T a, T b)
        {
            dynamic da = a;
            dynamic db = b;
            T result = da * db;
            return result;
        }
        public T Divide(T a, T b)
        {
            dynamic da = a;
            dynamic db = b;
            T result = da / db;
            return result;
        }
    }
}
