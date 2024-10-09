using System;
using ConsoleApp;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World of .NET 8!");

        int width = args.Length > 0 ? int.Parse(args[0]) : default;
        int height = args.Length > 1 ? int.Parse(args[1]) : default;

        if (args.Length > 0)
        {
            Console.WriteLine($"Arguments: {string.Join(" ", args)}");
        }

        BasicCalculator calculator = new BasicCalculator();
        int? area = calculator.CalculateArea(width, height);

        if (area.HasValue)
        {
            Console.WriteLine($"Area of {width} and {height} is {area.Value}");
        }
        else
        {
            Console.WriteLine($"Area of {width} and {height} is null");
        }
    }
}