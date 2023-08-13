using System;

namespace ParameterNamedParam
{
    internal class Program
    {
        private static void Main()
        {
            PrintInfo("guoliang", 34);
            PrintInfo(name: "Mohan", age: 33);
            PrintInfo(age: 33, name: "Mohan");
        }

        private static void PrintInfo(string name, int age)
        {
            Console.WriteLine("Hello {0}, you are {1}", name,age);
        }
    }
}
