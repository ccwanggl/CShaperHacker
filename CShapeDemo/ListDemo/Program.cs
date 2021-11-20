// See https://aka.ms/new-console-template for more information

// NOTE (guoliang) Method 1
void test_init_with_array()
{
    Console.WriteLine("Test init with array\n");
    int[] array = new int[] { 100, 200, 300, 400 };

    Console.WriteLine(array is IEnumerable<int>);
    List<int> list = new List<int>(array);
    Console.WriteLine(String.Join(",", list));
}


// NOTE (guoliang) Method 2
void test_init_with_size()
{
    Console.WriteLine("Test init with size?\n");
    List<int> list = new List<int>(50);

    Console.WriteLine($"{list.Count}");
    Console.WriteLine(String.Join(",", list));
}

void test_dyn()
{
    Console.WriteLine("Test the size and capacity of the list\n");
    List<int> list = new List<int>();
    for(int i = 1; i <= 100; i++)
    {
        list.Add(i);
        Console.WriteLine($"{list.Count}/{list.Capacity}");
    }
    Console.WriteLine(String.Join(",", list));
}


// NOTE (guoliang) Method 3
void test_AddRange()
{
    List<int> list = new List<int>() { 100, 200, 300, 400 };
    Console.WriteLine($"{list.Count}/{list.Capacity}");
    Console.WriteLine(String.Join(",", list));

    Console.WriteLine("After AddRange\n");
    List<int> list2 = new List<int> { 10, 20, 30, 40 };
    list2.AddRange(list);
    Console.WriteLine(String.Join(",", list2));
}

void test_InsertRange()
{
    Console.WriteLine("Test InsertRange:\n");
    List<int> list1 = new List<int>() { 100, 200, 300, 400 };
    List<int> list2 = new List<int> { 10, 20, 30, 40 };

    list2.InsertRange(list2.Count, list1);
    Console.WriteLine(String.Join(",", list2));
}

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

test_dyn();
test_init_with_array();
test_init_with_size();
test_AddRange();
test_InsertRange();
test_remove();









