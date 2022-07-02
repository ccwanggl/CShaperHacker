namespace OperatorExample_sizeof
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //NOTE (guoliang): use sizeof operator to get the custom defined type is unsafe operation

            unsafe
            {
                int x = sizeof(Student);
                Console.WriteLine(x);
            }

            Console.WriteLine("The type decimal size equals to {0}", sizeof(decimal));
        }
    }

    struct Student
    {
        int ID;
        long Score;
    }
}