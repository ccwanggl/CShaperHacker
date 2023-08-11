// See https://aka.ms/new-console-template for more information

using System;
using System.Collections.Generic;

namespace ListDemo
{
    internal partial class Program
    {
        private static void TestInsertRange()
        {
            Console.WriteLine("Test InsertRange:\n");
            List<int> list1 = new List<int>() { 100, 200, 300, 400 };
            List<int> list2 = new List<int> { 10, 20, 30, 40 };

            list2.InsertRange(list2.Count, list1);
            Console.WriteLine(string.Join(",", list2));
        }

        private static void TestRemove()
        {
            Console.WriteLine("Test remove ===>");
            List<int> list = new List<int>() { 100, 200, 300, 400 };
            list.AddRange(list);
            list.AddRange(list);

            Console.WriteLine(string.Join(",", list));

            list.RemoveAt(0);
            Console.WriteLine(string.Join(",", list));

            list.RemoveAt(list.Count - 1);
            Console.WriteLine(string.Join(",", list));

            list.RemoveRange(0, 1);
            Console.WriteLine(string.Join(",", list));

            list.Remove(300);
            Console.WriteLine(string.Join(",", list));

            list.RemoveAll(e => e == 400);
            Console.WriteLine(string.Join(",", list));
        }

        private static void TestInitWithSize()
        {
            Console.WriteLine("Test init with size?\n");
            List<int> list = new List<int>(50);

            Console.WriteLine($"{list.Count}");
            Console.WriteLine(string.Join(",", list));
        }

        private static void TestInitWithArray()
        {
            Console.WriteLine("Test init with array\n");
            var array = new int[] { 100, 200, 300, 400 };

            Console.WriteLine(array is IEnumerable<int>);
            List<int> list = new List<int>(array);
            Console.WriteLine(string.Join(",", list));
        }

        // NOTE (guoliang) Method 3
        private static void TestAddRange()
        {
            List<int> list = new List<int>() { 100, 200, 300, 400 };
            Console.WriteLine($"{list.Count}/{list.Capacity}");
            Console.WriteLine(string.Join(",", list));

            Console.WriteLine("After AddRange\n");
            List<int> list2 = new List<int> { 10, 20, 30, 40 };
            list2.AddRange(list);
            Console.WriteLine(string.Join(",", list2));
        }

        private static void TestDyn()
        {
            Console.WriteLine("Test the size and capacity of the list\n");
            List<int> list = new List<int>();
            for (var i = 1; i <= 100; i++)
            {
                list.Add(i);
                Console.WriteLine($"{list.Count}/{list.Capacity}");
            }
            Console.WriteLine(string.Join(",", list));
        }
        public static void Main(string[] args)
        {
            TestDyn();
            TestInitWithArray();
            TestInitWithSize();
            TestAddRange();
            TestInsertRange();
            TestRemove();
            return;
        }
    }
}
