using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_FileCopy
{
    class Program
    {
        static void Main(string[] args)
        {
            if(args.Length < 2)
            {
                Console.WriteLine("Usage: C> FileCopy srcfile destfile");
                return;
            }

            string srcfile = args[0];
            string destfile = args[1];

            File.Copy(srcfile, destfile);

            Console.WriteLine($"Copy {srcfile} to {destfile}");
        }
    }
}
