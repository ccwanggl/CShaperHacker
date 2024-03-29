﻿using System;
using System.Threading;
using System.Threading.Tasks;   


namespace MulticastDelegateExample_thread
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student() { ID = 1, PenColor = ConsoleColor.Yellow };
            Student student2 = new Student() { ID = 2, PenColor = ConsoleColor.Green };
            Student student3 = new Student() { ID = 3, PenColor = ConsoleColor.Red };


            Task task1 = new Task(new Action(student1.DoHomeWork));
            Task task2 = new Task(new Action(student2.DoHomeWork));
            Task task3 = new Task(new Action(student3.DoHomeWork));

            // NOTE: modern asyn call use task
            task1.Start();
            task2.Start();
            task3.Start();

            for (int i = 0; i < 10; i++)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Main thread {0}.", i);
                Thread.Sleep(1000);

            }
        }
    }

    class Student
    {
        public int ID { get; set; }
        public ConsoleColor PenColor { get; set; }

        public void DoHomeWork()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.ForegroundColor = this.PenColor;
                Console.WriteLine("Student {0} doing homework {1} hour(s)", this.ID, i);
                Thread.Sleep(1000);
            }
        }
    }
}
