using System;
using System.IO;
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

namespace TreeViews
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
    {
	#region Constructor
        public MainWindow()
        {
            InitializeComponent();
        }
	#endregion

	#region On Loaded
		/// <summary>
		/// when  the application first opens
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		/// <exception cref="NotImplementedException"></exception>
		
		private void Window_Loaded(object sender, RoutedEventArgs e)
		{
			foreach (var derive in Directory.GetLogicalDrives() )
			{
				var item = new TreeViewItem
				{
					Header = derive,
					Tag = derive
				};

				item.Items.Add(null);
				item.Expanded += Folder_Expanded;

				FolderView.Items.Add( item );
			}
		}
		private static void Folder_Expanded(object sender, RoutedEventArgs e)
		{
			var item = (TreeViewItem)sender;

			// note: If the item only contains the dummy data
			if (item.Items.Count != 1 || item.Items[0] != null)
			{
				return;
			}

			// note: clear dummy data
			item.Items.Clear();

			// note Get folder name
			var fullPath = (string)item.Tag;
			var directories = new List<string>();

			try
			{
				var dirs = Directory.GetDirectories(fullPath);

				if (dirs.Length != 0)
				{
					directories.AddRange(dirs);
				}
			}
			catch
			{
				// ignored
			}

			// For each directory ...
			directories.ForEach(directoryPath =>
			{
				// note Create directory item
				var subItem = new TreeViewItem()
				{
					Header = GetFileFolderName(directoryPath),
					Tag = directoryPath
				};

				subItem.Items.Add(null);
				subItem.Expanded += Folder_Expanded;

				item.Items.Add(subItem);
				
				});
		}
		private void SubItem_Expanded(object sender, RoutedEventArgs e)
		{
			throw new NotImplementedException();
		}
		private static string GetFileFolderName(string path)
		{
			if(string.IsNullOrEmpty(path))
			{
				return string.Empty;
			}

			var normalizedPath = path.Replace('/', '\\');
			var lastIndex = normalizedPath.LastIndexOf('\\');

			return lastIndex <= 0 ? path : path.Substring(lastIndex + 1);
		}
		#endregion
	}
}
