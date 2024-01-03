using System; 

namespace IsOperator
{

    class Animal
    {

    }

    class Teacher: Animal { }

    class Program
    {
        static void Main(string[] args)
        {
            Teacher t = new Teacher();
            var test = t is Teacher;
            if (test)
            {
                System.Console.WriteLine(test.GetType().Name);
            }

        }
    }
}
