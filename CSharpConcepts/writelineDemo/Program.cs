using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace writelineDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double myDouble = 12.3456789;

            Console.WriteLine("{0,-10:G} -- General", myDouble);
            Console.WriteLine("{0,-10} -- Default, same as General", myDouble);
            Console.WriteLine("{0,-10:F4} -- Fixed Point, 4 dec places", myDouble);
            Console.WriteLine("{0,-10:C} -- Currency", myDouble);
            Console.WriteLine("{0,-10:E3} -- Sci, Notion, 3 dec places", myDouble);
            Console.WriteLine("{0,-10:x} -- Hexadecimal integer", 1194719);
            Console.WriteLine("{0,-10:n2} -- Hexadecimal integer", 1194719.3408081);
            Console.WriteLine("{0,-10:p2} -- Hexadecimal integer", 0.12278);

            Console.WriteLine();

            Console.WriteLine($"{myDouble,-10:G} -- General");
            Console.WriteLine($"{myDouble,-10} -- Default, same as General");
            Console.WriteLine($"{myDouble,-10:F4} -- Fixed Point, 4 dec places");
            Console.WriteLine($"{myDouble,-10:C} -- Currency");
            Console.WriteLine($"{myDouble,-10:E3} -- Sci, Notion, 3 dec places");
            Console.WriteLine($"{1194719,-10:x} -- Hexadecimal integer" );
        }
    }
}
