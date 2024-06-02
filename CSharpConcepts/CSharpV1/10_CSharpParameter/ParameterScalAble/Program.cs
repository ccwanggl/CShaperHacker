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

    // NOTE:  must public and static class and static method, please notice the first param
	// note: 方法必须是公有，静态的 "public static"
    internal static class DoubleExtension
    {
        public static double Round(this double input, int digits)
        {
            var result = Math.Round(input, digits);
            return result;
        }

    }
}
