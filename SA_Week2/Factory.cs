using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SA_Week2
{
	class Factory
	{
		public static Clown GetClown(bool[] baChoice)
		{
			Clown clown = new ClownKaal();

			for (int i = 0; i < baChoice.Length; i++)
			{
				if (baChoice[i])
				{
					switch (i)
					{
						case 0: clown = new Linkeroog(clown); break;
						case 1: clown = new Rechteroog(clown); break;
					}
				}
			}

			return clown;
		}
	}
}
