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
        }
    }
}