namespace InternalClass
{
    internal class Student
    {
        public int Id { get; }
        public string Name { get; }

        internal Student(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
