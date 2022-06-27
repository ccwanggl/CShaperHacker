using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TypeInCSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Form f = new Form();

            //enum test
            f.WindowState = FormWindowState.Maximized;
            f.ShowDialog();

            Student.Amount = 1000;

            int x = 100;
            object obj = x;

            int y = (int) obj;

     
        }
    }


    enum Color
    {
        RED = 0,
        GREEN = 1,
        BLUE = 2,
    }

    //class
    class Student
    {
        public static int Amount = 0;

        public int Age;
        public string Name;

        public double Add(ref double a, double b)
        {
            return a + b;
        }
        public int Add(out int a, int b)
        {
            a = 0;
            return  a + b;
        }
    }
}
