using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ctor
{
    struct Simple
    {
        public int x;
        public int y;

        public Simple(int a, int b)
        {
            x = a;
            y = b;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Simple s1 = new Simple();
            Simple s2 = new Simple(5,10);

            Console.WriteLine($"{s1.x} {s1.y}");
            Console.WriteLine($"{s2.x} {s2.y}");

            Simple s3, s4;
            s3.x = 1;
            s3.y = 2;
            Console.WriteLine($"{s3.x} {s3.y}");
        }
    }
}
