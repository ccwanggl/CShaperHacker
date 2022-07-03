namespace PropertyExample_readonly_property
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.Age = 18;
            Console.WriteLine(student.CanWork);
        }
    }

    class Student
    {
        private int age;

        public int Age {
            get { return age; }
            set { age = value; }
        }
        
        public bool CanWork {
            get {
                if(this.age >= 16)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}