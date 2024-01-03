using System;

namespace Checked
{
    internal class Program
    {
        private static void Main()
        {
            var x = uint.MaxValue;
            Console.WriteLine(x);
            var binStr = Convert.ToString(x,2);
            Console.WriteLine(binStr);

            // NOTE: Method 1 
            {
                try
                {
                    uint y = checked(x + 1);
                    Console.WriteLine(y);
                }
                catch (OverflowException ex)
                {
                    Console.WriteLine("Method 1: There are overflow!");
                    throw;
                }
            }

            // NOTE: Method 2
            {
                checked
                {
                    try
                    {
                        uint y = x + 1;
                        Console.WriteLine(y);
                    }
                    catch (OverflowException ex)
                    {
                        Console.WriteLine("Method 1: There are overflow!");
                        throw;
                    }

                }
            }
        }
    }


}
