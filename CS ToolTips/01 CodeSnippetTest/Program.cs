using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_CodeSnippetTest
{
    class Program
    {
        static void Main(string[] args)                         // svm
        {

            if (true)       // 코드 감싸기
            {
                Console.WriteLine();                            // cw 
            }

            for (int j = 0; j < 10; j++)                        // for
            {

            }

            foreach (var item in Enumerable.Range(1, 10))       // foreach
            {
                Console.WriteLine(item);
            }

            // try tryf if switch ...


            // Snippet Designer
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Hello");
            Console.WriteLine("World");
            Console.WriteLine();

        }

        class Person
        {
            public Person()                         // ctor
            {

            }

            public string Name { get; set; }        // prop

            private int myVar;

            public int MyProperty                   // propfull
            {
                get { return myVar; }
                set { myVar = value; }
            }

            public object this[int index]           // indexer
            {
                get { return index; /* return the specified index here */ }
                set { /* set the specified index to value here */ }
            }
        } 
    }
}
