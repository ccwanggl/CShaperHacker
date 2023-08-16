using System;

namespace AbstractClass
{
    internal class Program
    {
        private static void Main()
        {
            DerivedClass b = new DerivedClass();
            b.IdentifyBase();
            b.IdentifyDerived();
        }
    }

    internal abstract class AbClass
    {
        public void IdentifyBase()
        {
            Console.WriteLine("I am AbClass");
        }

        // NOTE: (guoliang) Some function in base class will ever be called
        public abstract void IdentifyDerived();
    }

    internal class DerivedClass : AbClass
    {
        public override void IdentifyDerived()
        {
            Console.WriteLine("I am DerivedClass");
        }
    }
}
