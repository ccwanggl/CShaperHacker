using System;
namespace UserDefinedTypeClass
{
    internal class Student
    {
        public string Name { get; }
        public uint Age { get; }

        public Student(string name, uint age)
       {
           Name = name;
           Age = age;
       }
    }

    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        public static void Main()
        {
            Student stu = new Student("Guoliang", 10);
            Console.WriteLine("Name:{0}", stu.Name);
            Console.WriteLine("Age:{0}", stu.Age);

        }

    }
}
