namespace ClassExample_Abract_Class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vehicle v = new RaceCar();
            v.Run();
        }
    }

    abstract class Vehicle
    {
        public void Stop()
        {
            Console.WriteLine("Stopped");
        }


        //note(guoliang): Some function in base class will ever be called
        public abstract void Run();
    }

    class Car : Vehicle
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