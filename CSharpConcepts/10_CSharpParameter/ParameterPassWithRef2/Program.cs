#nullable enable
using System;

namespace ParameterPassWithRef2
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Student outterStu = new Student() { Name = "Tim" };

            Console.WriteLine("HashCode={0}, Name={1}", outterStu.GetHashCode(), outterStu.Name);

            Console.WriteLine("--------------------------");

            WantSideEffect(ref outterStu);
            Console.WriteLine("HashCode={0}, Name={1}", outterStu.GetHashCode(), outterStu.Name);
        }

        private static void WantSideEffect(ref Student stu)
        {
            stu.Name = "Tom";
            Console.WriteLine("HashCode={0}, Name={1}", stu.GetHashCode(), stu.Name);
        }
    }

    internal class Student
    {
        public string? Name { get; set; }
    }
}
