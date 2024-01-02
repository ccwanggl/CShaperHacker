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

var seg = intList.GetRange(1, 2);
for (int i = 0; i < seg.Count; i++)
{
    seg[i]++;
}
Console.WriteLine(String.Join(",", seg));
Console.WriteLine(String.Join(",", intList));


//浅拷贝

var bookSeg = bookList.GetRange(1, 2);
for (int i = 0; i < bookSeg.Count; i++)
{
    bookSeg[i].Price++;
}

Console.WriteLine(String.Join(",", bookSeg));
Console.WriteLine(String.Join(",", bookList));
