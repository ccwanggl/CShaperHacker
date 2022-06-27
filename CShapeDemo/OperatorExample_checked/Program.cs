namespace OperatorExample_checked
{
    internal class Program
    {
        static void Main(string[] args)
        {
            uint x = uint.MaxValue;
            Console.WriteLine(x);
            string binStr = Convert.ToString(x,2);
            Console.WriteLine(binStr);

            // Method 1
            /*
            try
            {
                uint y = checked(x + 1);
                Console.WriteLine(y);
            }
            catch (OverflowException ex)
            {
                Console.WriteLine("There're overflow!");
                throw;
            }
            */


            // Method 2
            checked
            {
                try
                {
                    uint y = x + 1;
                    Console.WriteLine(y);
                }
                catch (OverflowException ex)
                {
                    Console.WriteLine("There're overflow!");
                    throw;
                }

            }
        }
    }


}