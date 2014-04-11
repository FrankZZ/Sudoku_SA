using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Controls;

namespace SA_Week2
{
	class Task
	{
		public void go(bool[] baChoice, Canvas canvas)
		{
			Clown clown = Factory.GetClown(baChoice);
			clown.draw(canvas);
		}
	}
}
