using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace HelloWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.button1.Click += delegate (object sender, RoutedEventArgs e) {
                this.textBox.Text = "Hello, degegate";
            };

            this.button2.Click += (object sender, RoutedEventArgs e) =>
            {
                this.textBox2.Text = "Hello, lambda";
            };
        }
    }
}
