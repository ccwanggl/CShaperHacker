using System;

namespace AnonymousType
{
	// NOTE: 使用 Var 关键字的重要条件：
	// NOTE: 只能用于局部变量，不能用于字段
	// NOTE: 只能在变量申明中包含初始化时使用
	// NOTE: 一旦编译器推断出变量的类型,它就是固定且不能更改的

    internal class Program
    {
        private static void Main(string[] args)
        {
            var person = new { Name = "Mr.Okey", age = 100 };
            Console.WriteLine(person.Name);
            Console.WriteLine(person.age);

            Console.WriteLine(person.GetType().Name);
        }
    }
}
