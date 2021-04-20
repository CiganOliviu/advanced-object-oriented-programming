using System;

namespace Shapes
{
    public class Circle : IShape
    {
        private readonly int _radius;

        public Circle(int radius)
        {
            _radius = radius;
        }

        public int GetRadius()
        {
            return _radius;
        }
        
        public int GetArea()
        {
            return (int) (_radius * _radius * Math.PI);
        }

        public void DisplayDimensions()
        {
            Console.WriteLine(_radius);
        }
    }
}