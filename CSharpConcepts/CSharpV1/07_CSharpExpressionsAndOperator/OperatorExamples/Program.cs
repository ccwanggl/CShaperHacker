using System;
using System.Reflection;

namespace OperatorExample
{
    class SomeClass
    {
        public int Field1;
        public int Field2;

        public void Method1() { }
        public int Method2() { return 1; }
    }

    class Program
    {
        static void Main()
        {
            Type t = typeof(int);

            Console.WriteLine(t.Namespace);
            Console.WriteLine(t.FullName);
            Console.WriteLine(t.Name);

            int c = t.GetMembers().Length;
            foreach (var item in t.GetMethods())
            {
                Console.WriteLine(item.Name);
            }


            Type t2 = typeof(SomeClass);
            FieldInfo[] fi = t2.GetFields();
            MethodInfo[] mi = t2.GetMethods();

            foreach(FieldInfo f in fi)
            {
                Console.WriteLine($"Field : {f.Name}");
            }
            foreach(MethodInfo f in mi)
            {
                Console.WriteLine($"Method: {f.Name}");
            }
        }
    }
}
