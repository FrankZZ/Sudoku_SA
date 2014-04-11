using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Drawing;
using System.Windows.Controls;
using System.Windows.Shapes;

namespace SA_Week2
{
	class Rechteroog : ClownDecorator
	{
		public Rechteroog(Clown decorated) : base(decorated)
		{

		}

		public override void draw(Canvas c)
		{
			base.draw(c);
			// Draw oog

			// een lijn tekenen

			Line myLine = new Line();
			myLine.Stroke = System.Windows.Media.Brushes.LightSteelBlue;
			myLine.X1 = 80;
			myLine.X2 = 130;
			myLine.Y1 = 100;
			myLine.Y2 = 100;
			myLine.HorizontalAlignment = HorizontalAlignment.Left;
			myLine.VerticalAlignment = VerticalAlignment.Center;
			myLine.StrokeThickness = 2;
			c.Children.Add(myLine);
		}
	}
}
