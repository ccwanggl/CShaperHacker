using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassAndInstance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Form form = new Form();
            form.Text = "New form from System.Windows.Forms";
            form.ShowDialog();
        }
    }
}
