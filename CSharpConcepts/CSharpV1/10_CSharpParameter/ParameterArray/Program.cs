using System;
using System.Linq;

namespace ParameterArray
{
    // only one param array allowed
    // must at the last position
    // 
    internal class Program
    {
        private static void Main()
        {
            // NOTE: Do not need to define a array object
            Console.WriteLine(CalculateSum(1, 2, 3));

            const string str = "Tim;Tom,Amy.Lisa";
            var result = str.Split(';', '.', ',');
            Console.WriteLine(result.GetType().FullName);
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }

        // NOTE: 'params' must at the last of the param list
        private static int CalculateSum(params int[] intArray)
        {
            Console.WriteLine(intArray.GetType().FullName);
            if ((intArray == null) || (intArray.Length == 0))
                return 0;

            return intArray.Sum();
        }
    }
}
