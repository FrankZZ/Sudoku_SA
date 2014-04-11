using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;

namespace SA_Week2
{
	abstract class ClownDecorator : Clown
	{
		private Clown _decorated;

		public ClownDecorator(Clown decorated)
		{
			_decorated = decorated;
		}

		public virtual void draw(Canvas c)
		{
			_decorated.draw(c);
		}
	}
}
