namespace ParametersExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student stu = new Student() { Name = "Tim" };
            Console.WriteLine("HashCode={0},{1}",stu.GetHashCode(), stu.Name); 

            UpdateObject(stu);
            Console.WriteLine("HashCode={0},{1}",stu.GetHashCode(), stu.Name); 
        }


        static void UpdateObject(Student stu)
        {
            stu.Name = "Tom";
            Console.WriteLine("HashCode={0},{1}", stu.GetHashCode(), stu.Name);
        }

    }

    class Student
    {
        public string? Name { get; set; } 
    }

}