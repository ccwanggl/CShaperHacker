using System;
using System.Threading;

namespace MulticastDelegateExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student() { ID = 1, PenColor = ConsoleColor.Yellow };
            Student student2 = new Student() { ID = 2, PenColor = ConsoleColor.Green };
            Student student3 = new Student() { ID = 3, PenColor = ConsoleColor.Red };

            Action action1 = new Action(student1.DoHomeWork);
            Action action2 = new Action(student2.DoHomeWork);
            Action action3 = new Action(student3.DoHomeWork);

            action1 += action2;
            action1 += action3;

            action1.Invoke();

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
