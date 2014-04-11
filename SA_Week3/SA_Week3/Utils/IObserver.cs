using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SA_Week3.Utils
{
	public interface IObserver
	{
		void Update(ISubject s);
	}
}
