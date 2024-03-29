﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    internal sealed class MyData
    {
        private double D1, D2, D3;
        public MyData(double d1, double d2, double d3)
        {
            D1 = d1;
            D2 = d2;
            D3 = d3;
        }

        public double Sum()
        {
            return D1 * D2 + D3;
        }
    }

    internal static class ExtendMyDataMethod1
    {
        public static double Average(MyData md)
        {
            return md.Sum()/3;
        }
    }


    internal static class ExtendMyDataMethod2
    {
        public static double Average(this MyData md)
        {
            return md.Sum()/3;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            MyData md = new MyData(3, 4, 5);
            Console.WriteLine($"Sum:  {md.Sum()}");
            Console.WriteLine("Average: {0}", md.Average());

            Console.WriteLine($"Sum:  {md.Sum()}");
            Console.WriteLine("Average: {0}", ExtendMyDataMethod1.Average(md));
        }
    }
}
