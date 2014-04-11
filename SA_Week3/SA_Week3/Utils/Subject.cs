using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Timers;

namespace SA_Week3.Utils
{
	public class Subject : ISubject
	{
		private List<IObserver> _observers;

		public Subject()
		{
			_observers = new List<IObserver>();
		}

		public void Attach(IObserver o)
		{
			_observers.Add(o);
			o.Update(this);
		}

		public void Detach(IObserver o)
		{
			_observers.Remove(o);
		}

		public void Notify()
		{
			foreach(IObserver o in _observers)
			{
				o.Update(this);
			}
		}
	}
}
