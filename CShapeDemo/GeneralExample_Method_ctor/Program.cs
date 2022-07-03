namespace GeneralExample_Method_ctor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student(2, "Guoliang");
            Console.WriteLine(student.Name);
        }
    }

    class Student
    {
        public int ID;
        public string Name;

        public Student()
        {
            this.ID = -1;
            this.Name = "No name";
        }

        public Student(int id, string name )
        {
            this.ID = id;
            this.Name = name;
        }
    }
}