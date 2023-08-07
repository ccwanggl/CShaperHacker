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
            Type t = typeof(Car);
            Type tb = t.BaseType;
            Type tTop = tb.BaseType;

            Console.WriteLine(tTop.FullName);


            var v = new Car();
            v.Run();
        }
    }

    internal class Vehicle
    {
        public virtual void Run()
        {
            Console.WriteLine("I'm running!"); 
        }
    }

    internal class Car : Vehicle
    {
        public override void Run()
        {
            Console.WriteLine("Car is Running!");
        }
    }

    internal class RaseCar : Car
    {
        public override void Run()
        {
            Console.WriteLine("Rase car is running");
        }
    }
}
