using System;

namespace UserDefinedTypeStruct
{
    internal struct Student
    {
        private int id;
        private string name;

        public int ID {  get { return id; } }
		public string Name { get { return name; } }

        public Student(int id, string name)
        {
            this.id = id;
            this.name = name;
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
