namespace ClassExample_Definition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Type t = typeof(Student);

#if REFLECTION

            object o = Activator.CreateInstance(t, 1, "Guoliang");
            //Student student = (Student)o;
            Student student = o as Student;
#else
            dynamic student = Activator.CreateInstance(t, 1, "Guoliang");

#endif

            Console.WriteLine(student.Name);

        }
    }

    internal class Student
    {

        public static int Amount { get; set; }
        
        // static ctor used for init the static member
        static Student()
        {
            Amount = 100;
        }


        // use to init the instance member
        public Student(int id, string name)
        {
            this.Id = id;
            this.Name = name;
            Amount++;
        }

        ~Student()
        {
            Console.WriteLine("Bye bye! Release the system resources ...");
            Amount--;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public void Report()
        {
            Console.WriteLine($"I'm #{Id} student, my name is {Name}"); 
        }
    }
}