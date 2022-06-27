namespace ParametersExample_RefValue_SideEffect_NotNew
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student outterStu = new Student() { Name = "Tim" };
            Console.WriteLine("HashCode={0}, Name={1}", outterStu.GetHashCode(), outterStu.Name);
            Console.WriteLine("--------------------------");
            IWantSideEffect(ref outterStu);
            Console.WriteLine("HashCode={0}, Name={1}", outterStu.GetHashCode(), outterStu.Name);
        }

        static void IWantSideEffect(ref Student stu)
        {
            stu.Name = "Tom";
            Console.WriteLine("HashCode={0}, Name={1}", stu.GetHashCode(), stu.Name);
        }
    }

    class Student
    {
        public string Name { get; set; }
    }
}