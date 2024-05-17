using System;

namespace ConversionExample
{
    internal class Animal
    {
        public void Eat()
        {
            Console.WriteLine("Eating...");
        }
    }

    internal class Human:Animal
    {
        public void Think()
        {
            Console.WriteLine("Who I am?");
        }
    }

    internal class Teacher:Human
    {
        public void Teach()
        {
            Console.WriteLine("I am teaching programming.");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input number 1"); 
            string str1 = Console.ReadLine();
            Console.WriteLine("Please input number 2"); 
            string str2 = Console.ReadLine();

            int x = Convert.ToInt32(str1);
            int y = Convert.ToInt32(str2);

            Console.WriteLine(x + y);
        }
    }

}
