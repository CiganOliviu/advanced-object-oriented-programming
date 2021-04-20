using System;

namespace Shapes
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            IShape rectangle = new Rectangle(3, 4);

            Console.WriteLine(rectangle.GetArea());
            rectangle.DisplayDimensions();

            var circle = new Circle(5);
            Console.WriteLine(circle.GetArea());
            circle.DisplayDimensions();
            
            Console.WriteLine(circle.GetRadius());
        }
    }
}