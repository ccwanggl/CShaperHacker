using System.ComponentModel;

namespace MultiBinding.Component
{
	public sealed class ViewModel : INotifyPropertyChanged
	{
		private bool _condition1 = false;
		public bool Condition1
		{
			get { return _condition1; }
			set
			{
				if (_condition1 == value)
				{
					return;
				}

				_condition1 = value;
				OnPropertyChanged(nameof(Condition1));
			}
		}

		private bool _condition2 = false;
		public bool Condition2
		{
			get { return _condition2; }
			set
			{
				if (_condition2 == value)
				{
					return;
				}

				_condition2 = value;
				OnPropertyChanged(nameof(Condition2));
			}
		}

		public event PropertyChangedEventHandler PropertyChanged;

		private void OnPropertyChanged(string propertyName)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}
	}

}
