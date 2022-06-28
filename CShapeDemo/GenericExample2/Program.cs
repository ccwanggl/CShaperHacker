namespace GenericExample2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student<int> student = new Student<int>(); 
            student.Id = 101;
            student.Name = "Guoliang";


            Student student1 = new Student();
            student1.Id = 100000000000001;
            student1.Name = "Mohan";
        }
    }

    interface IUnique<TId>
    {
        TId Id { get; set; }
    }

    class Student<TId> : IUnique<TId>
    {
        public TId Id { get; set ; }
        public string Name { get ; set ; }
    }

    class Student:IUnique<ulong>
    {
        public ulong Id { get; set; }
        public string Name { get ; set ; }
    }
}