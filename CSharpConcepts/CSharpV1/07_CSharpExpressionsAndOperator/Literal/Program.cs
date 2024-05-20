using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Literal
{
    internal class Program
    {
        static void Main(string[] args)
        {
			// note 整数字面量
            Console.WriteLine("{0}", 1024);
            Console.WriteLine("{0}", 1024L);
            Console.WriteLine("{0}", 1024U);
            Console.WriteLine("{0}", 1024UL);

			// note 实数字面量
            Console.WriteLine("{0}", 1024F);
            Console.WriteLine("{0}", 1024.3);
            Console.WriteLine("{0}", .3);
            Console.WriteLine("{0}", 3.33e-26);

            Console.WriteLine("{0}", true);

            Console.WriteLine("{0}", "Hi there");
            Console.WriteLine("{0}", @"C:\Program Files\Microsoft");

            Console.WriteLine("{0}", 'x');
            Console.WriteLine("{0}", '\x0061');
            Console.WriteLine("{0}", '\n');
            Console.WriteLine("{0}", '\u005a');
        }
    }
}
