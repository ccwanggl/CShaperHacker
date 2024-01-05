using System;
using System.Windows;
using System.Windows.Forms;
using System.Timers;


namespace EventExample_Click
{
    class MyForm : Form
    {
        internal void FormClicled(object sender, EventArgs e)
        {
            this.Text = DateTime.Now.ToString();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            MyForm form = new MyForm();
            form.Click += form.FormClicled;
            form.ShowDialog();
        }
    }
}
