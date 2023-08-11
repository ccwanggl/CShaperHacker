using System;

namespace OverrideInClass
{
    internal class Program
    {
        private static void Main()
        {
            Type t = typeof(Car);
            Type tb = t.BaseType;
            Type tTop = tb?.BaseType;

            if (tTop != null)
            {
                Console.WriteLine(tTop.FullName);
            }

            Car v = new Car();
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
