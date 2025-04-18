using Restaurant;

namespace Restaurant;

public class Beverage  : Product
{
    public double Milliliters { get; set; }

    public Beverage(string name, decimal price, double milliliters) : base(name, price)
    {
        this.Milliliters = milliliters;
    }
}