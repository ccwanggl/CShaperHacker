#nullable enable
using System;

namespace ParameterPassByValue
{
    internal class Program
    {
        private static void Main()
        {
            Student stu = new Student() { Name = "Tim" };
            Console.WriteLine("HashCode={0},{1}",stu.GetHashCode(), stu.Name); 
            SomeMethod(stu);
            Console.WriteLine("HashCode={0},{1}",stu.GetHashCode(), stu.Name);
        }

        // NOTE: ref type pass by ref
        private static void SomeMethod(Student stu)
        {
            // NOTE: Create object and call the type ctor
            stu = new Student() { Name = "Tim" };
            Console.WriteLine("HashCode={0},{1}",stu.GetHashCode(), stu.Name); 
        }
    }

    internal class Student
    {
        public string? Name { get; set; } 
    }

}
