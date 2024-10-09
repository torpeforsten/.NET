using System.Globalization;
using System;

namespace ShapesLibrary
{
    // Rectangle class implementing IShape interface
public class Rectangle : IShape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        // Parameterless constructor
        public Rectangle()
        {
            Width = 0;
            Height = 0;
        }

        // Constructor with width and height parameters
        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        // Implementing Area method
        public double Area()
        {
            return Width * Height;
        }

        // Implementing Circumference method
        public double Circumference()
        {
            return 2 * (Width + Height);
        }

        // Overriding ToString method
        public override string ToString()
        {
            return string.Format(CultureInfo.CurrentCulture,
                "Rectangle with width {0:F2} and height {1:F2} has area {2:F2} and circumference {3:F2}",
                Width, Height, Area(), Circumference());
        }
    }
}