using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;

namespace ControlBindingDirAndDataUpdate
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();

			var binding = new Binding
			{
				Source = Slider2,
				// NOTE The type of the binding Path is PropertyPath, not string.
				Path = new PropertyPath("Value"),
				UpdateSourceTrigger = UpdateSourceTrigger.LostFocus,
				Mode = BindingMode.TwoWay,
				NotifyOnTargetUpdated = true,
				NotifyOnSourceUpdated = true
			};


			//BindingOperations.SetBinding(this.textBox2, TextBox.TextProperty, binding);
			TextBox2.SetBinding(TextBox.TextProperty, binding);

			TextBox2.SourceUpdated += OnSourceUpdated;
			Slider2.TargetUpdated += OnTargetUpdated;
		}

		private void OnSourceUpdated(object sender, DataTransferEventArgs e) => Debug.WriteLine("SourceUpdated\n");

		private void OnTargetUpdated(object sender, DataTransferEventArgs e)
		{
			Debug.WriteLine("TargetUpdated\n");
		}
	}
}
