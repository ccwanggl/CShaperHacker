namespace ParameterExample_ScalAble_para
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x = 3.14159;
            double y = x.Round(4);
            Console.WriteLine(y);

        }
    }


    //note(guoliang): static 
    //note LINQ
    static class DoubleExtension
    {
        public static double Round(this double input, int digits)
        {
            double result = Math.Round(input, digits);
            return result;
        }

    }
}