namespace OperatorExample_unary_not
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student stu = new Student(null);
            Console.WriteLine(stu.Name);
        }
    }

    class Student
    {
        public Student(string initName)
        {
            if(!string.IsNullOrEmpty(initName))
                this.Name = initName;
        }

        public string Name;
    }
}