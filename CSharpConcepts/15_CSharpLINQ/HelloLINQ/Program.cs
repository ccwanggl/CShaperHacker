using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloLINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3 };

            IEnumerable<int> lowNums = 
                from n in numbers
                where n > 2
                select n;

            foreach (int n in lowNums)
            {
                Console.WriteLine($"{n},");
            }
        }
    }
}
