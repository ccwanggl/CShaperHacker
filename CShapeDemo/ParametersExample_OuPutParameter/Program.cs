namespace ParametersExample_OuPutParameter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input first number:"); 
            string arg1 = Console.ReadLine();
            double x = 0;

            bool b1 = double.TryParse(arg1 , out x);
            if(b1 == false)
            {
                Console.WriteLine("Input error!");
                return;
            }
        }
    }
}