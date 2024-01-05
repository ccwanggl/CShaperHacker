using System;

namespace OverrideInClass
{
    internal class Vehicle
    {
        // NOTE: base
        public virtual void Run()
        {
            Console.WriteLine("I'm running!"); 
        }
    }

    internal class Car : Vehicle
    {
        // NOTE: extend
        public override void Run()
        {
            Console.WriteLine("Car is Running!");
        }
    }

    internal class RaseCar : Car
    {
        // NOTE: hide
        public new void Run()
        {
            Console.WriteLine("Rase car is running");
        }
    }
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

            RaseCar v = new RaseCar();
            v.Run();
            Vehicle vehicle = (Vehicle)v;
            vehicle.Run();
        }
    }

}
