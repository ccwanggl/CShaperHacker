namespace ParameterExample_LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>() { 11,23,44,45};
            bool result = list.All(i => i > 10);
            Console.WriteLine(result);
        }
    }
}