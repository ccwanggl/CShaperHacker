using System;

namespace ParameterScalAble
{
    internal class Program
    {
        private static void Main()
        {
            var x = 3.14159;
            var y = x.Round(4);
            Console.WriteLine(y);

        }
    }

    // NOTE: (guoliang): static 
    internal static class DoubleExtension
    {
        public static double Round(this double input, int digits)
        {
            var result = Math.Round(input, digits);
            return result;
        }

    }
}
