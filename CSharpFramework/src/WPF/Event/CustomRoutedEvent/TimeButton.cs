using System;
using System.Windows;
using System.Windows.Controls;

namespace CustomRoutedEvent
{
	internal class TimeButton : Button
	{
		public static readonly RoutedEvent ReportTimeEvent = EventManager.RegisterRoutedEvent
			("ReportTime", RoutingStrategy.Bubble, typeof(EventHandler<ReportTimeEventArgs>), typeof(TimeButton));

		public event RoutedEventHandler ReportTime
		{
			add { AddHandler(ReportTimeEvent, value); }
			remove { RemoveHandler(ReportTimeEvent, value); }
		}

		protected override void OnClick()
		{
			base.OnClick();
			ReportTimeEventArgs args = new ReportTimeEventArgs(ReportTimeEvent, this);
			args.ClickTime = DateTime.Now;
			RaiseEvent(args);
		}
	}
}
