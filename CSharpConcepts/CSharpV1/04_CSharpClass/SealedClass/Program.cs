using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SealedClass
{
    //! same as the c++ "final" keyword
    internal class Program
    {
        private static void Main(string[] args)
        {
            MyClass mc = new MyClass();
            mc.PrintHello();
        }
    }

    internal sealed class MyClass
    {
        public void PrintHello()
        {
            Console.WriteLine("Hello sealed class.");
        }
    }

}
