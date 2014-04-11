using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SudokuBasic;
using System.ComponentModel;

namespace SA_Week456_.ViewModel
{
	public class VakVM : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;
		public void NotifyPropertyChanged(Object o, PropertyChangedEventArgs args)
		{
			if (PropertyChanged != null)
			{
				PropertyChanged(this, args);
			}
		}

		private SudokuBasic.Vak _vak;
		public SudokuBasic.Vak Vak
		{
			get
			{
				return _vak;
			}

			set
			{
				_vak = value;
				value.PropertyChanged += new PropertyChangedEventHandler(NotifyPropertyChanged);
			}
		}

		public String Value
		{
			get
			{
				if (IntValue != 0)
				{
					return IntValue.ToString();
				}
				
				return String.Empty;
			}
		}

		public int IntValue
		{
			get
			{
				return Vak.Value;
			}
			set 
			{
				Vak.Value = value;
			}
		}

		public VakVM()
		{
		
		}

		
	}
}
