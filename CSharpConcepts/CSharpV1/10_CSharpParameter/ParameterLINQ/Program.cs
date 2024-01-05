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

            // NOTE: All is a extension method and accept a delegate type
            var result = list.All(i => i > 10);
            Console.WriteLine(result);
        }

        // NOTE: Old school
        static bool AllGreaterThanTen(List<int> list)
        {
            foreach (int i in list)
            {
                if (i < 10)
                    return false;
            }

            return true;
        }
    }
}
