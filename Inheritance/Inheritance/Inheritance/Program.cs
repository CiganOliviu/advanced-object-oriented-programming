using System;

namespace Inheritance
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            var beverage = new Beverage("Coca Cola", 7);
            Console.WriteLine(beverage.GetDetails());
        }
    }
}