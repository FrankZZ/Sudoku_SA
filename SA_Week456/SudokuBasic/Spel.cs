using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Sudoku;

namespace SudokuBasic
{
	public class Spel : ISpel
	{
		public static IGame Sudoku = new Sudoku.Game();
		public Vak[,] Vakken;

		public Spel()
		{
			Initialize();
		}

		public void Initialize()
		{

			Vakken = new Vak[9, 9];

			Spel.Sudoku.create();

			for (int x = 0; x < 9; x++)
			{
				for (int y = 0; y < 9; y++)
				{
					Vakken[x, y] = new Vak(x, y);
				}
			}

			for (int i = 0; i < 40; i++)
			{
				try
				{
					Hint();
				}
				catch (Exception ex)
				{
					Console.WriteLine(ex.ToString());
				}
			}

		}

		public void Hint()
		{
			int hintPossible;
			int hintValue;
			int xx;
			int yy;

			Spel.Sudoku.hint(out hintPossible, out xx, out yy, out hintValue);

			if (hintPossible == 1)
			{
				Vakken[xx - 1, yy - 1].Value = hintValue;
			}
			else
				throw (new Exception("No hints possible"));
		}

		public void Load()
		{
			int canRead;
			Sudoku.read(out canRead);

			if (canRead < 1)
				throw (new Exception("Cannot load game"));

			for (int x = 0; x < 9; x++)
			{
				for (int y = 0; y < 9; y++)
				{
					if (Vakken[x, y] != null)
						Vakken[x, y].NotifyPropertyChanged("Value");

				}
			}
		}

		public void Save()
		{
			int canWrite;
			Sudoku.write(out canWrite);

			if (canWrite < 1)
				throw (new Exception("Cannot write game"));
		}

		public bool IsFinished()
		{
			int isValid;
			Spel.Sudoku.isValid(out isValid);

			return (isValid == 1);
		}

		public Vak GetVak(int x, int y)
		{
			Vak vak;
			vak = Vakken[x, y];

			return vak;
		}
	}
}