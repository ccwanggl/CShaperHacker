// See https://aka.ms/new-console-template for more information

using ListDemo;

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


List<int> intList = new List<int>() { 100, 200, 300, 400 };
List<Book> bookList = new List<Book>();

for (int j = 0; j  < 10; j ++) {
    bookList.Add(new Book { Id = j, Name = $"Book-{j}", Price = 10 * j });
}

Console.WriteLine($"intList:{intList.Count}/{intList.Capacity}");
Console.WriteLine($"bookList:{bookList.Count}/{bookList.Capacity}");
Console.WriteLine("=====================");

Console.WriteLine(bookList[0]);
Console.WriteLine(bookList[bookList.Count - 1]);

var e = intList.GetEnumerator();
Console.WriteLine(e.Current);
while (e.MoveNext())
{
    Console.WriteLine( e.Current);
}

foreach(var val in intList)
{
    Console.WriteLine(val);
}

int sum = 0;
intList.ForEach(val => sum += val);
Console.WriteLine(sum);



Console.WriteLine("List Part3 ===========================================>");

List<double> list1 = new List<double> { 100.0, 200.0, 300.0, 400.0, 100.0, 200.0, 300.0, 400.0 };
Book book1 = new Book { Id = 1, Name = "Book-1", Price = 10 };
Book book2 = new Book { Id = 2, Name = "Book-2", Price = 20 };
Book book3 = new Book { Id = 3, Name = "Book-3", Price = 30 };
Book book4 = new Book { Id = 4, Name = "Book-4", Price = 40 };
Book book5 = new Book { Id = 1, Name = "Book-1", Price = 10 };
Book book6 = book1;
List<Book> list2 = new List<Book> { book1, book2, book3, book4 };

var res = list2.Contains(book5);
Console.WriteLine(res);    
var res1 = list2.Contains(book6);
Console.WriteLine(res1);

bool res2 = list1.Exists(e => e >= 500);
Console.WriteLine(res2);

bool res3 = list2.Exists(b => b.Price <= 40);
Console.WriteLine(res3);

bool res4 = list1.TrueForAll(e => e % 100 == 0);
Console.WriteLine(res4);

bool res5 = list2.TrueForAll(b => b.Price <= 40);
Console.WriteLine(res5);

// ver 1
int res6 = list1.IndexOf(300);
Console.WriteLine(res6);

// ver 2
int res7 = list1.IndexOf(300,3); 
Console.WriteLine(res7);

int i = -1;
while(true)
{
    i = list1.IndexOf(300, i + 1);
    if(i == -1)
        break;
    Console.WriteLine(i);
}

// ver 3
int res8 = list1.IndexOf(300, 3, 3);
Console.WriteLine(res8);



