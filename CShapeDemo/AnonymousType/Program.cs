﻿namespace AnonymousType
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var person = new { Name = "Mr.Okey", age = 100 };
            Console.WriteLine(person.Name);
            Console.WriteLine(person.age);

            Console.WriteLine(person.GetType().Name);
        }
    }
}