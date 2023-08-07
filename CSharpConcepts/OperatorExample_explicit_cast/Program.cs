namespace OperatorExample_explicit_cast
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var str1 = Console.ReadLine(); 
            var str2 = Console.ReadLine(); 

            var x = Convert.ToInt32(str1);
            var y = Convert.ToInt32(str2);

            Console.WriteLine(x + y);
        }
    }
}