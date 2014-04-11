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
using System.Windows.Shapes;
using SA_Week3.Utils;
using SA_Week3.Classes;

namespace SA_Week3
{
	/// <summary>
	/// Interaction logic for ObserverView.xaml
	/// </summary>
	public partial class ObserverView : Window
	{
		public ObserverView(Label label)
		{
			InitializeComponent();

			grid.Children.Add(label);
		}
	}
}
