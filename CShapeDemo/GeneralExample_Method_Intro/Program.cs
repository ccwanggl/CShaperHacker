namespace GeneralExample_Method_Intro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator cal = new Calculator();
            Console.WriteLine(cal.Add(1, 3));
            Console.WriteLine(cal.GetType().Name);
            Console.WriteLine(cal.GetType().FullName);

            Console.WriteLine("===============");
            Console.WriteLine(cal.GetToday());
        }
    }

    class Calculator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public string GetToday()
        {
            int today = DateTime.Now.Day;
            return today.ToString();
        }

        public void PrintHello()
        {
            Console.WriteLine("Hello data & algorithm");
        }
    }
}