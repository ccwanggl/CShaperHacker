using System.Windows;
using System.Windows.Controls;

namespace XAML
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

        private void Checkbox_Checked(object sender, RoutedEventArgs e)
        {
			LengthText.Text += ((CheckBox)sender).Content;
		}

        private void FinishDropdown_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
			if (NoteText == null)
			{
				return;
			}

			var combo = (ComboBox)sender;
			var value = (ComboBoxItem)combo.SelectedValue;

			NoteText.Text = (string)value.Content;
		}

        private void SupplierNameText_TextChanged(object sender, TextChangedEventArgs e)
        {
			MassText.Text = SupplierNameText.Text;
		}

		
		private void Window_Loaded(object sender, RoutedEventArgs e)
		{
			FinishDropdown_SelectionChanged(FinishDropdown, null);
		}

		private void Apply_Click(object sender, RoutedEventArgs e)
		{
			MessageBox.Show($"The description is: {DescriptionText.Text}");
		}

		private void Reset_Click(object sender, RoutedEventArgs e)
		{
			WeldCheckbox.IsChecked = AssemblyCheckbox.IsChecked = PlasmaCheckbox.IsChecked = LaserCheckbox.IsChecked = PurchaseCheckbox.IsChecked =
				LatheCheckbox.IsChecked = DrillCheckbox.IsChecked = FoldCheckbox.IsChecked = RollCheckbox.IsChecked = SawCheckbox.IsChecked = false;
		}

		private void Refresh_Click(object sender, RoutedEventArgs e)
		{
			//throw new System.NotImplementedException();
		}
    }
}
