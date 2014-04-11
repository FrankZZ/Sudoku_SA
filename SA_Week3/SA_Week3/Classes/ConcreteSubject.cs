using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SA_Week3.Utils;

namespace SA_Week3.Classes
{
	public class ConcreteSubject : Subject
	{
		private int _content;
		private static Random _rand = new Random();

		public ConcreteSubject()
		{
			refresh();
		}

		public void refresh()
		{
			_content = _rand.Next();
			Notify();
		}

		public override String ToString()
		{
			return _content.ToString();
		}
	}
}
