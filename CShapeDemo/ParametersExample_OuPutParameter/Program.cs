namespace ParametersExample_OuPutParameter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input the first number:"); 
            string arg1 = Console.ReadLine();
            double x = 0;

            if(double.TryParse(arg1 , out x))
            {
                Console.WriteLine("Input error!");
                return;
            }
            else
            {
                Console.WriteLine(x);
            }


            Console.WriteLine("Please input the second number:"); 
            string arg2 = Console.ReadLine();
            double y = 0;

            if(double.TryParse(arg2 , out y))
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

    class DoubleParser
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