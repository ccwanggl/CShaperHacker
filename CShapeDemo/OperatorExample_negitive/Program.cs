namespace OperatorExample_negitive
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 12345678;
            int y = -x;

            string xStr = Convert.ToString(x,2).PadLeft(32,'0');
            string yStr = Convert.ToString(y,2).PadLeft(32,'0');

            Console.WriteLine(xStr);
            Console.WriteLine(yStr);


            int x1 = int.MinValue;
            Console.WriteLine(x1);
            int y1 = checked(-x1);
            Console.WriteLine(y1);
            string xStr2 = Convert.ToString(x1,2).PadLeft(32,'0');
            string yStr2 = Convert.ToString(y1,2).PadLeft(32,'0');
            Console.WriteLine(xStr2);
            Console.WriteLine(yStr2);

        }
    }
}