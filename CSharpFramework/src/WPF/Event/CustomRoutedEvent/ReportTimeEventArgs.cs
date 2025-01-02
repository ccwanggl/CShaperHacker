using System;
using System.Windows;

namespace CustomRoutedEvent
{
	internal class ReportTimeEventArgs : RoutedEventArgs
	{
		public ReportTimeEventArgs(RoutedEvent routedEvent, object source)
			: base(routedEvent, source) { }

		public DateTime ClickTime { get; set; }
	}
}
