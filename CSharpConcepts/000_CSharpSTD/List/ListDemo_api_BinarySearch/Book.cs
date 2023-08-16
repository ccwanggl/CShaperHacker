using System.Text.Json;

namespace ListDemo
{
    public class Book:IComparable<Book>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public override string ToString()
        {
            return JsonSerializer.Serialize(this);
        }

        public override bool Equals(object? obj)
        {
            if(obj == null) 
                return false;

            Book other = obj as Book;
            if(other == null) 
                return false;

            if(other.Id == this.Id && other.Name == this.Name && other.Price == this.Price)
                return true;
            return false;
        }

        int IComparable<Book>.CompareTo(Book? other)
        {
            if(other == null) return 1;

            return Id - other.Id;
        }

    }
}