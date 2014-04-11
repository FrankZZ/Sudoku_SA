using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SA_Week2
{
	public partial class MainWindow : Window
	{
		const int MAX_ENTITIES = 11;

		private bool[] _baChoice;
		private Task _task;

		public MainWindow()
		{
			_baChoice = new bool[MAX_ENTITIES];
			_task = new Task();

			InitializeComponent();
		}

		private void startButton_Click(object sender, RoutedEventArgs e)
		{
			_baChoice[0] = (bool) linkerOog.IsChecked;
			_baChoice[1] = (bool) rechterOog.IsChecked;
			_baChoice[2] = (bool) linkerWenkbrauw.IsChecked;
			_baChoice[3] = (bool) rechterWenkbrauw.IsChecked;
			_baChoice[4] = (bool) neus.IsChecked;
			_baChoice[5] = (bool) mond.IsChecked;
			_baChoice[6] = (bool) roodOmDeMond.IsChecked;
			_baChoice[7] = (bool) blosOpDeWangen.IsChecked;
			_baChoice[8] = (bool) strikje.IsChecked;
			_baChoice[9] = (bool) hoedje.IsChecked;
			_baChoice[10] = (bool) haar.IsChecked;
			
			showClown();
		 }

		private void showClown()
		{
			canvas.Children.Clear();
			_task.go(_baChoice, canvas);
		}
	}
}