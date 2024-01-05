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

        private void Button1_Click(object sender, RoutedEventArgs e)
        {

            double x = System.Convert.ToDouble(tb1.Text);
            double y = System.Convert.ToDouble(tb2.Text);
            double result = x + y;
            this.tb3.Text = result.ToString();
        }
        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            double.TryParse(tb4.Text, out var a);
            var b = double.Parse(tb5.Text);

            tb6.Text = (a + b).ToString(CultureInfo.InvariantCulture);
        }
    }
}
