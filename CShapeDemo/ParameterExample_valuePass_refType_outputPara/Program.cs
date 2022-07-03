namespace ParameterExample_valuePass_refType_outputPara
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student stu = null;
            bool b = StudentFactory.Create("guoliang", 34, out stu);
            if(b)
            {
                Console.WriteLine("Student {0}, age is {1}.",stu.Name , stu.Age);
            }
        }
    }

    class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }

    class StudentFactory
    {
        public static bool Create(string name, int age, out Student result)
        {
            result = null;

            if(string.IsNullOrEmpty(name))
            {
                return false;
            }
            if(age > 40)
            {
                return false;
            }

            result = new Student() { Name = name,Age = age };
            return true;
        }
    }
}