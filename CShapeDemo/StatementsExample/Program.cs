namespace StatementsExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            try
            {
                double score = double.Parse(input);
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