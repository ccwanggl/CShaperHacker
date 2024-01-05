using System;

namespace DelegateExample
{
    // NOTE: 可以理解为 c++ 中的函数指针,委托是一种类，可以定义变量
    public delegate double Calc(double x, double y);
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();

            Calc calc1 = new Calc(calculator.Add);
            Calc calc2 = new Calc(calculator.Sub);
            Calc calc3 = new Calc(calculator.Mul);
            Calc calc4 = new Calc(calculator.Div);

            Console.WriteLine("{0}", calc1.Invoke(1, 2));
            Console.WriteLine("{0}", calc2.Invoke(1, 2));
            Console.WriteLine("{0}", calc3.Invoke(1, 2));
            Console.WriteLine("{0}", calc4.Invoke(1, 2));
        }
    }
    
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
}
