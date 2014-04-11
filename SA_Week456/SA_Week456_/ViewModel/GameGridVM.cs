using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SA_Week456_.Model;
using System.Windows;

namespace SA_Week456_.ViewModel
{
	class GameGridVM
	{
		public GameGridVM()
		{
			for (int y = 0; y < 9; y++)
			{
				for (int x = 0; x < 9; x++)
				{
					int value;
					Spel.Sudoku.get(x, y, out value);
				}
			}
		}
	}
}
