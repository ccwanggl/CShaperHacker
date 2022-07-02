namespace OperatorExample_negitive
{
    internal class Program
    {
        static void Main(string[] args)
        {
            uint x = uint.MaxValue;
            Console.WriteLine(x);
            string binStr = Convert.ToString(x, 2);
            Console.WriteLine(binStr);

            unchecked
            {
                try
                {
                    uint y = x + 1;
                    Console.WriteLine(y);
                }
                catch (OverflowException)
                {
                    Console.WriteLine("There's overflow!");
                }
            }

            checked
            {
                try
                {
                    uint y = x + 1;
                    Console.WriteLine(y);
                }
                catch (OverflowException)
                {
                    Console.WriteLine("checked: There's overflow!");
                }
            }
        }
    }
}