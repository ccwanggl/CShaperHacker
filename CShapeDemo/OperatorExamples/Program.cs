namespace OperatorExamples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Type t = typeof(int);

            Console.WriteLine(t.Namespace);
            Console.WriteLine(t.FullName);
            Console.WriteLine(t.Name);

            int c = t.GetMembers().Length;
            foreach (var item in t.GetMethods())
            {
                Console.WriteLine(item.Name);
            }
        }
    }
}