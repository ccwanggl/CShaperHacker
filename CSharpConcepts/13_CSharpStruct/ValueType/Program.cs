using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueType
{
    class CSimple
    {
        public int X;
        public int Y;
    }

    struct Simple
    {
        public int X;
        public int Y;
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            CSimple cs1 = new CSimple();
            CSimple cs2 = null;

            Simple ss1 = new Simple();
            Simple ss2 = new Simple();

            cs1.X = ss1.X = 5; 
            cs2.Y = ss2.Y = 10;


            cs2 = cs1;
            ss2 = ss1;
        }
    }
}
