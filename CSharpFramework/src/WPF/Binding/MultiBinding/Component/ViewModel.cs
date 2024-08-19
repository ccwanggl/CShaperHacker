using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiBinding
{
	public class ViewModel : INotifyPropertyChanged
	{
		private bool _condition1 = false;
		public bool Condition1
		{
			get { return _condition1; }
			set
			{
				if (_condition1 != value)
				{
					_condition1 = value;
					OnPropertyChanged(nameof(Condition1));
				}
			}
		}

		private bool _condition2 = false;
		public bool Condition2
		{
			get { return _condition2; }
			set
			{
				if (_condition2 != value)
				{
					_condition2 = value;
					OnPropertyChanged(nameof(Condition2));
				}
			}
		}

		public event PropertyChangedEventHandler PropertyChanged;

		protected virtual void OnPropertyChanged(string propertyName)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}
	}

}
