﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutputParameter
{
    class MyClass { public int val = 30; }
    internal class Program
    {
        static void MyMethod(out MyClass f1, out int f2)
        {
            f1 = new MyClass();
            f1.val = 25;
            f2 = 15;
        }
        static void Main(string[] args)
        {
            MyClass a1 = null;
            int a2;

            MyMethod(out a1, out a2);

            Console.WriteLine("After C#7");
            MyMethod(out MyClass arg1, out int arg2);
        }

    }
}
