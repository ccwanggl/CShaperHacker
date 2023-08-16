using System;
using PublicClass;
using InternalClass;


namespace CVClass
{
    internal class Program
    {
        private static void Main()
        {
            Calculator calculator = new Calculator();
            Console.WriteLine(calculator.Add(1,2));

            Student stu = new Student(1, "Guoliang");
            Console.WriteLine("Student: {0} {1}", stu.Id, stu.Name);
        }
    }
}
