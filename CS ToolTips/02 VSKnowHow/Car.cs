using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_VSKnowHow
{
    public class Car : ICar
    {
        private string name;
        private string maker;
        private int speed;

        public Car()
        {

        }

        public int Speed
        {
            get { return speed; }
        }

        public void Start()
        {
            speed = 0;
            Console.WriteLine("운전시작");
        }

        public void Drive()
        {
            speed += 5;
            Console.WriteLine("운전");
        }

        public void Stop()
        {
            speed = 0;
            Console.WriteLine("정지");
        }
    }
}
