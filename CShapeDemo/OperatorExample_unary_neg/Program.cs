namespace OperatorExample_unary_neg
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //note(guoliang): Must understand how the machine convert the opposite operation
            int x = int.MinValue;
            Console.WriteLine(Convert.ToString(x,2));
            int y = -x;
            Console.WriteLine(Convert.ToString(y,2));

            Console.WriteLine(x);
            Console.WriteLine(y);
        }
    }
}