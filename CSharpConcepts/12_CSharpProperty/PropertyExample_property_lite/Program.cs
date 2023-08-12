namespace PropertyExample_property_lite
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Student student = new Student();
                student.Age = 100;
                Console.WriteLine(student.Age);
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }

    class Student
    {
        private int age;
        public int Age { get => age; set => age = value; }
    }
}