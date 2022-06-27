namespace DataMemberExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student stu1 = new Student();
            stu1.Age = 40;
            stu1.Score = 90;

            Student stu2 = new Student();
            stu2.Age = 24;
            stu2.Age = 60;

            Student.ReportAmount();
        }
    }

    class Student
    {
        public int Age;
        public int Score;

        public static int AverageAge;
        public static int AverageScore;
        public static int Amount;

        public Student()
        {
            Student.Amount++;
        }

        public static void ReportAmount()
        {
            Console.WriteLine("The Amount {0}", Amount);
        }
        public static void ReportAverageAge()
        {
            Console.WriteLine("The Amount {0}", Amount);
        }
        public static void ReportAverageScore()
        {
            Console.WriteLine("The Amount {0}", Amount);
        }
    }
}