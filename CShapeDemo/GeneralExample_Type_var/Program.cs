namespace GeneralExample_Type_var
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var v = 3;
            Console.WriteLine(v.GetType().Name);
            Console.WriteLine(v.CompareTo(2));
            Console.WriteLine(v.CompareTo(3));
            Console.WriteLine(v.CompareTo(4));
        }
    }
}