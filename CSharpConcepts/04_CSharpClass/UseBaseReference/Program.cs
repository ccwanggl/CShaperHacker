using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UseBaseReference
{
    internal class Program
    {
        public static void Main()
        {
            Derived derived = new Derived();
            Base mybc = derived;

            derived.Print();
            mybc.Print();
        }
    }

    internal class Base
    {
        public void Print()
        {
            Console.WriteLine("This is the base class.");
        }
    }

    internal class Derived : Base
    {
        public new void Print()
        {
            Console.WriteLine("This is the derived class.");
        }
    }
}
