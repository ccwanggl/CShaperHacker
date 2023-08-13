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

foreach (var item in intList)
{
    Console.WriteLine(item);
}

foreach (var item in bookList)
{
    item.Price++;
    Console.WriteLine(item);
}

int sum = 0;
foreach (var item in intList)
{
    sum += item;
}
Console.WriteLine("ForEach algorithm {0}",sum);

sum = 0;

intList.ForEach(val => sum += val);
Console.WriteLine("ForEach method {0}",sum);
