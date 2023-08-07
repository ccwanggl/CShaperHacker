namespace GeneralExample_Type_GetClassInfo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var info = typeof(Math);
            Console.WriteLine(info.GetType().FullName);
            Console.WriteLine(info.IsClass);
        }
    }
}