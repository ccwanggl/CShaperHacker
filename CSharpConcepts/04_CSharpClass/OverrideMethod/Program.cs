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
        virtual public int MyProperty
        {
            get { return _myInt; }
        }

        public virtual void Print()
        {
            Console.WriteLine("This is the base class");
        }
    }

    class MyDerivedClass : MyBaseClass
    {
        public int var1;
        private int _myInt = 20;
        public override int MyProperty 
        {
            get { return _myInt; }
        }

        override public void Print()
        { 
            Console.WriteLine("This is the derived class.");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            MyDerivedClass derivedClass = new MyDerivedClass();
            MyBaseClass mybc =(MyBaseClass)derivedClass;

            derivedClass.Print();
            mybc.Print();

            Console.WriteLine(derivedClass.MyProperty);
            Console.WriteLine(mybc.MyProperty);
        }
    }
}
