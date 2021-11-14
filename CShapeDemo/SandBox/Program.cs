// See https://aka.ms/new-console-template for more information

namespace SandBox
{
    class SandBox
    {
        static void Main(string[] args)
        {
            // NOTE (guoliang) "var" the same as to the keyword "auto" in the C++?

            var result = Tools.Calculator.Div(1, 0);
            var mul = Tools.Calculator.Mul(1, 0);

            System.Console.WriteLine(result);
            System.Console.WriteLine(mul);

        }
    }
}
