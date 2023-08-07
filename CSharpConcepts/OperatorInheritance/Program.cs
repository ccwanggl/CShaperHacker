namespace OperatorInheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.Report();

            CsStudent csStudent = new CsStudent();
            csStudent.Report();
        }
    }

    class Student
    {
        public void Report()
        {
            Console.WriteLine("I'm a student"); 
        }
    }

    class CsStudent:Student
    {
        // 子类隐藏了父类的方法，不值得推广的
        //note(guoliang): Use new to hide the base class method
        public new void Report()
        {
            Console.WriteLine("I'm a cs student");
        }
    }
}