namespace GeneralExample_boxing_unboxing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // copy data from stack to heap
            int x = 100;
            object obj = x;

            // copy data from heap to stack
            int y = (int)obj;
            Console.WriteLine(y);
        }
    }
}