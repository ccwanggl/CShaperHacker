using System;

namespace ParameterDefault
{
    internal class Program
    {
        private static void Main()
        {
            PrintInfo();
        }

        private static void PrintInfo(string name= "guoliang", int age = 32)
        {
            Console.WriteLine(name + " : " + age);
        }
    }
}
