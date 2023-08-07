namespace GenericExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Apple apple = new Apple() { Color = "Red" };
            Book book = new Book() { Name = "New Book" };

            Box box1 = new Box() { Cargo = apple };
            Console.WriteLine((box1.Cargo as Apple)?.Color);

            GenericBox<Apple> genericBox = new GenericBox<Apple> { Cargo = apple };
            Console.WriteLine(genericBox.Cargo.Color);

        }

    }

    class Book
    {
        public string Name { get; set; }
    }

    class Apple
    {
        public string Color { get; set; }
    }

    class Box
    {
        public Object Cargo { get; set; } 
    }
    class GenericBox<TCargo>
    {
        public TCargo Cargo { get; set; }
    }
}