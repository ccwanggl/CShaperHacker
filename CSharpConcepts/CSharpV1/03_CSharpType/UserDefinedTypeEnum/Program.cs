using System;

namespace UserDefinedTypeEnum
{
    internal enum Color
    {
        Red,
        Green,
        Blue
    }
    
    internal class Program
    {
        private static void Main()
        {
            const Color color = Color.Red;
            Console.WriteLine("Color is: " + color);
        }
    }
}
