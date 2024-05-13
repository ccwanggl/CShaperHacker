using System;
using System.Collections.Generic;
using System.Data;
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

namespace ADO.NETAsBindingSource
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
			DataTable dt = new DataTable ("myTable");
			dt.Columns.Add ("Id",  typeof (int));	
			dt.Columns.Add ("Name",  typeof (string));	
			dt.Columns.Add ("Age",  typeof (int));
			dt.Rows.Add(1, "Tim", 29);
			dt.Rows.Add (6, "Tim", 29);
			dt.Rows.Add (2, "Tom" ,28);
			dt.Rows.Add (3, "Tony",27);
			dt.Rows.Add (4, "Emily", 25);

			this.listBoxStudents.DisplayMemberPath = "Name";
			this.listBoxStudents.ItemsSource = dt.DefaultView;
		}

		private void Button_Click2(object sender, RoutedEventArgs e)
		{
			DataTable dt = new DataTable ("myTable");
			dt.Columns.Add ("Id",  typeof (int));	
			dt.Columns.Add ("Name",  typeof (string));	
			dt.Columns.Add ("Age",  typeof (int));
			dt.Rows.Add(1, "Tim", 29);
			dt.Rows.Add (6, "Tim", 29);
			dt.Rows.Add (2, "Tom" ,28);
			dt.Rows.Add (3, "Tony",27);
			dt.Rows.Add (4, "Emily", 25);

			this.listViewStudents.ItemsSource = dt.DefaultView;
		}

		private void Button_Click3(object sender, RoutedEventArgs e)
		{
			DataTable dt = new DataTable ("myTable");
			dt.Columns.Add ("Id",  typeof (int));	
			dt.Columns.Add ("Name",  typeof (string));	
			dt.Columns.Add ("Age",  typeof (int));
			dt.Rows.Add(1, "Tim", 29);
			dt.Rows.Add (6, "Tim", 29);
			dt.Rows.Add (2, "Tom" ,28);
			dt.Rows.Add (3, "Tony",27);
			dt.Rows.Add (4, "Emily", 25);

			this.listViewStudents2.DataContext = dt;
			this.listViewStudents2.SetBinding(ListView.ItemsSourceProperty, new Binding());
		}
    }

	public class Student
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public int Age { get; set; }
	}
}
