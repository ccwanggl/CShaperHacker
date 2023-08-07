using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BabyStroller.SDK;

namespace Animals.Lib
{
    internal class Sheep:IAnimal
    {
        public void Voice(int times)
        {
            for (int i = 0; i < times; i++)
            {
                Console.WriteLine("Baa...");
            }
        }
    }
}
