namespace ClassExample_Interface_from_Abstract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vehicle v = new Car();
            v.Run();
        }
    }

    interface IVehicle
    {
        void Stop();
        void Fill();
        void Run();
    }

    abstract class Vehicle:IVehicle
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

    class Car:Vehicle
    {
        public override void Run()
        {
            Console.WriteLine("Car is running ...");
        }
    }

    class Truck:Vehicle
    {
        public override void Run()
        {
            Console.WriteLine("Truck is running ...");
        }
    }

    class RaceCar:Vehicle
    {
        public override void Run()
        {
            Console.WriteLine("RaceCar is running ...");
        }
    }
}