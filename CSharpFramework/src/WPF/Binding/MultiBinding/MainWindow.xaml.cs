using System.Windows;
using MultiBinding.Component;

namespace MultiBinding
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		private readonly ViewModel model = new ViewModel();
		public MainWindow()
		{
			InitializeComponent();
			DataContext = model;
		}
		private void Button_Click(object sender, RoutedEventArgs e)
		{
			model.Condition1 = true;
			model.Condition2 = true;
		}

		private void MultiBinding_Click(object sender, RoutedEventArgs e)
		{
			model.Condition1 = false;
			model.Condition2 = false;
		}
	}
}
