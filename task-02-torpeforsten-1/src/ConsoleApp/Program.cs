using System;
using ShapesLibrary;

namespace ConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Instantiate Rectangle with width 6 and height 9
            Rectangle rectangle = new Rectangle(6, 9);
            // Instantiate Circle with radius 13
            Circle circle = new Circle(13);

            // Write the ToString() outputs to the console
            Console.WriteLine(rectangle.ToString());
            Console.WriteLine(circle.ToString());
        }
    }
}