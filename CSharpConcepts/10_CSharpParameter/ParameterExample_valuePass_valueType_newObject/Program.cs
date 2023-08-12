namespace ParameterExample_valuePass_valueType_newObject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student stu = new Student() { Name = "Tim" };
            Console.WriteLine("HashCode={0},{1}",stu.GetHashCode(), stu.Name); 
            SomeMethod(stu);
            Console.WriteLine("HashCode={0},{1}",stu.GetHashCode(), stu.Name); 
        }

        static void SomeMethod(Student stu)
        {
            stu = new Student() { Name = "Tim" };
            Console.WriteLine("HashCode={0},{1}",stu.GetHashCode(), stu.Name); 
        }

    }

    class Student
    {
        public string? Name { get; set; } 
    }

}