namespace Inheritance
{
    public class Beverage : Product
    {
        public Beverage(string name, double price) : base(name, price)
        {
            
        }

        public string GetDetails()
        {
            var details = GetName() + ", " + GetPrice();

            return details;
        }
    }
}