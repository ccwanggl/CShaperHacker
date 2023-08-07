namespace DataMemberExample_field_declaration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }

    struct Color
    {
        public int Red;
        public int Green;
        public int Blue;    
    }

    class Brush
    {

#if UNDEF
        //Method 1
        public static readonly Color DefaultColor = new Color() { Red = 0, Green = 0, Blue = 0 };

#else
        //Method 2

        public static readonly Color DefaultColor;

        static Brush()
        {
            Brush.DefaultColor = new Color() {Red = 0, Green = 0,Blue = 0};
        }
#endif
    }
}