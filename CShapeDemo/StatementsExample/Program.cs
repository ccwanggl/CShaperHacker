namespace StatementsExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            try
            {
                var score = double.Parse(input);
                if(score >= 60)
                {
                    Console.WriteLine("Pass!");
                }
                else
                {
                    Console.WriteLine("Failed");
                }
            }
            catch
            {
                throw;
            }
        }
    }
}