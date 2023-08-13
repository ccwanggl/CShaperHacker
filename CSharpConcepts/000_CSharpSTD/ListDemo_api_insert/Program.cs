// See https://aka.ms/new-console-template for more information

List<int> list1 = new List<int>() { 100,200,300,400};
List<int> list2 = new List<int>() { 10,20,30,40};

list2.Insert(0, 1);
list2.Insert(list2.Count-1, 2);
Console.WriteLine($"{list2.Count}/{list2.Capacity}");
Console.WriteLine(String.Join(",", list2));
