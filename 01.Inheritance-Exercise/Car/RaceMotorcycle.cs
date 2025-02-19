namespace NeedForSpeed;

public class RaceMotorcycle : Motorcycle
{
    public override double FuelConsumption { get; set; } = 8;

    public RaceMotorcycle(int horsePower, double fuel) : base(horsePower, fuel)
    {
        this.DefaultFuelConsumption = 8;
        this.FuelConsumption = this.DefaultFuelConsumption;
    }
}