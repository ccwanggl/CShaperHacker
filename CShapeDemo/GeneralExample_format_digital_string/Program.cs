namespace GeneralExample_format_digital_string
{
    //note(guoliang): {index, alignment:format}
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 500;

            Console.WriteLine($"The value: {i}.");
            Console.WriteLine($"The value: {i:C}.");

            Console.WriteLine($"|{i,10}|");
            Console.WriteLine($"|{i,-10}|");

            double d = 12.345678;
            Console.WriteLine($"{d,-10:G} -- General");
            Console.WriteLine($"{d,-10} -- Default, same as General");
            Console.WriteLine($"{d,-10:F4} -- Fixed Point, 4 dec places");
            Console.WriteLine($"{d,-10:C} -- Currency");
            Console.WriteLine($"{d,-10:E3} -- Sci. Notation, 3 dec places");
            Console.WriteLine($"{1194719,-10:x} -- Hexadecimal integr");
            Console.WriteLine("{0,-10:x} -- Hexadecimal integr", 1194719);

        }
    }
}