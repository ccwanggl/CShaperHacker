using System;

namespace DelegateExample
{
    // NOTE: 可以理解为 c++ 中的函数指针,委托是一种类，可以定义变量

	// +++ 1. 声明一个委托类型
    public delegate double Calc(double x, double y);

    internal class Program
    {
	// +++ 2. 声明委托变量
		private Calc calc1 ;
		private Calc calc2 ;
		private Calc calc3 ;
		private Calc calc4 ;
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();

	// +++ 3. 创建委托类型的对象并赋值给委托变量
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
