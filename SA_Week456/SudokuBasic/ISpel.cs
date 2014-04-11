using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudokuBasic
{
    public interface ISpel
    {
        void Initialize();
        Vak GetVak(int x, int y);

		void Hint();
		void Load();
		void Save();

		bool IsFinished();

    }
}
