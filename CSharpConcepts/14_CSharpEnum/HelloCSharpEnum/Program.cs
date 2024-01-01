using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloCSharpEnum
{
    enum TraficLight
    {
        Green,
        Red,
        Yellow
    }
    [Flags]
    enum CardDeckSettings : uint
    {
        SingleDeck = 0x01,
        LargePictures = 0x02,
        FancyNumber = 0x04,
        Animation = 0x08
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            TraficLight light = TraficLight.Green;
            Console.WriteLine($"{light}, \t {(int)light}");

            CardDeckSettings ops;
            ops = CardDeckSettings.FancyNumber;
            Console.WriteLine(ops.ToString());

            ops = CardDeckSettings.FancyNumber | CardDeckSettings.Animation;
            Console.WriteLine(ops.ToString());
        }
    }
}
