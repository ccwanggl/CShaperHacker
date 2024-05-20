using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CombiningDelegate
{
    public delegate double Calc(double x, double y);

    class Calculator
    {
        public double Add(double x, double y)
        {
            return x + y;
        }
        public double Sub(double x, double y)
        {
            return x - y;
        }
        public double Div(double x, double y)
        {
            return x / y;
        }
        public double Mul(double x, double y)
        {
            return x * y;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();

            Calc calc1 = new Calc(calculator.Add);
            Calc calc2 = new Calc(calculator.Sub);

			Calc calc = calc1 + calc2;

            Console.WriteLine("{0}", calc(1, 2));
        }
    }
}
