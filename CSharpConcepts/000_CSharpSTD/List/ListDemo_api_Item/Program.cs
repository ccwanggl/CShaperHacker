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

Console.WriteLine(intList[0]);
Console.WriteLine(intList[intList.Count - 1]);

Console.WriteLine(bookList[0]);
Console.WriteLine(bookList[bookList.Count - 1]);

intList[0] = 1000;
Console.WriteLine(String.Join(",", intList));

for (int i = 0; i < intList.Count; i++)
{
    if(intList[i] % 100== 0)
    {
        intList.Insert(i,intList[i] - 1);
        i++;
    }
}

Console.WriteLine(String.Join(",", intList));
for (int i = 0; i < intList.Count; i++)
{
    if(intList[i] % 100== 0)
    {
        intList.RemoveAt(i);
        i--;
    }
}
Console.WriteLine(String.Join(",", intList));
