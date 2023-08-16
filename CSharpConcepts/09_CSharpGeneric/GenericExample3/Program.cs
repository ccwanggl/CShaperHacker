using System.Collections.Generic;


namespace GenericExample3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IList<int> list = new List<int>();
            for (int i = 0; i < 100; i++)
            {
                list.Add(i);
            }

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }    
        }
    }

}