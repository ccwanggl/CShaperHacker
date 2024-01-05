using System;

namespace UserDefinedTypeStruct
{
    internal struct Student
    {
        public int ID;
        public string Name;

        public Student(int id, string name)
        {
            ID = id;
            Name = name;
        }
    }
    
    internal class Program
    {
        private static void Main()
        {
            Student stu = new Student(1, "Guoliang");
            Console.WriteLine("Student Info " + stu.ID + stu.Name);
        }
    }
}
