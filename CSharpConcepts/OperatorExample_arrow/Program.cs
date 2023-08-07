using OperatorExample_arrow;

unsafe
{
    Student stu;

    stu.ID = 1;
    stu.Name = "mohan";

    Student* pStu = &stu;
    pStu->Name = "guoliang";
    Console.WriteLine(stu.Name);
}
namespace OperatorExample_arrow
{
    struct Student
    {
        public int ID;
        public string Name;
    }

}