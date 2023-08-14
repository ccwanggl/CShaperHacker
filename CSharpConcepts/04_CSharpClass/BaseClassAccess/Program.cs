using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseClassAccess
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Derived oc = new Derived();
            oc.PrintField1();
        }
    }

    internal class Base
    {
        public string Field1 = "Field1 -- In the base class";
    }

    internal class Derived : Base
    {
        public new string Field1 = "Field1 -- In the derived class";

        public void PrintField1()
        {
            Console.WriteLine(Field1);
            Console.WriteLine(base.Field1);
        }
    }
}
