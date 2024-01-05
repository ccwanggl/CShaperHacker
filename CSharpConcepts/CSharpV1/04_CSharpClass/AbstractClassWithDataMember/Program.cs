using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassWithDataMember
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            MyClass mc = new MyClass();
            mc.PrintStuff("This is a string.");
            mc.MyInt = 28;
            Console.WriteLine(mc.MyInt);
            Console.WriteLine($"Perimeter Length: {mc.PerimeterLength()}");
        }
    }

    internal abstract class MyBase
    {
        public int SideLength = 10;
        private const int TriangleSideCount = 3;

        public abstract void PrintStuff(string s);
        public abstract int MyInt { get; set; }

        public int PerimeterLength()
        {
            return TriangleSideCount * SideLength;
        }
    }

    internal class MyClass : MyBase
    {
        public override void PrintStuff(string s)
        {
            Console.WriteLine(s);
        }

        private int _myInt;

        public override int MyInt {
            get { return _myInt; }
            set { _myInt = value; }
        }
    }
}
