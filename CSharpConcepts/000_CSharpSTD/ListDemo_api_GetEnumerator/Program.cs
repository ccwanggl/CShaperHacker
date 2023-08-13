using ListDemo;

List<int> intList = new List<int> { 100, 200, 300, 400 };
List<Book> bookList = new List<Book>();
for (int i = 0; i < 10; i++)
{
    bookList.Add(new Book() { Id = i, Name = $"Book-{i}", Price = 10 *i});
}

Console.WriteLine($"intList:{intList.Count}/{intList.Capacity}");
Console.WriteLine($"bookList:{bookList.Count}/{bookList.Capacity}");
Console.WriteLine("==========================");

var e = intList.GetEnumerator();
Console.WriteLine(e.Current);
while(e.MoveNext())
{
    Console.WriteLine(e.Current);
}
Console.WriteLine(e.Current);



var e1 = bookList.GetEnumerator();
Console.WriteLine(e1.Current);
while(e1.MoveNext())
{
    Console.WriteLine(e1.Current);
}
Console.WriteLine(e1.Current);
