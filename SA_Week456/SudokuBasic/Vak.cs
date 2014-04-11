using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.ComponentModel;

namespace SudokuBasic
{
	public class Vak : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;

		public void NotifyPropertyChanged(String info)
		{
			if (PropertyChanged != null)
			{
				PropertyChanged(this, new PropertyChangedEventArgs(info));
			}
		}

		public int X
		{
			get;
			set;
		}

		public int Y
		{
			get;
			set;
		}

		public int Value
		{
			get
			{
				int cellValue;
				
				Spel.Sudoku.get(X+1, Y+1, out cellValue);
				
				return cellValue;
			}

			set
			{
				int canAdapt;
				int isValid;

				Spel.Sudoku.set(X+1, Y+1, value, out canAdapt);
				Spel.Sudoku.isValid(out isValid);

				if (isValid == 1)
				{
					Console.WriteLine("IsValid!");
				}
				else
				{
					Console.WriteLine("Invalid!" + value);
				}
	
				NotifyPropertyChanged("Value");
			}
		}

		public Vak(int x, int y)
		{
			X = x;
			Y = y;

		}
	}
}
