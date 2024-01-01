using System;
using System.Collections.Generic;

namespace GenericExample4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IDictionary<int,string> map = new Dictionary<int,string>();
            map[1] = "Guoliang";
            map[2] = "Mohan";

            Console.WriteLine($"Students #1 is {0}", map[1]);
            Console.WriteLine($"Students #2 is {0}", map[2]);
        }
    }
}
