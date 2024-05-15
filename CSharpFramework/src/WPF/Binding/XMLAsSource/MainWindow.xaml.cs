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
using System.Xml;

namespace XMLAsSource
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

		private void Button_Click1(object sender, RoutedEventArgs e)
		{
			XmlDocument doc = new XmlDocument();
			doc.Load(@"RawData.xml");

			XmlDataProvider xdp1 = new XmlDataProvider();
			xdp1.Document = doc;

			// xdp.Source = new Uri(@"RawData.xml");
			xdp1.XPath = @"/StudentList/Student";

			this.listViewStudents1.DataContext = xdp1;
			this.listViewStudents1.SetBinding(ListView.ItemsSourceProperty, new Binding());

        }

		private void Button_Click2(object sender, RoutedEventArgs e)
		{
			string appPath = System.IO.Path.GetDirectoryName( System.Reflection.Assembly.GetExecutingAssembly().CodeBase);
			XmlDataProvider xdp2 = new XmlDataProvider();
			xdp2.Source = new Uri(appPath + @"\RawData.xml");
			xdp2.XPath = @"/StudentList/Student";

			this.listViewStudents2.DataContext = xdp2;
			this.listViewStudents2.SetBinding(ListView.ItemsSourceProperty, new Binding());
		}
    }
}
