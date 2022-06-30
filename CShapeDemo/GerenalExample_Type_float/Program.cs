namespace GerenalExample_Type_float
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var f = 0.3f;
            var d = 0.3;

            Console.WriteLine(f.GetType().Name);
            Console.WriteLine(d.GetType().Name);
        }
    }
}