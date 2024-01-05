using System.Windows;

namespace DotNETFrameworkWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MsgBtn_Click(object sender, RoutedEventArgs e)
        {
            ShowMsg.Text = "Hello World";
        }
    }
}
