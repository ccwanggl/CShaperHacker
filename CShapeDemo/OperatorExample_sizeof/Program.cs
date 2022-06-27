namespace OperatorExample_sizeof
{
    internal class Program
    {
        static void Main(string[] args)
        {
            unsafe
            {
                int x = sizeof(Student);
                Console.WriteLine(x);
            }
        }
    }

    struct Student
    {
        int ID;
        long Score;
    }
}