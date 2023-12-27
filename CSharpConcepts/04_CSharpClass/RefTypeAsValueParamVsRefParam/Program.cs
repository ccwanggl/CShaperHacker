using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefTypeAsValueParamVsRefParam
{
    class MyClass { public int val = 20; }
    internal class Program
    {
        static void RefAsParameter(MyClass f1)
        {
            f1.val = 50;
            Console.WriteLine($"After member assignment: {f1.val}");
            f1 = new MyClass();
            Console.WriteLine($"After new object creation: {f1.val}");
        }

        static void RefAsParameter(ref MyClass f1)
        {
            f1.val = 50;
            Console.WriteLine($"After member assignment: {f1.val}");
            f1 = new MyClass();
            Console.WriteLine($"After new object creation: {f1.val}");
        }

        static void Main(string[] args)
        {
            MyClass a1 = new MyClass();

            Console.WriteLine("=========== Ref type as value parameter ============== ");
            Console.WriteLine($"Before method call: {a1.val}");
            RefAsParameter(a1);
            Console.WriteLine($"After method call: {a1.val}");

            Console.WriteLine("=========== Ref type as ref parameter ============== ");
            a1.val = 20;
            Console.WriteLine($"Before method call: {a1.val}");
            RefAsParameter(ref a1);
            Console.WriteLine($"After method call: {a1.val}");
        }
    }
}
