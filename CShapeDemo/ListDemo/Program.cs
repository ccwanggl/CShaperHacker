// See https://aka.ms/new-console-template for more information

// NOTE (guoliang) Method 1
int[] array = new int[] { 100, 200, 300, 400 };
Console.WriteLine(array is IEnumerable<int>);

//List<int> list = new List<int>(array);

// NOTE(guoliang) Method 2
//List<int> list = new List<int>(50);

// NOTE(guoliang) Method 3
List<int> list = new List<int>() { 100, 200, 300, 400 };
Console.WriteLine($"{list.Count}/{list.Capacity}");



Console.WriteLine(String.Join(",", list));



