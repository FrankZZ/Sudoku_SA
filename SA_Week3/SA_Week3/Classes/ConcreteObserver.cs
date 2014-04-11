using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SA_Week3.Utils;
using System.Windows.Controls;

namespace SA_Week3.Classes
{
	public class ConcreteObserver : Label, IObserver
	{
		public void Update(ISubject o)
		{
			this.Content = ((ConcreteSubject)o).ToString();
		}
	}
}
