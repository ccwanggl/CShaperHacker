using System;
using System.Collections.Generic;
using System.Linq;

namespace ParameterLINQ
{
    internal class Program
    {
        private static void Main()
        {
            List<int> list = new List<int>() { 11,23,44,45};

            var result = list.All(i => i > 10);
            Console.WriteLine(result);
        }
    }
}
