using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_LoopTest
{
    class Program
    {
        static void Main(string[] args)
        {
            // while 루프

            int i = 1;
            while (i <= 10)
            {
                Console.WriteLine(i);
                i++;
            }

            // for 루프

            for (int j = 1; j <= 10; j++)
            {
                Console.WriteLine(i);
            }

            // foreach 루프

            string[] cities = new string[] { "Seattle", "Paris", "London" };
            foreach (string s in cities)
            {
                Console.WriteLine(s);
            }

            // do ~ while 루프
            string menu;
            do
            {
                Console.WriteLine("Select City: (S)eattle (P)aris (L)ondon (Q)uit");
                menu = Console.ReadLine();
                Console.WriteLine(menu + "is selected.");
            } while (menu != "Q");

            // continue, break
            int n = 1;
            int sum = 0;
            while (n <= 100)
            {
                if (n % 11 == 0)
                {
                    n++;
                    //continue;
                    break;
                }
                sum += n;
                n++;
            }
        }
    }
}
