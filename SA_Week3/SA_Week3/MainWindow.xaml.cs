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
using SA_Week3.Utils;
using SA_Week3.Classes;

namespace SA_Week3
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		private ConcreteSubject _subject; 

		public MainWindow(ConcreteSubject subject)
		{
			_subject = subject;

			InitializeComponent();
		}

		private void button1_Click(object sender, RoutedEventArgs e)
		{
			_subject.refresh();
		}
	}
}
