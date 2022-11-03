using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormHelloWorld_donet_framework
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonSayHello_Click(object sender, EventArgs e)
        {
            textBox_show_hello.Text = @"Hello World from windowsForms based on .NET FrameWork!";
        }
    }
}
