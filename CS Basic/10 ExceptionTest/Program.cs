using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_ExceptionTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Run();

            Console.WriteLine("Next Step");

        }

        static void Run()
        {
            try
            {
                int[] a = new int[10];

                for (int i = 0; i <= 10; i++)
                {
                    a[i] = i;
                    Console.WriteLine(a[i]);
                }

                var fs = File.Open("my.config", FileMode.Open);
                // ...
            }
            //catch (IndexOutOfRangeException ex)
            //{
            //    // ...
            //}
            //catch(FileNotFoundException ex)
            //{
            //    // ...
            //}
            catch (Exception ex)
            {
                Log(ex);
                //throw;
                //throw ex;
                throw new ApplicationException(ex.Message, ex);
            }
        }

        static void Log(Exception ex)
        {
            // File, DB 로깅
        }
    }
}
