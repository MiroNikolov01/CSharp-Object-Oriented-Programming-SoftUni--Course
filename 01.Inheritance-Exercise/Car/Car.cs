namespace NeedForSpeed;

public class Car : Vehicle
{
    public override double FuelConsumption { get; set; } = 3;

    public Car(int horsePower, double fuel) : base(horsePower, fuel)
    {
        this.DefaultFuelConsumption = 3;
        this.FuelConsumption = this.DefaultFuelConsumption;
    }
}