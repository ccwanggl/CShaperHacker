﻿namespace FunctionPointerExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            Action action = new Action(calculator.Report);

            calculator.Report();
            action.Invoke();
            action();

            Func<int, int, int> funcAdd = new Func<int, int, int>(calculator.Add);
            Func<int, int, int> funcSub = new Func<int, int, int>(calculator.Sub);
            Console.WriteLine("{0}", funcAdd(1, 2));
            Console.WriteLine("{0}", funcAdd.Invoke(1, 2));
        }
    }

    class Calculator
    {
        public void Report()
        {
            Console.WriteLine("I have 3 methods.");
        }

        public int Add(int a, int b)
        {
            int result = a + b;
            return result;
        }


        public int Sub(int a, int b)
        {
            int result = a - b;
            return result;
        }
    }
}