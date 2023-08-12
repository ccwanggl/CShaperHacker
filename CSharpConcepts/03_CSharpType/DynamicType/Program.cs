using System;

namespace DynamicType
{
    internal class Program
    {
        private static void Main()
        {
            dynamic myVar = 100;
            Console.WriteLine(myVar.GetType().Name);
            Console.WriteLine(myVar);
            myVar = "Mr, Okay!";
            Console.WriteLine(myVar.GetType().Name);
            Console.WriteLine(myVar);


            // var the same as the auto keyword in c++
            var myVar2 = 100;
            Console.WriteLine(myVar2.GetType().Name);
        }
    }
}
