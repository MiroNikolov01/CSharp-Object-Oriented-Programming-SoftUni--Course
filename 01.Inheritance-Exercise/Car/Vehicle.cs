namespace NeedForSpeed;

public class Vehicle
{
    protected double DefaultFuelConsumption { get; set; } = 1.25;
    public virtual double FuelConsumption { get; set; }
    public double Fuel { get; set; }
    public int HorsePower { get; set; }

    public Vehicle(int horsePower, double fuel)
    {
        this.HorsePower = horsePower;
        this.Fuel = fuel;
        this.FuelConsumption = DefaultFuelConsumption;
    }

    public virtual void Drive(double kilometers)
    {
        double neededFuel = kilometers * this.FuelConsumption;
        if (neededFuel <= Fuel)
        {
            this.Fuel -= kilometers * this.FuelConsumption;
        }
    }
}