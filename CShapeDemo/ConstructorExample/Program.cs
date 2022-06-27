namespace ConstructorExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student stu = new Student();
        }

        class Student
        {
            public int ID;
            public string Name;
        }
    }
}