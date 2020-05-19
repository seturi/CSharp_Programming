using _02_ModLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_ModApp
{
    class Animal
    {
        private int id;
        protected string name;

        protected void Eat()
        {

        }
    }

    class Dog : Animal
    {
        public void CheckIdentity()
        {
            Console.WriteLine("{0}", name);

            // ..
            Eat();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Logger logger = new Logger();
            logger.LogSuccess("");

            string s = logger.LogDirectory;
        }
    }
}
