using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameofOpr
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string var1 = "Local Variable";
            Console.WriteLine(nameof(var1));
        }
    }
}
