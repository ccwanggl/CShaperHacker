// See https://aka.ms/new-console-template for more information

namespace DynamicSample
{
    class Program
    {
        static void Main(String[] args)
        {
            dynamic myVar = 100;
            Console.WriteLine(myVar);
            myVar = "Mr. Okay!";
            Console.WriteLine(myVar);
        }
    }
}
