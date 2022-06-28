namespace GenericExample6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Action only used to the method without return value
            Action<string> a1 = Say;
            a1.Invoke("Guoliang");

            Action<int> a2 = Mul;
            a2.Invoke(1);

            Func<int, int, int> func = Add;
            Console.WriteLine(Add(1, 2));

            Func<double, double, double> func1 = (double a, double b) => { return a + b; };
            Console.WriteLine(func1(100, 200));
        }
        static void Say(string str)
        {
            Console.WriteLine($"Hello, {str}!");
        }

        static void Mul(int x)
        {
            Console.WriteLine(x * 100);
        }


        static int Add(int a, int b )
        {
            return a + b;
        }

        static double Add(double a, double b)
        {
            return a + b;
        }
    }

}