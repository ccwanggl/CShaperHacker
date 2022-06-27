namespace CShapeMethodExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        class Calculator
        {
            public double GetCircleArea(double r)
            {
                return Math.PI * r * r;
            }

            public double GetCylinderVolume(double r, double h)
            {
                return GetCircleArea(r) * h;
            }

            public double GetConeVolume(double r, double h)
            {
                return GetCylinderVolume(r,h) * h/3;
            }

        }
    }
}