namespace ParameterExample_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CalculateSum(1, 2, 3));

            string str = "Tim;Tom,Amy.Lisa";
            var result = str.Split(';', '.', ',');
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }

        static int CalculateSum(params int[] intArray)
        {
            int sum = 0;
            foreach (var item in intArray)
            {
                sum += item;
            }   

            return sum;
        }
    }
}