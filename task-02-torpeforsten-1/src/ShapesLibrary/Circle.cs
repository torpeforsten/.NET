using System;
using System.Globalization;

namespace ShapesLibrary
{
public class Circle : IShape
    {
        public double Radius { get; set; }

        // Parameterless constructor
        public Circle()
        {
            Radius = 0;
        }

        // Constructor with radius parameter
        public Circle(double radius)
        {
            Radius = radius;
        }

        // Implementing Area method
        public double Area()
        {
            return Math.PI * Radius * Radius;
        }

        // Implementing Circumference method
        public double Circumference()
        {
            return 2 * Math.PI * Radius;
        }

        // Overriding ToString method
        public override string ToString()
        {
            return string.Format(CultureInfo.CurrentCulture,
                "Circle with radius {0:F2} has area {1:F2} and circumference {2:F2}",
                Radius, Area(), Circumference());
        }
    }
}