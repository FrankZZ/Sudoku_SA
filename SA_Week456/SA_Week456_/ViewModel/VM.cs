using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace SA_Week456_.ViewModel
{
	class VM
	{
		public static VakVM[,] vakVMs;
        static SudokuBasic.ISpel spel;

		public static void Initialize()
		{
			vakVMs = new VakVM[9, 9];
            spel = new SudokuBasic.Spel();
            spel.Initialize();

			for (int x = 0; x < 9; x++)
			{
				for (int y = 0; y < 9; y++)
				{
					vakVMs[x, y] = new VakVM();
					vakVMs[x, y].Vak = spel.GetVak(x, y);
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
