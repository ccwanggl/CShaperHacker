namespace PerameterExample_para_value
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            int y = 100;
            student.AddOne(y);
            Console.WriteLine(y);
        }
    }

    class Student
    {
        public void AddOne(int x)
        {
            x = x + 1;
            Console.WriteLine(x);
        }
    }
}