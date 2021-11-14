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

List<int> list2 = new List<int> { 10, 20, 30, 40 };
list2.AddRange(list);

list2.Clear();

Console.WriteLine(String.Join(",", list2));

void test_remove()
{
    Console.WriteLine("Test remove ===>");
    List<int> list = new List<int>() { 100, 200, 300, 400 };
    list.AddRange(list);
    list.AddRange(list);

    Console.WriteLine(String.Join(",", list));

    list.RemoveAt(0);
    Console.WriteLine(String.Join(",", list));

    list.RemoveAt(list.Count - 1 );
    Console.WriteLine(String.Join(",", list));

    list.RemoveRange(0, 1);
    Console.WriteLine(String.Join(",", list));

    list.Remove(300);
    Console.WriteLine(String.Join(",", list));

    list.RemoveAll(e => e == 400);
    Console.WriteLine(String.Join(",", list));
}

test_remove();









