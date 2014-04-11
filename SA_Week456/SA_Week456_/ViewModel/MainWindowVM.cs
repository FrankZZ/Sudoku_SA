using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Windows;

namespace SA_Week456_.ViewModel
{
	public class MainWindowVM
	{
		public BindingList<VakVM> Vakken
		{
			get;
			set;
		}

		public int[] Positions
		{
			get;
			set;
		}

		public MainWindowVM()
		{
			Positions = new int[9];

			for (int i = 0; i < Positions.Length; i++)
			{
				Positions[i] = i + 1;
			}

			Vakken = new BindingList<VakVM>();
		}

		public void OKClick(int x, int y, int value)
		{
			VM.GetVakVM(x, y).IntValue = value;
			Console.WriteLine("OK");
		}

		public void LoadClick()
		{
			try
			{
				VM.Load();
				MessageBox.Show("Game loaded");
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		public void SaveClick()
		{
			try
			{
				VM.Save();
				MessageBox.Show("Game saved");
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		public void HintClick()
		{
			try
			{
				VM.Hint();
				MessageBox.Show("Hint given");
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
	}
}