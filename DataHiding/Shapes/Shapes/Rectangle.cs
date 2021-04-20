using System;

namespace Shapes
{
    public class Rectangle : IShape
    {
        private readonly int _length;
        private readonly int _width;

        public Rectangle(int width, int length)
        {
            _width = width;
            _length = length;
        }

        public int GetArea()
        {
            return _width * _length;
        }

        public void DisplayDimensions()
        {
            Console.Write(_length + " " + _width);
        }
    }
}