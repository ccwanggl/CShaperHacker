using System;

namespace ParameterPassByValue2
{
    internal class Program
    {
        private static void Main()
        {
            Student student = new Student();
            var y = 100;
            student.AddOne(y);
            Console.WriteLine("Outside method: {0}", y);
        }
    }

    internal class Student
    {
        public void AddOne(int x)
        {
            x++;
            Console.WriteLine("Inside method: {0}", x);
        }
    }
}
