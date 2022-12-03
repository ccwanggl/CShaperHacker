namespace GeneralExample_variable_local
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.Age= 10;
            student.Name = "guoliang";

            Console.WriteLine("{0}, {1}",student.Age, student.Name);
        }
    }

    class Student
    {
        // 字段
        public int Age;
        public string Name;
    }
}