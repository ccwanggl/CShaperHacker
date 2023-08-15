using System;

namespace ExplicitConvertClass
{
    internal class Program
    {
        private static void Main()
        {
            Stone stone = new Stone();
            stone.Age = 5000;
            stone.Mass = 30;

            Monkey wukongSun = (Monkey)stone;
            Console.WriteLine(wukongSun.Age);

            Gold gold = stone;
            Console.WriteLine(gold.Mass);
        }
    }

    internal class Stone
    {
        public int Age;
        public double Mass;

        public static explicit operator Monkey(Stone stone)
        {
            Monkey monkey = new Monkey();
            monkey.Age = stone.Age / 500;
            return monkey;
        }

        public static implicit operator Gold(Stone  stone)
        {
            Gold gold = new Gold();
            gold.Mass = stone.Mass;
            return gold;
        }
    }

    internal class Monkey
    {
        public int Age;
    }

    internal class Gold
    {
        public double Mass;
    }
}
