using System;
using System.Threading;


namespace MulticastDelegateExample_thread
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student() { ID = 1, PenColor = ConsoleColor.Yellow };
            Student student2 = new Student() { ID = 2, PenColor = ConsoleColor.Green };
            Student student3 = new Student() { ID = 3, PenColor = ConsoleColor.Red };


            Thread thread1 = new Thread(new ThreadStart(student1.DoHomeWork));
            Thread thread2 = new Thread(new ThreadStart(student2.DoHomeWork));
            Thread thread3 = new Thread(new ThreadStart(student3.DoHomeWork));

            // NOTE: oldschool asyn call use thread
            thread1.Start();
            thread2.Start();
            thread3.Start();

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
