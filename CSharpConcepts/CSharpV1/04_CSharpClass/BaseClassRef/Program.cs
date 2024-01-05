using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace BaseClassRef
{
    class MyBaseClass
    {
        public void Print()
        {
            Console.WriteLine("This is the base class");
        }
    }

    class MyDerivedClass : MyBaseClass
    {
        public int var1; 
        new public void Print()
        { 
            Console.WriteLine("This is the derived class.");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            MyDerivedClass derivedClass = new MyDerivedClass();
            MyBaseClass mybc = (MyBaseClass)derivedClass;

            derivedClass.Print();
            mybc.Print();
        }
    }

}
