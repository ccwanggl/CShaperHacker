namespace GeneralExample_format_string
{
    internal class Program
    {
        //note(guoliang): In the complicated case, use the var in the format string much better
        static void Main(string[] args)
        {
            const int var1 = 1;
            const int var2 = 2;

            Console.WriteLine($"Two sample integers are {var1} and {var2}");
            Console.WriteLine($"Three integers are {1}, {0} and {1}", 3, 6); 
        }
    }
}