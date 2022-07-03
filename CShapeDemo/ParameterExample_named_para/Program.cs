namespace ParameterExample_named_para
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintInfo("guoliang", 34);
            PrintInfo(Name: "Mohan", age: 33);
            PrintInfo(age: 33, Name: "Mohan");
        }

        static void PrintInfo(string Name, int age)
        {
            Console.WriteLine("Hello {0}, you are {1}", Name,age);
        }
    }
}