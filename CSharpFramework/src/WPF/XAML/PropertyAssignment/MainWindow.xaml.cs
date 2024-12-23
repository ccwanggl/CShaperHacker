using System.Windows;
using System.Windows.Media;

namespace PropertyAssignment
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

			SolidColorBrush sBrush = new SolidColorBrush
			{
				Color = Colors.Aqua
			};
			this.Rectangle3.Fill = sBrush;
        }
    }
}
