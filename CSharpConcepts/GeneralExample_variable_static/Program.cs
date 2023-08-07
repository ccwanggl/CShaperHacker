namespace GeneralExample_variable_static
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student.Amount = 100;
            Console.WriteLine(Student.Amount);
        }
    }

    class Student
    {
        public static int Amount;
    }
}