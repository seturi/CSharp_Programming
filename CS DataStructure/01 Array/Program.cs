using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int[] nums = new int[10];

            Random rand = new Random();
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = rand.Next() % 100;
            }

            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
            }
            Console.WriteLine(sum);
        }
    }
}
