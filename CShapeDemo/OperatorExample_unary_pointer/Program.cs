namespace OperatorExample_unary_pointer
{ 
    internal class Program
    {
        static void Main(string[] args)
        {
            unsafe
            {
                Student stu;
                stu.Id = 1;
                stu.Name = "guoliang";

                Student* pStu = &stu;
                (*pStu).Id = 2;
                Console.WriteLine(pStu->Name); 
            }
        }
    }
    struct Student
    {
        public int Id;
        public string Name;
    }
}