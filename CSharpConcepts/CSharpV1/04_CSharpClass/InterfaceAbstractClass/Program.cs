using System;

namespace InterfaceAbstractClass
{
    internal class Program
    {
        private static void Main()
        {
            Vehicle v = new Car();
            v.Run();
        }
    }

    internal interface IVehicle
    {
        void Stop();
        void Fill();
        void Run();
    }

    internal abstract class Vehicle:IVehicle
    {
        public void Stop()
        {
            Console.WriteLine("Stopped");
        }
        public void Fill()
        {
            Console.WriteLine("Filled");
        }

        public abstract void Run();
    }

    internal class Car:Vehicle
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
