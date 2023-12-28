using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

using BaseClassNS;

namespace UseBaseClass
{
    public class DerivedClass : MyBaseClass
    {
        public override void PrintMe()
        {
            Console.WriteLine("I am Derived class"); 
        }
    }
}
