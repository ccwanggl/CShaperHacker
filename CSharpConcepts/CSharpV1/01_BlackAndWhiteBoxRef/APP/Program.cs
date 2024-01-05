// See https://aka.ms/new-console-template for more information

using System;
using System.Windows.Forms;
using libSuperCalculator;

namespace APP
{
    public class Program
    {
        private static void Main()
        {
            Console.WriteLine(Calculator.Add(1, 3));

            Form form = new Form();
            form.ShowDialog();
        }

    }
}
