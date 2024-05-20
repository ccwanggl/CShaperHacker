using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverrideMethod
{
    class MyBaseClass
    {
        private int _myInt = 5;
        public int MyProperty
        {
            get { return _myInt; }
        }

        public void Print()
        {
            Console.WriteLine("This is the base class");
        }
    }

    class MyDerivedClass : MyBaseClass
    {
        private int _myInt = 20;
        new public int MyProperty 
        {
            get { return _myInt; }
        }

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

            Console.WriteLine(derivedClass.MyProperty);
            Console.WriteLine(mybc.MyProperty);
        }
    }
}
