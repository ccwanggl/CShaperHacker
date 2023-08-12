namespace OperatorExample_implicit_boxing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 1;
            object y = x;
            int z = (int)y;

            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
        }
    }
}