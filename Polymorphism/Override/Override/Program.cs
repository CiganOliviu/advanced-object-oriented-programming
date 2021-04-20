using System;

namespace Override
{
    internal class Product
    {
        private readonly string _className;

        protected Product()
        {
            _className = "Product";
        }

        public virtual string GetName()
        {
            return _className;
        }
    }

    internal class Chips : Product
    {
        private readonly string _className;

        public Chips()
        {
            _className = "Chips";
        }

        public override string GetName()
        {
            return base.GetName() + ", " + _className;
        }
    }
    
    internal static class Program
    {
        private static void Main(string[] args)
        {
            Product chips = new Chips();
            Console.WriteLine(chips.GetName());
        }
    }
}