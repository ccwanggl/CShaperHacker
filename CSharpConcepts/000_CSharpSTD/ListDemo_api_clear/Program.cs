// See https://aka.ms/new-console-template for more information
List<int> list = new List<int>() { 100,200,300,400};

Console.WriteLine($"{list.Count}/{list.Capacity}");
Console.WriteLine(String.Join(",", list));

list.Clear();

Console.WriteLine($"{list.Count}/{list.Capacity}");
Console.WriteLine(String.Join(",", list));
