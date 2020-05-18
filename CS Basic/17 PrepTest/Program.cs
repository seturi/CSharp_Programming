#undef DEBUG
using System;

namespace _17_PrepTest
{
    class Program
    {
        static void Main(string[] args)
        {
            bool verbose = false;

#if(DEBUG)
            Console.WriteLine("Test Environment: Verbosse option is set.");
            verbose = true;
#else
            Console.WriteLine("Production");
#endif
            if (verbose)
            {
                Console.WriteLine("Verbose mode");
            }
        }
    }
}
