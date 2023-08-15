namespace OperatorExample_implicit_childToBase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Teacher t = new Teacher();
            Human h = t;
            Animal a = h;

            h.Think();
            a.Eat();
        }
    }
    class Animal
    {
        public void Eat()
        {
            Console.WriteLine("Eating...");
        }
    }

    class Human:Animal
    {
        public void Think()
        {
            Console.WriteLine("Who i am?");
        }
    }

    class Teacher:Human
    {
        public void Teach()
        {
            Console.WriteLine("I teach programming.");
        }
    }
}