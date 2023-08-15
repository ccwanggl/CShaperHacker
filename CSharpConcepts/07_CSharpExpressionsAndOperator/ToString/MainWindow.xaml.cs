using System.Globalization;
using System.Windows;

namespace ToString
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double.TryParse(tb1.Text, out var x);
            var y = double.Parse(tb2.Text);

            tb3.Text = (x + y).ToString(CultureInfo.InvariantCulture);
        }
    }
}
