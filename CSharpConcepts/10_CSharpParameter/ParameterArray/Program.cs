using System;
using System.Linq;

namespace ParameterArray
{
    internal class Program
    {
        private static void Main()
        {
            Console.WriteLine(CalculateSum(1, 2, 3));

            const string str = "Tim;Tom,Amy.Lisa";
            var result = str.Split(';', '.', ',');
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }

        private static int CalculateSum(params int[] intArray)
        {
            return intArray.Sum();
        }
    }
}
