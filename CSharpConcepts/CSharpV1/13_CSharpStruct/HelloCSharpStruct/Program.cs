using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloCSharpStruct
{
    struct Point
    {
        public int x;
        public int y;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Point first, second, third;

            first.x = 1;
            first.y = 2;

            Console.WriteLine($"first: {first.x}, {first.y}");
        }
    }
}
