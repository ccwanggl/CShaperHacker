using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExample_Override
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var v = new Car();
            v.Run();
        }
    }

    class Vehicle
    {
        public virtual void Run()
        {
            Console.WriteLine("I'm running!"); 
        }
    }

    class Car : Vehicle
    {
        public override void Run()
        {
            Console.WriteLine("Car is Running!");
        }
    }

    class RaseCar : Car
    {
        public override void Run()
        {
            Console.WriteLine("Rase car is running");
        }
    }
}
