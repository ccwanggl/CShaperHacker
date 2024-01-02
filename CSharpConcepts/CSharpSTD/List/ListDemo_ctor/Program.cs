using System.Collections.Generic;
// See https://aka.ms/new-console-template for more information

// Default ctor
Console.WriteLine("Default ctor");
List<int> list = new List<int>();
Console.WriteLine($"{list.Count}/{list.Capacity}");
Console.WriteLine(String.Join(",", list));
Console.WriteLine();


Console.WriteLine("Use IEnumerable object");
int[] array = new int[] { 100, 200, 300 ,400};
Console.WriteLine(array is IEnumerable<int>);
List<int> list2 = new List<int>(array);
Console.WriteLine(String.Join(",", list2));
Console.WriteLine();


Console.WriteLine("Use copy ctor?");
List<int> list3 = new List<int>(list2); 
Console.WriteLine($"{list3.Count}/{list3.Capacity}");
Console.WriteLine(String.Join(",", list3));
Console.WriteLine();


Console.WriteLine("Specify capacity");
List<int> list4 = new List<int>(50);
Console.WriteLine($"{list4.Count}/{list4.Capacity}");
Console.WriteLine(String.Join(",", list4));
Console.WriteLine();

