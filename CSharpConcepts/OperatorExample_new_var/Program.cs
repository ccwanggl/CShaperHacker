using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorExample_new_var
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var person = new { Name = "guoliang", Age = 34 };

            Console.WriteLine(person.Name);
            Console.WriteLine(person.Age);
            Console.WriteLine(person.GetType().Name);
        }
    }
}
