using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewOperator
{
    internal class Program
    {
        // NOTE: {} 初始化器
        static void Main(string[] args)
        {
            new Form() { Text = "Hello" }.ShowDialog();
            var person = new { Name = "Guoliang", Age = 38 };
            
            Console.WriteLine(person.Name);
            Console.WriteLine(person.Age);
            Console.WriteLine(person.GetType().Name);

        }
    }

    class Student
    {
        public void Report()
        {
            Console.WriteLine("I'm a student");
        }
    }

    class CsStudent : Student
    {
        new public void Report() { Console.WriteLine("I'm a cs student")};
    }
}
