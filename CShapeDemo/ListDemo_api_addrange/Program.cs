// See https://aka.ms/new-console-template for more information

int[] array = new int[] { 100, 200, 300 ,400};
List<int> list = new List<int>();
list.AddRange(array);
Console.WriteLine($"{list.Count}/{list.Capacity}");
Console.WriteLine(String.Join(",", list));


