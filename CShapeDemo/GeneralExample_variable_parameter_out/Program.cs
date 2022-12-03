using System.Transactions;

namespace GeneralExample_variable_parameter_out
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }


    class Student
    {
        public int Age;
        public string Name;


        public double Add(out double a, double b)
        {
            a = b;
            return a;
        }
    }
}