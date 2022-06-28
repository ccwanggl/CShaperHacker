using ListDemo;

List<double> list1 = new List<double> { 100.0, 200.0, 300.0, 400.0, 100.0, 200.0, 300.0, 400.0 };

Book book1 = new Book { Id = 1, Name = "Book-1", Price = 10 }, book6 = book1;
Book book2 = new Book { Id = 2, Name = "Book-2", Price = 20 };
Book book3 = new Book { Id = 3, Name = "Book-3", Price = 30 };
Book book4 = new Book { Id = 4, Name = "Book-4", Price = 40 };
Book book5 = new Book { Id = 1, Name = "Book-1", Price = 10 };

List<Book> list2 = new List<Book> { book1, book2, book3, book4 };

Console.WriteLine("==================");

Console.WriteLine(list1.IndexOf(100));
Console.WriteLine(list1.IndexOf(100,1));
Console.WriteLine(list1.IndexOf(100,0,list1.Count));

int i = -1;
while(true)
{
    i = list1.IndexOf(100, i+1);
    if (i == -1) break;
    Console.WriteLine(i);
}
