﻿using System;

namespace ClassDefinition
{
    internal class Program
    {
        private static void Main()
        {
            Type t = typeof(Student);
#if REFLECTION
            object o = Activator.CreateInstance(t, 1, "Guoliang");
            //Student student = (Student)o;
            Student student = o as Student;
#else
            dynamic student = Activator.CreateInstance(t, 1, "Guoliang");
#endif
            Console.WriteLine(student.Name);
        }
    }

    internal class Student
    {
        public static int Amount { get; set; }
        // NOTE: static ctor used for init the static member
        static Student()
        {
            Amount = 100;
        }

        // NOTE: use to init the instance member
        public Student(int id, string name)
        {
            Id = id;
            Name = name;
            Amount++;
        }

        ~Student()
        {
            Console.WriteLine("Bye bye! Release the system resources ...");
            Amount--;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public void Report()
        {
            Console.WriteLine($"I'm #{Id} student, my name is {Name}"); 
        }
    }
}
