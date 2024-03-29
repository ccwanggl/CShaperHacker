﻿using System;

namespace ParameterWithOut
{
    internal class Program
    {
        private static void Main()
        {
            var b = StudentFactory.Create("guoliang", 34, out Student stu);
            if(b)
            {
                Console.WriteLine("Student {0}, age is {1}.",stu.Name , stu.Age);
            }
        }
    }

    internal class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }

    internal class StudentFactory
    {
        public static bool Create(string name, int age, out Student result)
        {
            result = null;

            if(string.IsNullOrEmpty(name))
            {
                return false;
            }
            if(age > 40)
            {
                return false;
            }

            result = new Student() { Name = name,Age = age };
            return true;
        }
    }
}
