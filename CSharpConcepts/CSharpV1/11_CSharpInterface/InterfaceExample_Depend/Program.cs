using System;

namespace InterfaceExample_Depend
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var engine = new Engine();
            var car = new Car(engine);

            car.Run(3);
            Console.WriteLine(car.Speed);
        }
    }


    class Engine
    {
        public int RPM { 
            get; 
            private set; 
        }

        public void Work (int gas)
        {
            this.RPM = 1000 * gas;
        }
    }


    class Car
    {
        //note(guoliang):此处之后，两个类已经紧密耦合在了一起了
        private Engine _engine;
        public Car(Engine engine)
        {
            _engine = engine;
        }
        
        public int Speed {
            get;
            private set;
        }

        public void Run(int gas)
        {
            _engine.Work(gas);
            this.Speed = _engine.RPM / 100;
        }
    }
}
