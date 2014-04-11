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
using Sudoku;
using SA_Week456_.ViewModel;

namespace SA_Week456_
{
	public partial class MainWindow : Window
	{
		public MainWindowVM MainVM
		{
			get;
			set;
		}

		public MainWindow()
		{
			InitializeComponent();
			MainVM = new MainWindowVM();
			DataContext = MainVM;

			int i = 0;
			int x = 0;
			int y = 0;

			foreach (Object o in GameGrid.Children)
			{
				if ((o is TextBox) == false)
				{
					continue; //Skip rectangles
				}

				TextBox box = (TextBox)o;

				VakVM vakVM = VM.GetVakVM(y, x); // x and y swapped, because the GameGrid.Children collection is filled the opposite

				box.DataContext = vakVM;

				x = (x + 1) % 9;
				
				if (x == 0 && i > 0 )
				{
					y++;
				}

				i++;
			}
		}

		private void OKButton_Click(object sender, RoutedEventArgs e)
		{
			if (GetalX.SelectedItem != null && GetalY.SelectedItem != null && getalValue.SelectedItem != null)
			{
				MainVM.OKClick
				(
					int.Parse(GetalX.SelectedItem.ToString()) - 1, 
					int.Parse(GetalY.SelectedItem.ToString()) - 1,
					int.Parse(getalValue.SelectedItem.ToString())
				);
			}
			else
			{
				MessageBox.Show("Error");
			}
		}

		private void GetalX_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{

		}
	}
}