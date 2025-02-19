namespace NeedForSpeed;

public class SportCar : Car
{
    public override double FuelConsumption { get; set; } = 10;

    public SportCar(int horsePower, double fuel) : base(horsePower, fuel)
    {
        this.DefaultFuelConsumption = 10;
        this.FuelConsumption = this.DefaultFuelConsumption;
    }
}