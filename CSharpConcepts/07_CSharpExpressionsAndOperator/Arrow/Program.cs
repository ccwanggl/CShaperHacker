using System;

namespace Arrow
{
    class Program
    {
        private static void Main()
        {
            unsafe
            {
                Student stu;

                stu.Id = 1;
                stu.Name = "mohan";

                Student* pStu = &stu;
                pStu->Name = "guoliang";
                Console.WriteLine(stu.Name);
            }
        }
    }

    internal struct Student
    {
        public int Id;
        public string Name;
    }
}
