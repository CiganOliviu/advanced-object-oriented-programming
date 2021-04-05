using System;

namespace Constructors
{
    internal class Car
    {
        private readonly string _bodyStyle;
        private readonly string _platform;
        private readonly double _engineSize;
        private readonly int _numberOfPistons;
        private readonly int[] _productYears = new int[2];
        private readonly int _manufactureYear;
        private readonly int _horsePowers;

        public Car(string bodyStyle, string platform, double engineSize)
        {
            _bodyStyle = bodyStyle;
            _platform = platform;
            _engineSize = engineSize;
        }

        public Car(string bodyStyle, string platform, double engineSize, int numberOfPistons, int[] productYears) 
            : this (bodyStyle, platform, engineSize)
        {
            _numberOfPistons = numberOfPistons;
            _productYears = productYears;
        }

        public Car(string bodyStyle, string platform, double engineSize, int numberOfPistons, int[] productYears,
            int manufacturedYear, int horsePowers)
            : this(bodyStyle, platform, engineSize, numberOfPistons, productYears)
        {
            _manufactureYear = manufacturedYear;
            _horsePowers = horsePowers;
        }
        public void DisplayDetails()
        {
            if (_bodyStyle != "")
                Console.WriteLine(_bodyStyle);
        
            if (_platform != "")
                Console.WriteLine(_platform);
            
            if (_engineSize != 0)
                Console.WriteLine(_engineSize);
            
            if (_numberOfPistons != 0)
                Console.WriteLine(_numberOfPistons);
            
            if (_productYears[0] != 0 && _productYears[1] != 0)
                Console.WriteLine(_productYears[0] + " " + _productYears[1]);
            
            if (_manufactureYear != 0)
                Console.WriteLine(_manufactureYear);
            
            if (_horsePowers != 0)
                Console.WriteLine(_horsePowers);
            
            Console.WriteLine();
        }
    }
    
    
    internal static class Program
    {
        private static void Main(string[] args)
        {
            var carOne = new Car("Sedan", "Idk", 1900);
            carOne.DisplayDetails();
            
            var carTwo = new Car("Sedan", "Idk", 1900, 4, 
                new [] {1977, 1982});
            carTwo.DisplayDetails();

            var carThree = new Car("Sedan", "Idk", 1900, 4, 
                new [] {1977, 1982}, 1979, 190);
            carThree.DisplayDetails();
        }
    }
}