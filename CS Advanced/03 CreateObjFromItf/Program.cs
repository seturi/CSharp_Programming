using System;
using System.Runtime.InteropServices;

namespace _03_CreateObjFromItf
{
    class Program
    {
        static void Main(string[] args)
        {
            ICar c = new ICar();
            c.Drive();
        }
    }
    [CoClass(typeof(Car))]
    [ComImport]
    [Guid("CE1436D3-2716-46AB-AFA5-382CD283DED4")]
    interface ICar
    {
        void Drive();
    }

    class Car : ICar
    {
        public void Drive()
        {
            System.Console.WriteLine();
        }
    }
}
