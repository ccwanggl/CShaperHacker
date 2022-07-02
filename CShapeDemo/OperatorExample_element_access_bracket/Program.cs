namespace OperatorExample_element_access_bracket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Student> stuDic = new Dictionary<string, Student>();
            for (int i = 0; i < 100; i++)
            {
                Student stu = new Student();
                stu.Name = "s_" + i.ToString();
                stu.Score = 100 + i;
                stuDic.Add(stu.Name, stu); 
            }

            Student number6 = stuDic["s_6"];
            Console.WriteLine(number6.Score);
        }
    }

    class Student
    {
        public string Name;
        public int Score;
    }
}