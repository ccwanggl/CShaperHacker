using System;

namespace AbstractMember
{
    internal class Program
    {
        private static void Main()
        {
            Vehicle v = new RaceCar();
            v.Run();
        }
    }

    internal abstract class Vehicle
    {
        public void Stop()
        {
            Console.WriteLine("Stopped");
        }


        // NOTE: (guoliang) Some function in base class will ever be called
        public abstract void Run();
    }

    internal class Car : Vehicle
    {
        public override void Run()
        {
            Console.WriteLine("Car is running ...");
        }
    }

    internal class Truck:Vehicle
    {
        public override void Run()
        {
            Console.WriteLine("Truck is running ...");
        }
    }

    internal class RaceCar:Vehicle
    {
        public override void Run()
        {
            Console.WriteLine("RaceCar is running ...");
        }
    }
}
