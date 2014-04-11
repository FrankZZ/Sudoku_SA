using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Windows;
using SudokuBasic;
using SA_Week456_.ViewModel;


namespace SA_Week456_
{
	public partial class App : Application
	{

		public App()
		{
			VM.Initialize();

			MainWindow window = new MainWindow();

			window.Show();
		}
	}
}
