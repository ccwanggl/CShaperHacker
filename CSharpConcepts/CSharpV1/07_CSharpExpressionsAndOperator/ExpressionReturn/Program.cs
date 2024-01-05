using System;
using System.Windows.Forms;

namespace ExpressionReturn
{
    class Program
    {
        static public void Main(string[] args)
        {
            int x;
            x =100;

            // NOTE: Get Object
            var form = new Form();

            // NOTE: Get method
            Action myAction = new Action(Console.WriteLine);

            //NOTE: Get namespace
            System.Windows.Forms.Form form2 = new Form();
        }
    }
}
