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

namespace AttachedEvent
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
			this.gridMain.AddHandler(Student.NameChangedEvent, new RoutedEventHandler(this.StudentNameChangedHandler));
		}

		private void button1_Click(object sender, RoutedEventArgs e)
		{
			Student stu = new Student() { Id = 101, Name = "Tom" };
			RoutedEventArgs args = new RoutedEventArgs(Student.NameChangedEvent, stu);
			this.button1.RaiseEvent(args);
		}

		private void StudentNameChangedHandler(object sender, RoutedEventArgs e)
		{
			Student stu = e.OriginalSource as Student;
			MessageBox.Show(string.Format("Student {0} has changed name to {1}", stu.Id, stu.Name));
		}
	}
}
