using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace SA_Week2
{
	class Linkeroog : ClownDecorator
	{
		public Linkeroog(Clown decorated) : base(decorated)
		{

		}

		public override void draw(Canvas c)
		{
			base.draw(c);
			// Draw oog
			// een cirkel tekenen

			// Create a red Ellipse.
			Ellipse myEllipse = new Ellipse();

			// Create a SolidColorBrush with a red color to fill the 
			// Ellipse with.
			SolidColorBrush mySolidColorBrush = new SolidColorBrush();

			// Describes the brush's color using RGB values. 
			// Each value has a range of 0-255.
			mySolidColorBrush.Color = Color.FromArgb(255, 255, 0, 0);
			myEllipse.Fill = mySolidColorBrush;
			myEllipse.StrokeThickness = 2;
			myEllipse.Stroke = Brushes.Black;

			// Set the width and height of the Ellipse.
			myEllipse.Width = 20;
			myEllipse.Height = 20;

			// Set the position
			myEllipse.SetValue(Canvas.LeftProperty, 93.0);
			myEllipse.SetValue(Canvas.TopProperty, 60.0);

			// Add the Ellipse to the StackPanel.
			c.Children.Add(myEllipse);
		}
	}
}
