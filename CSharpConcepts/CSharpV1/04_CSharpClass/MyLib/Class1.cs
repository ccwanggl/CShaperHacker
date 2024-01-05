using System;

namespace MyLib
{
    public class Vehicle
    {
        protected int _rpm;
        private int _fuel;


        public void Refuel()
        {
            _fuel = 100;
        }

        protected void Burn()
        {
            _fuel--;
        }

        public void Accelerate()
        {
            Burn();
            _rpm += 1000;
        }
        public int Speed {  get { return _rpm/100; } }
    }

    public class Car:Vehicle 
    { 
        public void TurboAccelerate()
        {
            Burn();
            Burn();
            _rpm += 3000;
        }
    }
}
