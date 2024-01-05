using System;

namespace ParameterPassWithRef3
{
    internal class Program
    {
        private static void Main()
        {
            var y = 1;
            WantSideEffect(ref y);
            Console.WriteLine(y); 
        }

        private static void WantSideEffect(ref int x)
        {
            x += 100;
        }
    }
}
