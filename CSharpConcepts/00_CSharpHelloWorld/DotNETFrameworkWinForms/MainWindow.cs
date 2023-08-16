using System;
using System.Windows.Forms;

namespace DotNETFrameworkWinForms
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnShowHello_Click(object sender, EventArgs e)
        {
            ((Button)sender).Text = @"OK";
            TextBox_ShowHello.Text = @"Hello World";
        }
    }
}
