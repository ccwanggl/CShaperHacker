using ClassExample_Access_Level_Lib.MyNamespace;


namespace ClassExample_Access_Level
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            Console.WriteLine(calculator.Add(1,2));
        }
    }
}