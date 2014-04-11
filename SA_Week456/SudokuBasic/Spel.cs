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
		public Vak[,] vakken;


        public void Initialize()
		{

			vakken = new Vak[9, 9];
            
            Spel.Sudoku.create();

			for (int x = 0; x < 9; x++)
			{
				for (int y = 0; y < 9; y++)
				{
					vakken[x, y] = new Vak(x, y);
				}
			}

            for (int i = 0; i < 40; i++)
            {
                int hintPossible;
                int hintValue;
                int xx;
                int yy;

                Spel.Sudoku.hint(out hintPossible, out xx, out yy, out hintValue);

                if (hintPossible == 1)
                {
                    vakken[xx-1, yy-1].Value = hintValue;
                }
            }

		}

		public Vak GetVak(int x, int y)
		{
			Vak vak;
			vak = vakken[x, y];

			return vak;
		}
	}
}