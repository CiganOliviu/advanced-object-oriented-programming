using System;

namespace Aggregation
{

    internal class VendingMachine
    {
        private readonly Product[] _productShelf;
        private readonly int _capacity;
        private static int _productCount;

        public VendingMachine()
        {
            _productShelf = new Product[5];
            _capacity = 5;
            _productCount = 0;
        }

        public bool InsertProduct(Product item)
        {
            if (_productCount > _capacity)
                return false;

            _productShelf[_productCount] = item;
            _productCount++;

            return true;
        }
        
        public void PrintProducts()
        {
            for (var it = 0; it < this._capacity; it++)
            {
                _productShelf[it].PrintDetails();
            }
        }
    }

    internal class Product
    {
        private readonly string _name;
        private readonly double _price;

        public Product(string name, double price)
        {
            _name = name;
            _price = price;
        }

        public void PrintDetails()
        {
            Console.WriteLine(_name + "" + _price);
        }
    }
    
    internal static class Program
    {
        private static void Main(string[] args)
        {
            var myVendingMachine = new VendingMachine();
            
            var snack = new Product("Rango Tango", 0.5);
            var drink = new Product("Mineral Water", 0.7);
            var chocolate = new Product("Crunchy", 1);
            var energyDrink = new Product("Red Bull", 3);
            var popcorn = new Product("Caramel pop", 0.5);
            
            myVendingMachine.InsertProduct(snack);
            myVendingMachine.InsertProduct(drink);
            myVendingMachine.InsertProduct(chocolate);
            myVendingMachine.InsertProduct(energyDrink);
            myVendingMachine.InsertProduct(popcorn);
            
            myVendingMachine.PrintProducts();
            
            myVendingMachine = null;
            
            Console.WriteLine("\nThe Products still exist!");
            snack.PrintDetails();
            drink.PrintDetails();
            chocolate.PrintDetails();
            energyDrink.PrintDetails();
            popcorn.PrintDetails();
        }
    }
}