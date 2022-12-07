namespace ExpressionExample_nullable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int? x = null;

            var y = x ?? 100;
            Console.WriteLine(y.GetType().FullName);
        }
    }
}