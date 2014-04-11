using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Windows;
using SA_Week3.Classes;
using SA_Week3.Utils;

namespace SA_Week3
{
	/// <summary>
	/// Interaction logic for App.xaml
	/// </summary>
	public partial class App : Application
	{
		private ISubject _subject;

		public App()
		{
			_subject = new ConcreteSubject();
			AddView();
			AddView();
			AddView();

			new MainWindow((ConcreteSubject)_subject).Show();
		}

		private void AddView()
		{
			ConcreteObserver observer = new ConcreteObserver();
			_subject.Attach(observer);

			new ObserverView(observer).Show();
		}
	}
}
