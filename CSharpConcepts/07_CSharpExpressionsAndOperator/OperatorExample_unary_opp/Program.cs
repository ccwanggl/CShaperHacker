namespace OperatorExample_unary_opp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 12345678;
            int y = -x;

            var xStr = Convert.ToString(x, 2).PadLeft(32, '0');
            var yStr = Convert.ToString(y, 2).PadLeft(32, '0');

            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(xStr);
            Console.WriteLine(yStr);
        }
    }
}