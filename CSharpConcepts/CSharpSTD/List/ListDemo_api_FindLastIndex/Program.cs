using ListDemo;

List<double> list1 = new List<double> { 80.0, 70.0, 60.0, 50.0, 40.0, 30.0, 20.0, 10.0 };

Book book1 = new Book { Id = 1, Name = "Book-1", Price = 10 };
Book book2 = new Book { Id = 2, Name = "Book-2", Price = 20 };
Book book3 = new Book { Id = 3, Name = "Book-3", Price = 30 };
Book book4 = new Book { Id = 4, Name = "Book-4", Price = 40 };
Book book5 = new Book { Id = 1, Name = "Book-1", Price = 10 };

List<Book> list2 = new List<Book> { book1, book2, book3, book4 };

Console.WriteLine("==================");
Console.WriteLine(list1.FindLastIndex(e => e % 3 == 0));
Console.WriteLine(list1.FindLastIndex(list1.Count - 4,e => e % 3 == 0));
Console.WriteLine(list1.FindLastIndex(list1.Count -1, 3,e => e % 3 == 0));
