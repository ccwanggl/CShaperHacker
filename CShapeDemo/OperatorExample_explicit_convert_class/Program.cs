namespace OperatorExample_explicit_convert_class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stone stone = new Stone();
            stone.Age = 5000;

            Monkey wukongSun = (Monkey)stone;
            Console.WriteLine(wukongSun.Age);
        }
    }

    class Stone
    {
        public int Age;

        public static explicit operator Monkey(Stone stone)
        {
            Monkey monkey = new Monkey();
            monkey.Age = stone.Age / 500;
            return monkey;
        }
    }

    class Monkey
    {
        public int Age;
    }
}