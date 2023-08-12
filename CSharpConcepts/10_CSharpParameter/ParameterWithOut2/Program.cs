using System;

namespace ParameterWithOut2
{
    internal class Program
    {
        private static void Main()
        {
            Console.WriteLine("Please input the first number:"); 
            var arg1 = Console.ReadLine();

            if(double.TryParse(arg1 , out var x))
            {
                Console.WriteLine("Input error!");
                return;
            }
            else
            {
                Console.WriteLine(x);
            }


            Console.WriteLine("Please input the second number:"); 
            var arg2 = Console.ReadLine();

            if(double.TryParse(arg2 , out var y))
            {
                Console.WriteLine("Input error!");
                return;
            }
            else
            {
                Console.WriteLine(y);
            }
        }
    }

    internal class DoubleParser
    {
        public static bool TryParse(string input, out double result)
        {
            try
            {
                result = double.Parse(input);
                return true;
            }
            catch 
            {

                result = 0; 
                return false;
            }
        }
    }
}
