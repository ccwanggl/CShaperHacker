namespace OperatorExample_arrow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            unsafe
            {
                Student stu;

                stu.ID = 1;
                stu.Name = "mohan";

                Student* pStu = &stu;
                pStu->Name = "guoliang";
                Console.WriteLine(stu.Name);
            }
        }
    }


    struct Student
    {
        public int ID;
        public string Name;
    }

}