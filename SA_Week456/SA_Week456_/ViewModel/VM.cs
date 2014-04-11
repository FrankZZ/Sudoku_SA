using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace SA_Week456_.ViewModel
{
	class VM
	{
		public static VakVM[,] vakVMs;
		static SudokuBasic.ISpel Spel;

		public static void Initialize()
		{
			vakVMs = new VakVM[9, 9];
			Spel = new SudokuBasic.Spel();
			Spel.Initialize();

			VM.Refresh();
		}

		public static void Save()
		{
			Spel.Save();
		}

		public static void Load()
		{
			Spel.Load();
		}

		public static void Hint()
		{
			Spel.Hint();
		}

		public static bool IsFinished()
		{
			if (!VM.Spel.IsFinished())
				return false;

			for (int x = 0; x < 9; x++)
			{
				for (int y = 0; y < 9; y++)
				{
					if (vakVMs[x, y] == null || vakVMs[x, y].IntValue == 0)
						return false;
				}
			}
			return true;
		}

		private static void Refresh()
		{
			for (int x = 0; x < 9; x++)
			{
				for (int y = 0; y < 9; y++)
				{
					vakVMs[x, y] = new VakVM();
					vakVMs[x, y].Vak = Spel.GetVak(x, y);
				}
			}
		}

		public static VakVM GetVakVM(int x, int y)
		{
			VakVM vak;

			vak = vakVMs[x, y];

			return vak;
		}
	}
}
